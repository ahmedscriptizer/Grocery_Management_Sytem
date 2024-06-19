using System;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace db2
{
    public partial class Invent : Form
    {
        private static IMongoClient client = new MongoClient("mongodb://localhost:27017");
        private static IMongoDatabase db = client.GetDatabase("Al_Fatah");
        private static IMongoCollection<Inventory> coll = db.GetCollection<Inventory>("inventory");

        private string inventoryCode;
        private int quantityStock;
        private string location;

        private bool isSaving = false;

        public Invent()
        {
            InitializeComponent();
            LoadData();
        }

        public class Inventory
        {
            [BsonId]
            public ObjectId Id { get; set; }

            [BsonElement("Inventory_code")]
            public string InventoryCode { get; set; }

            [BsonElement("quantity_stock")]
            public int QuantityStock { get; set; }

            [BsonElement("location")]
            public string Location { get; set; }
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            if (!isSaving)
            {
                inventoryCode = txtCode.Text.Trim();
                if (string.IsNullOrWhiteSpace(inventoryCode))
                {
                    MessageBox.Show("Invalid Code. Please enter a valid inventory code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {
            if (!isSaving)
            {
                if (int.TryParse(txtStock.Text.Trim(), out quantityStock))
                {
                    if (quantityStock < 0)
                    {
                        MessageBox.Show("Invalid quantity. Please enter a non-negative number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid quantity. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {
            if (!isSaving)
            {
                location = txtLocation.Text.Trim();
                if (string.IsNullOrWhiteSpace(location))
                {
                    MessageBox.Show("Invalid location. Please enter a valid location.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inventoryCode) || string.IsNullOrWhiteSpace(location) || quantityStock < 0)
            {
                MessageBox.Show("Inventory code, quantity, and location are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            isSaving = true;

            try
            {
                var newInventory = new Inventory
                {
                    InventoryCode = inventoryCode,
                    QuantityStock = quantityStock,
                    Location = location
                };

                await coll.InsertOneAsync(newInventory);
                MessageBox.Show("Inventory added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCode.Clear();
                txtStock.Clear();
                txtLocation.Clear();

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding inventory: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                isSaving = false;
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inventoryCode))
            {
                MessageBox.Show("Inventory code is required to update the inventory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var filter = Builders<Inventory>.Filter.Eq("Inventory_code", inventoryCode);
            var update = Builders<Inventory>.Update
                .Set("quantity_stock", quantityStock)
                .Set("location", location);

            isSaving = true;

            try
            {
                var result = await coll.UpdateOneAsync(filter, update);

                if (result.MatchedCount > 0)
                {
                    MessageBox.Show("Inventory updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtCode.Clear();
                    txtStock.Clear();
                    txtLocation.Clear();

                    LoadData();
                }
                else
                {
                    MessageBox.Show("Inventory code not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating inventory: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                isSaving = false;
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inventoryCode))
            {
                MessageBox.Show("Inventory code is required to delete the inventory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var filter = Builders<Inventory>.Filter.Eq("Inventory_code", inventoryCode);

            try
            {
                var result = await coll.DeleteOneAsync(filter);

                if (result.DeletedCount > 0)
                {
                    MessageBox.Show("Inventory deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtCode.Clear();
                    txtStock.Clear();
                    txtLocation.Clear();

                    LoadData();
                }
                else
                {
                    MessageBox.Show("Inventory code not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting inventory: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LoadData()
        {
            try
            {
                var inventories = await coll.Find(new BsonDocument()).ToListAsync();
                dataGridView1.DataSource = inventories;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading inventories: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string searchInventoryCode = txtSearchbar.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchInventoryCode))
            {
                MessageBox.Show("Please enter an inventory code to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var filter = Builders<Inventory>.Filter.Eq("Inventory_code", searchInventoryCode);
                var inventories = await coll.Find(filter).ToListAsync();

                if (inventories.Count > 0)
                {
                    dataGridView1.DataSource = inventories;
                }
                else
                {
                    MessageBox.Show("No inventories found with the given code.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching for inventories: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtCode.Text = dataGridView1.SelectedRows[0].Cells["InventoryCode"].Value.ToString();
                txtStock.Text = dataGridView1.SelectedRows[0].Cells["QuantityStock"].Value.ToString();
                txtLocation.Text = dataGridView1.SelectedRows[0].Cells["Location"].Value.ToString();
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
