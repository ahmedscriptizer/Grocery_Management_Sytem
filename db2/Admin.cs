using System;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace db2
{
    public partial class Admin : Form
    {
        private static IMongoClient client = new MongoClient("mongodb://localhost:27017");
        private static IMongoDatabase db = client.GetDatabase("Al_Fatah");
        private static IMongoCollection<User> coll = db.GetCollection<User>("loginform");

        // Class-level variables to store the user details
        private string username;
        private string password;

        // Flag to control event handler execution
        private bool isSaving = false;

        public Admin()
        {
            InitializeComponent();
            LoadData(); // Load data when the form initializes
        }

        public class User
        {
            [BsonId]
            public ObjectId Id { get; set; }

            [BsonElement("username")]
            public string Username { get; set; }

            [BsonElement("password")]
            public string Password { get; set; }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (!isSaving)
            {
                username = txtUsername.Text.Trim();
                if (string.IsNullOrWhiteSpace(username))
                {
                    MessageBox.Show("Invalid username. Please enter a valid username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (!isSaving)
            {
                password = txtPassword.Text.Trim();
                if (string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Invalid password. Please enter a valid password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btnADD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and password are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            isSaving = true;

            try
            {
                var newUser = new User
                {
                    Username = username,
                    Password = password
                };

                await coll.InsertOneAsync(newUser);
                MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the input fields
                txtUsername.Clear();
                txtPassword.Clear();

                LoadData(); // Load data after saving
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                isSaving = false;
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Username is required to update the user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var filter = Builders<User>.Filter.Eq("username", username);
            var update = Builders<User>.Update
                .Set("password", password);

            isSaving = true;

            try
            {
                var result = await coll.UpdateOneAsync(filter, update);

                if (result.MatchedCount > 0)
                {
                    MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear the input fields
                    txtUsername.Clear();
                    txtPassword.Clear();

                    LoadData(); // Load data after updating
                }
                else
                {
                    MessageBox.Show("Username not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                isSaving = false;
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Username is required to delete the user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var filter = Builders<User>.Filter.Eq("username", username);

            try
            {
                var result = await coll.DeleteOneAsync(filter);

                if (result.DeletedCount > 0)
                {
                    MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear the input fields
                    txtUsername.Clear();
                    txtPassword.Clear();

                    LoadData(); // Load data after deleting
                }
                else
                {
                    MessageBox.Show("Username not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string searchUsername = txtSearchbar.Text.Trim(); // Use txtSearchbar instead of txtUsername

            if (string.IsNullOrWhiteSpace(searchUsername))
            {
                MessageBox.Show("Please enter a username to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var filter = Builders<User>.Filter.Eq("username", searchUsername);
                var users = await coll.Find(filter).ToListAsync();

                if (users.Count > 0)
                {
                    dataGridView1.DataSource = users;
                }
                else
                {
                    MessageBox.Show("No users found with the given username.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = null; // Clear DataGridView if no users found
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching for users: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void LoadData()
        {
            try
            {
                var users = await coll.Find(new BsonDocument()).ToListAsync();
                dataGridView1.DataSource = users;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                txtUsername.Text = dataGridView1.SelectedRows[0].Cells["Username"].Value.ToString();
                txtPassword.Text = dataGridView1.SelectedRows[0].Cells["Password"].Value.ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Menu backform = new Menu();
            backform.Show();
            this.Close();
        }

        private async void txtSearchbar_TextChanged(object sender, EventArgs e)
        {
            string searchUsername = txtSearchbar.Text.Trim();

            try
            {
                if (!string.IsNullOrWhiteSpace(searchUsername))
                {
                    var filter = Builders<User>.Filter.Regex("username", new BsonRegularExpression(searchUsername, "i"));
                    var users = await coll.Find(filter).ToListAsync();
                    dataGridView1.DataSource = users;
                }
                else
                {
                    LoadData(); // Reload all data if search text is empty
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching for users: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
