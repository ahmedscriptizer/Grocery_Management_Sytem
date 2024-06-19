using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace db2
{
    public partial class Form1 : Form
    {
        private static IMongoClient client = new MongoClient("mongodb://localhost:27017");
        private static IMongoDatabase db = client.GetDatabase("Al_Fatah");
        private static IMongoCollection<User> coll = db.GetCollection<User>("loginform");

        public Form1()
        {
            InitializeComponent();
        }

        public class User
        {
            [BsonId] // computer generated ID
            public ObjectId Id { get; set; }

            [BsonElement("username")]
            public string Username { get; set; }

            [BsonElement("password")]
            public string Password { get; set; }

            public User(string username, string password)
            {
                Username = username;
                Password = password;
            }
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text.Trim(); // Trim the password to remove leading and trailing whitespace

            try
            {
                // Check if the username exists
                var filter = Builders<User>.Filter.Eq(u => u.Username, username);
                var existingUser = coll.Find(filter).FirstOrDefault();

                if (existingUser != null)
                {
                    // Compare the entered password with the stored password
                    if (existingUser.Password == password)
                    {
                        MessageBox.Show("Correct password!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        new Menu().Show();   
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Wrong password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Username does not exist. Please register first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
