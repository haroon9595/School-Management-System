using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace backup_form
{
    public partial class updatestd : UserControl
    {
        private int studentId;
        private string currentImagePath = ""; // To hold current image path for update

        // Constructor accepting student ID
        public updatestd(int id)
        {
            InitializeComponent();
            studentId = id;
        }

        // Load student data into controls
        private void updatestd_Load(object sender, EventArgs e)
        {
            try
            {
                dateTimePicker1.Value = DateTime.Today;
                LoadClasses();
                LoadStudentData(studentId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading student data: " + ex.Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Load all available classes into ComboBox
        private void LoadClasses()
        {
            string connectionString = @"Data Source=PIRZADAHAROON\SQLEXPRESS;Initial Catalog=schoolsysystem;Integrated Security=True;Encrypt=False";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ClassID, ClassName FROM Class";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);

                comboBoxClass.DisplayMember = "ClassName";
                comboBoxClass.ValueMember = "ClassID";
                comboBoxClass.DataSource = dt;
            }
        }

        // Load student data into form controls
        private void LoadStudentData(int id)
        {
            string connectionString = @"Data Source=PIRZADAHAROON\SQLEXPRESS;Initial Catalog=schoolsysystem;Integrated Security=True;Encrypt=False";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT s.StudentID, s.RollNumber, s.Name, s.FatherName, s.Contact, s.Email, 
                                 s.Gender, s.DOB, s.Address, c.ClassName, s.ClassID, s.ImagePath
                                 FROM Students s
                                 LEFT JOIN Class c ON s.ClassID = c.ClassID
                                 WHERE s.StudentID = @StudentID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StudentID", id);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    textBox1.Text = reader["Name"].ToString();
                    textBox4.Text = reader["RollNumber"].ToString();
                    textBox2.Text = reader["FatherName"].ToString();
                    textBox3.Text = reader["Contact"].ToString();
                    textBox5.Text = reader["Email"].ToString();
                    comboBox1.Text = reader["Gender"].ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(reader["DOB"]);
                    textBox6.Text = reader["Address"].ToString();
                    comboBoxClass.SelectedValue = reader["ClassID"];

                    currentImagePath = reader["ImagePath"]?.ToString() ?? "";

                    if (!string.IsNullOrEmpty(currentImagePath) && System.IO.File.Exists(currentImagePath))
                    {
                        pictureBox1.Image = Image.FromFile(currentImagePath);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        pictureBox1.Image = null;
                    }
                }
                else
                {
                    MessageBox.Show("Student not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Import Image Button
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        // Save Updated Data Button
        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (ValidateForm())
                {
                    UpdateStudentData(studentId);
                    MessageBox.Show("Student data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving student data: " + ex.Message, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Update student data in the database
        private void UpdateStudentData(int id)
        {
            string connectionString = @"Data Source=PIRZADAHAROON\SQLEXPRESS;Initial Catalog=schoolsysystem;Integrated Security=True;Encrypt=False";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Students SET 
                                 Name = @Name, 
                                 RollNumber = @RollNumber, 
                                 FatherName = @FatherName, 
                                 Contact = @Contact, 
                                 Email = @Email, 
                                 Gender = @Gender, 
                                 DOB = @DOB, 
                                 Address = @Address, 
                                 ClassID = @ClassID,
                                 ImagePath = @ImagePath
                                 WHERE StudentID = @StudentID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                cmd.Parameters.AddWithValue("@RollNumber", textBox4.Text);
                cmd.Parameters.AddWithValue("@FatherName", textBox2.Text);
                cmd.Parameters.AddWithValue("@Contact", textBox3.Text);
                cmd.Parameters.AddWithValue("@Email", textBox5.Text);
                cmd.Parameters.AddWithValue("@Gender", comboBox1.Text);
                cmd.Parameters.AddWithValue("@DOB", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@Address", textBox6.Text);
                cmd.Parameters.AddWithValue("@ClassID", comboBoxClass.SelectedValue);
                cmd.Parameters.AddWithValue("@ImagePath", string.IsNullOrEmpty(currentImagePath) ? (object)DBNull.Value : currentImagePath);
                cmd.Parameters.AddWithValue("@StudentID", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Validate form inputs before saving
        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text) ||
                string.IsNullOrWhiteSpace(textBox6.Text) ||
                comboBoxClass.SelectedIndex == -1 ||
                comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // Clear all form fields
        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            comboBoxClass.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Today;
            pictureBox1.Image = null;
            currentImagePath = "";
        }

        // Back Button to go back to the previous form
        private void button4_Click(object sender, EventArgs e)
        {
            adminForm parentForm = this.ParentForm as adminForm;
            if (parentForm != null)
            {
                parentForm.ShowUserControl(parentForm.dashboardForm1);  // Adjust if dashboardForm1 is not the correct control
            }
            else
            {
                MessageBox.Show("Parent form not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                currentImagePath = ofd.FileName; // Save the new path
            }
        }
    }
}
