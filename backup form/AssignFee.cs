using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace backup_form
{
    public partial class AssignFee : UserControl
    {
        private string connectionString = @"Data Source=PIRZADAHAROON\SQLEXPRESS;Initial Catalog=schoolsysystem;Integrated Security=True;Encrypt=False";

        public AssignFee()
        {
            InitializeComponent();
        }

        private void AssignFee_Load(object sender, EventArgs e)
        {
            // Load classes into the ComboBox on form load
            LoadClasses();
            LoadFees();
        }


        private void LoadClasses()
        {
            comboBoxClass.Items.Clear(); // Clear previous entries
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT ClassID, ClassName FROM dbo.Class"; // Explicitly mention dbo schema
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    // Use a Dictionary-like KeyValuePair to store ClassID and display ClassName
                    while (reader.Read())
                    {
                        comboBoxClass.Items.Add(new KeyValuePair<int, string>(
                            Convert.ToInt32(reader["ClassID"]),
                            reader["ClassName"].ToString()
                        ));
                    }

                    reader.Close();
                    comboBoxClass.DisplayMember = "Value"; // Show ClassName in dropdown
                    comboBoxClass.ValueMember = "Key";     // Use ClassID internally
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading classes: " + ex.Message);
                }
            }
        }


        private void buttonAssignFee_Click(object sender, EventArgs e)
        {
            if (comboBoxClass.SelectedItem == null)
            {
                MessageBox.Show("Please select a class.");
                return;
            }

            var selectedClass = (KeyValuePair<int, string>)comboBoxClass.SelectedItem;
            string feeAmountText = textBoxFeeAmount.Text;

            if (selectedClass.Key == 0 || string.IsNullOrEmpty(feeAmountText) || !decimal.TryParse(feeAmountText, out decimal feeAmount))
            {
                MessageBox.Show("Please enter a valid fee amount.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO AssignedClassFees (ClassID, FeeAmount) VALUES (@ClassID, @FeeAmount)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ClassID", selectedClass.Key);
                    command.Parameters.AddWithValue("@FeeAmount", feeAmount);

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("✅ Fee assigned successfully.");
                        LoadFees();
                    }
                    else
                    {
                        MessageBox.Show("⚠️ Failed to assign fee.");
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601) // Unique constraint violation
                {
                    MessageBox.Show("⚠️ Fee is already assigned to this class.");
                }
                else
                {
                    MessageBox.Show("❌ Database Error: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error: " + ex.Message);
            }
        }


        private void buttonUpdateFee_Click(object sender, EventArgs e)
        {
            if (comboBoxClass.SelectedItem == null)
            {
                MessageBox.Show("Please select a class.");
                return;
            }

            var selectedClass = (KeyValuePair<int, string>)comboBoxClass.SelectedItem;
            string feeAmountText = textBoxFeeAmount.Text;

            // Check if fee amount is valid
            if (selectedClass.Key == 0 || string.IsNullOrEmpty(feeAmountText) || !decimal.TryParse(feeAmountText, out decimal feeAmount))
            {
                MessageBox.Show("Please enter a valid fee amount.");
                return;
            }

            // Update fee in database
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE AssignedClassFees SET FeeAmount = @FeeAmount WHERE ClassID = @ClassID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ClassID", selectedClass.Key);
                    command.Parameters.AddWithValue("@FeeAmount", feeAmount);

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Fee updated successfully.");
                        LoadFees(); // Refresh the DataGridView after update
                    }
                    else
                    {
                        MessageBox.Show("Failed to update fee.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadFees(string searchTerm = "")
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"SELECT f.FeeAssignID, c.ClassName, f.FeeAmount
                             FROM AssignedClassFees f
                             JOIN Class c ON f.ClassID = c.ClassID";

                    if (!string.IsNullOrWhiteSpace(searchTerm))
                    {
                        query += " WHERE c.ClassName LIKE @SearchTerm";
                    }

                    SqlCommand command = new SqlCommand(query, connection);

                    if (!string.IsNullOrWhiteSpace(searchTerm))
                    {
                        command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewFees.DataSource = dt;

                    // Hide FeeAssignID column
                    dataGridViewFees.Columns["FeeAssignID"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error: " + ex.Message);
                }
            }
        }


        private void pictureBoxSearchBtn_Click(object sender, EventArgs e)
        {
            
        }
        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pictureBoxSearchBtn_Click(sender, e); // Trigger search
            }
        }

        private void pictureBoxSearchBtn_Click_1(object sender, EventArgs e)
        {
            string search = textBoxSearch.Text.Trim();
            LoadFees(search);
        }
    }
}
