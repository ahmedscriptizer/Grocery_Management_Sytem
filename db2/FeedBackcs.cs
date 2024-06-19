using System;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace db2
{
    public partial class FeedBackcs : Form
    {
        private static IMongoClient client = new MongoClient("mongodb://localhost:27017");
        private static IMongoDatabase db = client.GetDatabase("Al_Fatah");
        private static IMongoCollection<Feedback> coll = db.GetCollection<Feedback>("feedback");

        // Class-level variables to store feedback details
        private string customerId;
        private string topic;
        private string feedbackContent;

        // Flag to control event handler execution
        private bool isSaving = false;

        public FeedBackcs()
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
                Name = "customer_id",
                DataPropertyName = "CustomerId",
                HeaderText = "Customer ID"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "topic",
                DataPropertyName = "Topic",
                HeaderText = "Topic"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "feedback_content",
                DataPropertyName = "FeedbackContent",
                HeaderText = "Feedback Content"
            });
        }

        public class Feedback
        {
            [BsonId]
            public ObjectId Id { get; set; }

            [BsonElement("customerId")]
            public string CustomerId { get; set; }

            [BsonElement("topic")]
            public string Topic { get; set; }

            [BsonElement("feedback_content")]
            public string FeedbackContent { get; set; }
        }

        private void txtCustomerId_TextChanged(object sender, EventArgs e)
        {
            if (!isSaving)
            {
                customerId = txtCustomerId.Text.Trim();
                if (string.IsNullOrWhiteSpace(customerId))
                {
                    MessageBox.Show("Invalid customer ID. Please enter a valid customer ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtTopic_TextChanged(object sender, EventArgs e)
        {
            if (!isSaving)
            {
                topic = txtTopic.Text.Trim();
                if (string.IsNullOrWhiteSpace(topic))
                {
                    MessageBox.Show("Invalid topic. Please enter a valid topic.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtFeedback_TextChanged(object sender, EventArgs e)
        {
            if (!isSaving)
            {
                feedbackContent = txtFeedback.Text.Trim();
                if (string.IsNullOrWhiteSpace(feedbackContent))
                {
                    MessageBox.Show("Invalid feedback content. Please enter valid feedback content.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(customerId) || string.IsNullOrWhiteSpace(topic) || string.IsNullOrWhiteSpace(feedbackContent))
            {
                MessageBox.Show("Customer ID, topic, and feedback content are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            isSaving = true;

            try
            {
                var newFeedback = new Feedback
                {
                    CustomerId = customerId,
                    Topic = topic,
                    FeedbackContent = feedbackContent
                };

                coll.InsertOne(newFeedback);
                MessageBox.Show("Feedback saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the input fields
                txtCustomerId.Clear();
                txtTopic.Clear();
                txtFeedback.Clear();

                LoadData(); // Load data after saving
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving feedback: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                isSaving = false;
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(customerId))
            {
                MessageBox.Show("Customer ID is required to update the feedback.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var filter = Builders<Feedback>.Filter.Eq("customerId", customerId);
            var update = Builders<Feedback>.Update
                .Set("topic", topic)
                .Set("feedback_content", feedbackContent);

            isSaving = true;

            try
            {
                var result = await coll.UpdateOneAsync(filter, update);

                if (result.MatchedCount > 0)
                {
                    MessageBox.Show("Feedback updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear the input fields
                    txtCustomerId.Clear();
                    txtTopic.Clear();
                    txtFeedback.Clear();

                    LoadData(); // Load data after updating
                }
                else
                {
                    MessageBox.Show("Customer ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating feedback: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                isSaving = false;
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(customerId))
            {
                MessageBox.Show("Customer ID is required to delete the feedback.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var filter = Builders<Feedback>.Filter.Eq("customerId", customerId);

            try
            {
                var result = await coll.DeleteOneAsync(filter);

                if (result.DeletedCount > 0)
                {
                    MessageBox.Show("Feedback deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear the input fields
                    txtCustomerId.Clear();
                    txtTopic.Clear();
                    txtFeedback.Clear();

                    LoadData(); // Load data after deleting
                }
                else
                {
                    MessageBox.Show("Customer ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting feedback: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LoadData()
        {
            try
            {
                var feedbackList = await coll.Find(new BsonDocument()).ToListAsync();
                dataGridView1.DataSource = feedbackList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading feedback: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                txtCustomerId.Text = dataGridView1.SelectedRows[0].Cells["customer_id"].Value.ToString(); // Ensure column name matches
                txtTopic.Text = dataGridView1.SelectedRows[0].Cells["topic"].Value.ToString(); // Ensure column name matches
                txtFeedback.Text = dataGridView1.SelectedRows[0].Cells["feedback_content"].Value.ToString(); // Ensure column name matches
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string searchCustomerId = txtSearchbar.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchCustomerId))
            {
                MessageBox.Show("Please enter a customer ID to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var filter = Builders<Feedback>.Filter.Eq("customerId", searchCustomerId);
                var feedbackList = await coll.Find(filter).ToListAsync();

                if (feedbackList.Count > 0)
                {
                    dataGridView1.DataSource = feedbackList;
                }
                else
                {
                    MessageBox.Show("No feedback found with the given customer ID.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = null; // Clear DataGridView if no feedback found
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching for feedback: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
