using System;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace db2
{
    public partial class Promo : Form
    {
        private static IMongoClient client = new MongoClient("mongodb://localhost:27017");
        private static IMongoDatabase db = client.GetDatabase("Al_Fatah");
        private static IMongoCollection<Promotion> coll = db.GetCollection<Promotion>("Promotion");

        // Class-level variables to store the promotion details
        private string promotionCode;
        private string description;
        private string brandName;

        // Flag to control event handler execution
        private bool isSaving = false;

        public Promo()
        {
            InitializeComponent();
            SetupDataGridView();
            LoadData(); // Load data when the form initializes
        }

        private void SetupDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "promotion_code",
                DataPropertyName = "PromotionCode",
                HeaderText = "Promotion Code"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "brand_name",
                DataPropertyName = "BrandName",
                HeaderText = "Brand Name"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "description",
                DataPropertyName = "Description",
                HeaderText = "Description"
            });
        }

        public class Promotion
        {
            [BsonId]
            public ObjectId Id { get; set; }

            [BsonElement("brand_name")]
            public string BrandName { get; set; }

            [BsonElement("description")]
            public string Description { get; set; }

            [BsonElement("promotion_code")]
            public string PromotionCode { get; set; }
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            if (!isSaving)
            {
                promotionCode = txtCode.Text.Trim();
                if (string.IsNullOrWhiteSpace(promotionCode))
                {
                    MessageBox.Show("Invalid code. Please enter a valid promotion code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            if (!isSaving)
            {
                description = txtDescription.Text.Trim();
                if (string.IsNullOrWhiteSpace(description))
                {
                    MessageBox.Show("Invalid description. Please enter a valid description.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtBrand_TextChanged(object sender, EventArgs e)
        {
            if (!isSaving)
            {
                brandName = txtBrand.Text.Trim();
                if (string.IsNullOrWhiteSpace(brandName))
                {
                    MessageBox.Show("Invalid brand name. Please enter a valid brand name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(promotionCode) || string.IsNullOrWhiteSpace(description) || string.IsNullOrWhiteSpace(brandName))
            {
                MessageBox.Show("Promotion code, description, and brand name are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            isSaving = true;

            try
            {
                var newPromotion = new Promotion
                {
                    PromotionCode = promotionCode,
                    Description = description,
                    BrandName = brandName
                };

                coll.InsertOne(newPromotion);
                MessageBox.Show("Promotion saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the input fields
                txtCode.Clear();
                txtDescription.Clear();
                txtBrand.Clear();

                LoadData(); // Load data after saving
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving promotion: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                isSaving = false;
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(promotionCode))
            {
                MessageBox.Show("Promotion code is required to update the promotion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var filter = Builders<Promotion>.Filter.Eq("promotion_code", promotionCode);
            var update = Builders<Promotion>.Update
                .Set("brand_name", brandName)
                .Set("description", description);

            isSaving = true;

            try
            {
                var result = await coll.UpdateOneAsync(filter, update);

                if (result.MatchedCount > 0)
                {
                    MessageBox.Show("Promotion updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear the input fields
                    txtCode.Clear();
                    txtDescription.Clear();
                    txtBrand.Clear();

                    LoadData(); // Load data after updating
                }
                else
                {
                    MessageBox.Show("Promotion code not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating promotion: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                isSaving = false;
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(promotionCode))
            {
                MessageBox.Show("Promotion code is required to delete the promotion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var filter = Builders<Promotion>.Filter.Eq("promotion_code", promotionCode);

            try
            {
                var result = await coll.DeleteOneAsync(filter);

                if (result.DeletedCount > 0)
                {
                    MessageBox.Show("Promotion deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear the input fields
                    txtCode.Clear();
                    txtDescription.Clear();
                    txtBrand.Clear();

                    LoadData(); // Load data after deleting
                }
                else
                {
                    MessageBox.Show("Promotion code not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting promotion: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LoadData()
        {
            try
            {
                var promotions = await coll.Find(new BsonDocument()).ToListAsync();
                dataGridView1.DataSource = promotions;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading promotions: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                txtCode.Text = dataGridView1.SelectedRows[0].Cells["promotion_code"].Value.ToString(); // Ensure column name matches
                txtBrand.Text = dataGridView1.SelectedRows[0].Cells["brand_name"].Value.ToString(); // Ensure column name matches
                txtDescription.Text = dataGridView1.SelectedRows[0].Cells["description"].Value.ToString(); // Ensure column name matches
            }
        }

        private void txtSearchbar_TextChanged(object sender, EventArgs e)
        {
            // Optionally, you can handle real-time search here
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string searchPromotionCode = txtSearchbar.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchPromotionCode))
            {
                MessageBox.Show("Please enter a promotion code to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var filter = Builders<Promotion>.Filter.Eq("promotion_code", searchPromotionCode);
                var promotions = await coll.Find(filter).ToListAsync();

                if (promotions.Count > 0)
                {
                    dataGridView1.DataSource = promotions;
                }
                else
                {
                    MessageBox.Show("No promotions found with the given code.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = null; // Clear DataGridView if no promotions found
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching for promotions: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
