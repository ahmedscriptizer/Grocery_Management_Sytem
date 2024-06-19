using System;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace db2
{
    public partial class Custom : Form
    {
        private static IMongoClient client = new MongoClient("mongodb://localhost:27017");
        private static IMongoDatabase db = client.GetDatabase("Al_Fatah");
        private static IMongoCollection<Customer> coll = db.GetCollection<Customer>("Customer");

        private string customerCode;
        private string customerName;
        private string customerContact;
        private string customerStatus;

        private bool isSaving = false;

        public Custom()
        {
            InitializeComponent();
            LoadData(); // Load data when the form initializes
        }

        public class Customer
        {
            [BsonId]
            public ObjectId Id { get; set; }

            [BsonElement("Code")]
            public string Code { get; set; }

            [BsonElement("Name")]
            public string Name { get; set; }

            [BsonElement("Contact")]
            public string Contact { get; set; }

            [BsonElement("Status")]
            public string Status { get; set; }
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            if (!isSaving)
            {
                customerCode = txtCode.Text.Trim();
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (!isSaving)
            {
                customerName = txtName.Text.Trim();
            }
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            if (!isSaving)
            {
                customerContact = txtContact.Text.Trim();
            }
        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {
            if (!isSaving)
            {
                customerStatus = txtStatus.Text.Trim();
            }
        }

        private async void btnADD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(customerCode) || string.IsNullOrWhiteSpace(customerName) ||
                string.IsNullOrWhiteSpace(customerContact) || string.IsNullOrWhiteSpace(customerStatus))
            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            isSaving = true;

            try
            {
                var newCustomer = new Customer
                {
                    Code = customerCode,
                    Name = customerName,
                    Contact = customerContact,
                    Status = customerStatus
                };

                await coll.InsertOneAsync(newCustomer);
                MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the input fields
                txtCode.Clear();
                txtName.Clear();
                txtContact.Clear();
                txtStatus.Clear();

                LoadData(); // Load data after saving
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                isSaving = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Menu backform = new Menu();
            backform.Show();
            this.Close();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(customerCode))
            {
                MessageBox.Show("Customer code is required to update the customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var filter = Builders<Customer>.Filter.Eq("Code", customerCode);
            var update = Builders<Customer>.Update
                .Set("Name", customerName)
                .Set("Contact", customerContact)
                .Set("Status", customerStatus);

            isSaving = true;

            try
            {
                var result = await coll.UpdateOneAsync(filter, update);

                if (result.MatchedCount > 0)
                {
                    MessageBox.Show("Customer updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear the input fields
                    txtCode.Clear();
                    txtName.Clear();
                    txtContact.Clear();
                    txtStatus.Clear();

                    LoadData(); // Load data after updating
                }
                else
                {
                    MessageBox.Show("Customer code not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                isSaving = false;
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(customerCode))
            {
                MessageBox.Show("Customer code is required to delete the customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var filter = Builders<Customer>.Filter.Eq("Code", customerCode);

            try
            {
                var result = await coll.DeleteOneAsync(filter);

                if (result.DeletedCount > 0)
                {
                    MessageBox.Show("Customer deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear the input fields
                    txtCode.Clear();
                    txtName.Clear();
                    txtContact.Clear();
                    txtStatus.Clear();

                    LoadData(); // Load data after deleting
                }
                else
                {
                    MessageBox.Show("Customer code not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LoadData()
        {
            try
            {
                var customers = await coll.Find(new BsonDocument()).ToListAsync();
                dataGridView1.DataSource = customers;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            LoadData(); // Load data on view button click
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string searchCustomerCode = txtSearchbar.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchCustomerCode))
            {
                MessageBox.Show("Please enter a customer code to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var filter = Builders<Customer>.Filter.Eq("Code", searchCustomerCode);
                var customers = await coll.Find(filter).ToListAsync();

                if (customers.Count > 0)
                {
                    dataGridView1.DataSource = customers;
                }
                else
                {
                    MessageBox.Show("No customers found with the given code.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = null; // Clear DataGridView if no customers found
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching for customers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtCode.Text = dataGridView1.SelectedRows[0].Cells["Code"].Value.ToString();
                txtName.Text = dataGridView1.SelectedRows[0].Cells["Name"].Value.ToString();
                txtContact.Text = dataGridView1.SelectedRows[0].Cells["Contact"].Value.ToString();
                txtStatus.Text = dataGridView1.SelectedRows[0].Cells["Status"].Value.ToString();
            }
        }
    }
}
