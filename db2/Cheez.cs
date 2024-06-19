using System;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace db2
{
    public partial class Cheez : Form
    {
        private static IMongoClient client = new MongoClient("mongodb://localhost:27017");
        private static IMongoDatabase db = client.GetDatabase("Al_Fatah");
        private static IMongoCollection<chez> coll = db.GetCollection<chez>("products");

        // Class-level variables to store the product details
        private string productName;
        private decimal productPrice;
        private int productQuantity;
        private string productCategory;
        private string productCode;

        // Flag to control event handler execution
        private bool isSaving = false;

        public Cheez()
        {
            InitializeComponent();
            LoadData(); // Load data when the form initializes

            // Ensure the correct event handlers are assigned
            txtName.TextChanged += textBox1_TextChanged; // For product name
            txtPrice.TextChanged += txtPrice_TextChanged; // For product price
            txtQuantity.TextChanged += txtQuantity_TextChanged; // For product quantity
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged; // For product category
            txtCode.TextChanged += txtCode_TextChanged; // For product code
        }

        public class chez
        {
            [BsonId]
            public ObjectId Id { get; set; }

            [BsonElement("Product_Name")]
            public string ProductName { get; set; }

            [BsonElement("Product_Price")]
            public decimal ProductPrice { get; set; }

            [BsonElement("Product_Qty")]
            public int ProductQty { get; set; }

            [BsonElement("Product_Ctg")]
            public string ProductCtg { get; set; }

            [BsonElement("Product_Code")]
            public string ProductCode { get; set; }
        }

        // Event handler to capture product name
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!isSaving)
            {
                productName = txtName.Text.Trim();
                if (string.IsNullOrWhiteSpace(productName))
                {
                    MessageBox.Show("Invalid name. Please enter a valid name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Event handler to capture product price
        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if (!isSaving)
            {
                if (decimal.TryParse(txtPrice.Text.Trim(), out decimal price))
                {
                    productPrice = price;
                }
                else
                {
                    MessageBox.Show("Invalid price. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Event handler to capture product quantity
        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (!isSaving)
            {
                if (int.TryParse(txtQuantity.Text.Trim(), out int quantity))
                {
                    productQuantity = quantity;
                }
                else
                {
                    MessageBox.Show("Invalid quantity. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isSaving)
            {
                productCategory = comboBox1.SelectedItem?.ToString().Trim();
            }
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            if (!isSaving)
            {
                productCode = txtCode.Text.Trim();
                if (string.IsNullOrWhiteSpace(productCode))
                {
                    MessageBox.Show("Invalid code. Please enter a valid product code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(productName) || string.IsNullOrWhiteSpace(productCategory) || string.IsNullOrWhiteSpace(productCode))
            {
                MessageBox.Show("Product name, category, and code are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            isSaving = true;

            try
            {
                var newProduct = new chez
                {
                    ProductName = productName,
                    ProductPrice = productPrice,
                    ProductQty = productQuantity,
                    ProductCtg = productCategory,
                    ProductCode = productCode
                };

                coll.InsertOne(newProduct);
                MessageBox.Show("Product saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the input fields
                txtName.Clear();
                txtPrice.Clear();
                txtQuantity.Clear();
                comboBox1.SelectedIndex = -1;
                txtCode.Clear();

                LoadData(); // Load data after saving
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                isSaving = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu backform = new Menu();
            backform.Show();
            this.Close();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(productCode))
            {
                MessageBox.Show("Product code is required to update the product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var filter = Builders<chez>.Filter.Eq("Product_Code", productCode);
            var update = Builders<chez>.Update
                .Set("Product_Name", productName)
                .Set("Product_Price", productPrice)
                .Set("Product_Qty", productQuantity)
                .Set("Product_Ctg", productCategory);

            isSaving = true;

            try
            {
                var result = await coll.UpdateOneAsync(filter, update);

                if (result.MatchedCount > 0)
                {
                    MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear the input fields
                    txtName.Clear();
                    txtPrice.Clear();
                    txtQuantity.Clear();
                    comboBox1.SelectedIndex = -1;
                    txtCode.Clear();

                    LoadData(); // Load data after updating
                }
                else
                {
                    MessageBox.Show("Product code not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                isSaving = false;
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(productCode))
            {
                MessageBox.Show("Product code is required to delete the product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var filter = Builders<chez>.Filter.Eq("Product_Code", productCode);

            try
            {
                var result = await coll.DeleteOneAsync(filter);

                if (result.DeletedCount > 0)
                {
                    MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear the input fields
                    txtName.Clear();
                    txtPrice.Clear();
                    txtQuantity.Clear();
                    comboBox1.SelectedIndex = -1;
                    txtCode.Clear();

                    LoadData(); // Load data after deleting
                }
                else
                {
                    MessageBox.Show("Product code not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LoadData()
        {
            try
            {
                var products = await coll.Find(new BsonDocument()).ToListAsync();

                // Clear existing columns
                dataGridView1.Columns.Clear();

                // Add columns
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "ProductName",
                    HeaderText = "Product Name",
                    DataPropertyName = "ProductName"
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "ProductQty",
                    HeaderText = "Product Quantity",
                    DataPropertyName = "ProductQty"
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "ProductPrice",
                    HeaderText = "Product Price",
                    DataPropertyName = "ProductPrice"
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "ProductCtg",
                    HeaderText = "Product Category",
                    DataPropertyName = "ProductCtg"
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "ProductCode",
                    HeaderText = "Product Code",
                    DataPropertyName = "ProductCode"
                });

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = products;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            LoadData(); // Load data on view button click
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtCode.Text = dataGridView1.SelectedRows[0].Cells["ProductCode"].Value.ToString();
                txtName.Text = dataGridView1.SelectedRows[0].Cells["ProductName"].Value.ToString();
                txtQuantity.Text = dataGridView1.SelectedRows[0].Cells["ProductQty"].Value.ToString();
                txtPrice.Text = dataGridView1.SelectedRows[0].Cells["ProductPrice"].Value.ToString();
                comboBox1.Text = dataGridView1.SelectedRows[0].Cells["ProductCtg"].Value.ToString();
            }
        }

        private void txtSearchbar_TextChanged(object sender, EventArgs e)
        {
            // Optionally, you can handle real-time search here
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string searchProductCode = txtSearchbar.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchProductCode))
            {
                MessageBox.Show("Please enter a product code to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var filter = Builders<chez>.Filter.Eq("Product_Code", searchProductCode);
                var products = await coll.Find(filter).ToListAsync();

                if (products.Count > 0)
                {
                    dataGridView1.DataSource = products;
                }
                else
                {
                    MessageBox.Show("No products found with the given code.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = null; // Clear DataGridView if no products found
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching for products: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Menu goback = new Menu();
            goback.Show();
            this.Close();
        }
    }
}
