using System;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace db2
{
    public partial class Supplier : Form
    {
        private static IMongoClient client = new MongoClient("mongodb://localhost:27017");
        private static IMongoDatabase db = client.GetDatabase("Al_Fatah");
        private static IMongoCollection<SupplierInfo> coll = db.GetCollection<SupplierInfo>("Supplier");

        private string supplierCode;
        private string supplierName;
        private string supplierCountry;
        private string supplierContact;

        private bool isSaving = false;

        public Supplier()
        {
            InitializeComponent();
            LoadData();
        }

        public class SupplierInfo
        {
            [BsonId]
            public ObjectId Id { get; set; }

            [BsonElement("supplier_code")]
            public string SupplierCode { get; set; }

            [BsonElement("supplier_name")]
            public string SupplierName { get; set; }

            [BsonElement("supplier_country")]
            public string SupplierCountry { get; set; }

            [BsonElement("supplier_contact")]
            public string SupplierContact { get; set; }
        }

        private void txtSupplierCode_TextChanged(object sender, EventArgs e)
        {
            if (!isSaving)
            {
                supplierCode = txtSupplierCode.Text.Trim();
                if (string.IsNullOrWhiteSpace(supplierCode))
                {
                    MessageBox.Show("Invalid Code. Please enter a valid supplier code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (!isSaving)
            {
                supplierName = txtName.Text.Trim();
                if (string.IsNullOrWhiteSpace(supplierName))
                {
                    MessageBox.Show("Invalid name. Please enter a valid supplier name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtCountry_TextChanged(object sender, EventArgs e)
        {
            if (!isSaving)
            {
                supplierCountry = txtCountry.Text.Trim();
                if (string.IsNullOrWhiteSpace(supplierCountry))
                {
                    MessageBox.Show("Invalid country. Please enter a valid country.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            if (!isSaving)
            {
                supplierContact = txtContact.Text.Trim();
                if (string.IsNullOrWhiteSpace(supplierContact))
                {
                    MessageBox.Show("Invalid contact. Please enter a valid contact number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(supplierCode) || string.IsNullOrWhiteSpace(supplierName) || string.IsNullOrWhiteSpace(supplierCountry) || string.IsNullOrWhiteSpace(supplierContact))
            {
                MessageBox.Show("Supplier code, name, country, and contact are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            isSaving = true;

            try
            {
                var newSupplier = new SupplierInfo
                {
                    SupplierCode = supplierCode,
                    SupplierName = supplierName,
                    SupplierCountry = supplierCountry,
                    SupplierContact = supplierContact
                };

                await coll.InsertOneAsync(newSupplier);
                MessageBox.Show("Supplier added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtSupplierCode.Clear();
                txtName.Clear();
                txtCountry.Clear();
                txtContact.Clear();

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding supplier: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                isSaving = false;
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(supplierCode))
            {
                MessageBox.Show("Supplier code is required to update the supplier.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var filter = Builders<SupplierInfo>.Filter.Eq("supplier_code", supplierCode);
            var update = Builders<SupplierInfo>.Update
                .Set("supplier_name", supplierName)
                .Set("supplier_country", supplierCountry)
                .Set("supplier_contact", supplierContact);

            isSaving = true;

            try
            {
                var result = await coll.UpdateOneAsync(filter, update);

                if (result.MatchedCount > 0)
                {
                    MessageBox.Show("Supplier updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtSupplierCode.Clear();
                    txtName.Clear();
                    txtCountry.Clear();
                    txtContact.Clear();

                    LoadData();
                }
                else
                {
                    MessageBox.Show("Supplier code not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating supplier: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                isSaving = false;
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(supplierCode))
            {
                MessageBox.Show("Supplier code is required to delete the supplier.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var filter = Builders<SupplierInfo>.Filter.Eq("supplier_code", supplierCode);

            try
            {
                var result = await coll.DeleteOneAsync(filter);

                if (result.DeletedCount > 0)
                {
                    MessageBox.Show("Supplier deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtSupplierCode.Clear();
                    txtName.Clear();
                    txtCountry.Clear();
                    txtContact.Clear();

                    LoadData();
                }
                else
                {
                    MessageBox.Show("Supplier code not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting supplier: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LoadData()
        {
            try
            {
                var suppliers = await coll.Find(new BsonDocument()).ToListAsync();
                dataGridView1.DataSource = suppliers;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading suppliers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string searchSupplierCode = txtSearchbar.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchSupplierCode))
            {
                MessageBox.Show("Please enter a supplier code to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var filter = Builders<SupplierInfo>.Filter.Eq("supplier_code", searchSupplierCode);
                var suppliers = await coll.Find(filter).ToListAsync();

                if (suppliers.Count > 0)
                {
                    dataGridView1.DataSource = suppliers;
                }
                else
                {
                    MessageBox.Show("No suppliers found with the given code.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching for suppliers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtSupplierCode.Text = dataGridView1.SelectedRows[0].Cells["SupplierCode"].Value.ToString();
                txtName.Text = dataGridView1.SelectedRows[0].Cells["SupplierName"].Value.ToString();
                txtCountry.Text = dataGridView1.SelectedRows[0].Cells["SupplierCountry"].Value.ToString();
                txtContact.Text = dataGridView1.SelectedRows[0].Cells["SupplierContact"].Value.ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Menu backform = new Menu();
            backform.Show();
            this.Close();
        }
    }
}
