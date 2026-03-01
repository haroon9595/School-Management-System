using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace backup_form
{
    public partial class addstd : UserControl
    {
        private string _imagePath = null;

        public addstd()
        {
            InitializeComponent();
        }

        private void addstd_Load(object sender, EventArgs e)
        {
            LoadClassData();
        }
        public void RefreshClassComboBox()
        {
            // Clear any existing data source and items in the ComboBox
            comboBoxClass.DataSource = null; // Clear DataSource if it was bound
            //comboBoxClass.Items.Clear();     // Clear all items in the ComboBox

            // Reload the class data from the database
            LoadClassData();
        }


        // Method to load class data into the ComboBox
        public void LoadClassData()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=PIRZADAHAROON\SQLEXPRESS;Initial Catalog=schoolsysystem;Integrated Security=True;Encrypt=False"))
            {
                string query = "SELECT ClassID, ClassName FROM Class";  // You need ClassID too
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();

                try
                {
                    conn.Open();
                    adapter.Fill(dt);

                    comboBoxClass.DataSource = dt;
                    comboBoxClass.DisplayMember = "ClassName";
                    comboBoxClass.ValueMember = "ClassID";

                    if (comboBoxClass.Items.Count > 0)
                    {
                        comboBoxClass.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading classes: " + ex.Message);
                }
            }
        }




        // Method to delete a class from the database and refresh ComboBox
        private void DeleteClass(int classID)
        {
            string connectionString = @"Data Source=PIRZADAHAROON\SQLEXPRESS;Initial Catalog=schoolsysystem;Integrated Security=True;Encrypt=False";
            string query = "DELETE FROM Class WHERE ClassID = @ClassID";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ClassID", classID);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Class deleted successfully!");

                    // Refresh the combo box data after class deletion
                    LoadClassData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting class: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();

            comboBox1.SelectedIndex = -1;
            comboBoxClass.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
            pictureBox1.Image = null;
            _imagePath = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                string imageFilePath = SaveImage();
                SaveStudentData(imageFilePath);
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text) ||
                string.IsNullOrWhiteSpace(textBox6.Text) ||
                comboBox1.SelectedIndex == -1 ||
                comboBoxClass.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private string SaveImage()
        {
            string imageFilePath = null;
            if (_imagePath != null)
            {
                string directoryPath = Path.Combine(Application.StartupPath, "StudentImages");
                Directory.CreateDirectory(directoryPath);
                string imageFileName = Path.GetFileName(_imagePath);
                imageFilePath = Path.Combine(directoryPath, imageFileName);

                try
                {
                    File.Copy(_imagePath, imageFilePath, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return imageFilePath;
        }

        private void SaveStudentData(string imageFilePath)
        {
            string connectionString = @"Data Source=PIRZADAHAROON\SQLEXPRESS;Initial Catalog=schoolsysystem;Integrated Security=True;Encrypt=False";

            string queryStudent = @"INSERT INTO Students (Name, FatherName, RollNumber, Contact, Email, Gender, ClassID, DOB, Address, ImagePath)
                            VALUES (@Name, @FatherName, @RollNumber, @Contact, @Email, @Gender, @ClassID, @DOB, @Address, @ImagePath)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    int classID = Convert.ToInt32(comboBoxClass.SelectedValue);

                    SqlCommand cmdStudent = new SqlCommand(queryStudent, conn);
                    cmdStudent.Parameters.AddWithValue("@Name", textBox1.Text);
                    cmdStudent.Parameters.AddWithValue("@FatherName", textBox2.Text);
                    cmdStudent.Parameters.AddWithValue("@RollNumber", textBox4.Text);
                    cmdStudent.Parameters.AddWithValue("@Contact", textBox3.Text);
                    cmdStudent.Parameters.AddWithValue("@Email", textBox5.Text);
                    cmdStudent.Parameters.AddWithValue("@Gender", comboBox1.SelectedItem.ToString());
                    cmdStudent.Parameters.AddWithValue("@ClassID", classID);
                    cmdStudent.Parameters.AddWithValue("@DOB", dateTimePicker1.Value);
                    cmdStudent.Parameters.AddWithValue("@Address", textBox6.Text);
                    cmdStudent.Parameters.AddWithValue("@ImagePath", string.IsNullOrEmpty(imageFilePath) ? (object)DBNull.Value : imageFilePath);

                    cmdStudent.ExecuteNonQuery();
                    RefreshClassComboBox();

                    MessageBox.Show("Student added successfully!");
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving student data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _imagePath = openFileDialog.FileName;
                    pictureBox1.Image = Image.FromFile(_imagePath);
                }
            }
        }

        // Optional unused event handlers can be deleted if not used:
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void textBox6_TextChanged(object sender, EventArgs e) { }
        private void textBox7_TextChanged(object sender, EventArgs e) { }
        private void textBox7_TextChanged_1(object sender, EventArgs e) { }
    }
}
