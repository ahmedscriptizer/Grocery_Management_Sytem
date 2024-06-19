using System;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace db2
{
    public partial class Emp : Form
    {
        private static IMongoClient client = new MongoClient("mongodb://localhost:27017");
        private static IMongoDatabase db = client.GetDatabase("Al_Fatah");
        private static IMongoCollection<Employee> coll = db.GetCollection<Employee>("employees");

        private string employeeName;
        private string employeePosition;
        private string employeeContact;
        private string employeeRegistrationCode;

        private bool isSaving = false;

        public Emp()
        {
            InitializeComponent();
            LoadData();
        }

        public class Employee
        {
            [BsonId]
            public ObjectId Id { get; set; }

            [BsonElement("Employee_Name")]
            public string Name { get; set; }

            [BsonElement("Employee_Position")]
            public string Position { get; set; }

            [BsonElement("Employee_Contact")]
            public string Contact { get; set; }

            [BsonElement("Registration_Code")]
            public string RegistrationCode { get; set; }
        }

        private void txtRegistrationCode_TextChanged(object sender, EventArgs e)
        {
            if (!isSaving)
            {
                employeeRegistrationCode = txtRegistrationCode.Text.Trim();
                if (string.IsNullOrWhiteSpace(employeeRegistrationCode))
                {
                    MessageBox.Show("Invalid Registration Code. Please enter a valid code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (!isSaving)
            {
                employeeName = txtName.Text.Trim();
                if (string.IsNullOrWhiteSpace(employeeName))
                {
                    MessageBox.Show("Invalid name. Please enter a valid name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isSaving)
            {
                employeePosition = comboPosition.SelectedItem?.ToString().Trim();
            }
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            if (!isSaving)
            {
                employeeContact = txtContact.Text.Trim();
                if (string.IsNullOrWhiteSpace(employeeContact))
                {
                    MessageBox.Show("Invalid contact. Please enter a valid contact number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(employeeName) || string.IsNullOrWhiteSpace(employeePosition) || string.IsNullOrWhiteSpace(employeeContact) || string.IsNullOrWhiteSpace(employeeRegistrationCode))
            {
                MessageBox.Show("Employee name, position, contact, and registration code are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            isSaving = true;

            try
            {
                var newEmployee = new Employee
                {
                    Name = employeeName,
                    Position = employeePosition,
                    Contact = employeeContact,
                    RegistrationCode = employeeRegistrationCode
                };

                await coll.InsertOneAsync(newEmployee);
                MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtRegistrationCode.Clear();
                txtName.Clear();
                comboPosition.SelectedIndex = -1;
                txtContact.Clear();

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                isSaving = false;
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(employeeRegistrationCode))
            {
                MessageBox.Show("Employee registration code is required to update the employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var filter = Builders<Employee>.Filter.Eq("Registration_Code", employeeRegistrationCode);
            var update = Builders<Employee>.Update
                .Set("Employee_Name", employeeName)
                .Set("Employee_Position", employeePosition)
                .Set("Employee_Contact", employeeContact);

            isSaving = true;

            try
            {
                var result = await coll.UpdateOneAsync(filter, update);

                if (result.MatchedCount > 0)
                {
                    MessageBox.Show("Employee updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtRegistrationCode.Clear();
                    txtName.Clear();
                    comboPosition.SelectedIndex = -1;
                    txtContact.Clear();

                    LoadData();
                }
                else
                {
                    MessageBox.Show("Employee registration code not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                isSaving = false;
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(employeeRegistrationCode))
            {
                MessageBox.Show("Employee registration code is required to delete the employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var filter = Builders<Employee>.Filter.Eq("Registration_Code", employeeRegistrationCode);

            try
            {
                var result = await coll.DeleteOneAsync(filter);

                if (result.DeletedCount > 0)
                {
                    MessageBox.Show("Employee deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtRegistrationCode.Clear();
                    txtName.Clear();
                    comboPosition.SelectedIndex = -1;
                    txtContact.Clear();

                    LoadData();
                }
                else
                {
                    MessageBox.Show("Employee registration code not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LoadData()
        {
            try
            {
                var employees = await coll.Find(new BsonDocument()).ToListAsync();
                dataGridView1.DataSource = employees;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employees: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string searchRegistrationCode = txtSearchbar.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchRegistrationCode))
            {
                MessageBox.Show("Please enter an employee registration code to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var filter = Builders<Employee>.Filter.Eq("Registration_Code", searchRegistrationCode);
                var employees = await coll.Find(filter).ToListAsync();

                if (employees.Count > 0)
                {
                    dataGridView1.DataSource = employees;
                }
                else
                {
                    MessageBox.Show("No employees found with the given registration code.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching for employees: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtRegistrationCode.Text = dataGridView1.SelectedRows[0].Cells["RegistrationCode"].Value.ToString();
                txtName.Text = dataGridView1.SelectedRows[0].Cells["Name"].Value.ToString();
                comboPosition.Text = dataGridView1.SelectedRows[0].Cells["Position"].Value.ToString();
                txtContact.Text = dataGridView1.SelectedRows[0].Cells["Contact"].Value.ToString();
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
