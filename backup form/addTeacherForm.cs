using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace backup_form
{
    public partial class addTeacherForm : UserControl
    {
        // Constructor
        public addTeacherForm()
        {
            InitializeComponent();
        }

        // Form Load event handler
        private void addTeacherForm_Load(object sender, EventArgs e)
        {
            button3.Click -= button3_Click;
            button1.Click -= button1_Click;
            button2.Click -= button2_Click;

            button3.Click += button3_Click;
            button1.Click += button1_Click;
            button2.Click += button2_Click;
        }

        // Save Teacher Data
        private void button2_Click(object sender, EventArgs e)
        {
            SaveTeacherData();
        }

        // Clear Form Fields
        private void button3_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        // Import Teacher Image
        private void button1_Click(object sender, EventArgs e)
        {
            ImportImage();
        }

        // Save Teacher Data to Database
        private void SaveTeacherData()
        {
            string teacherName = textBox1.Text;
            string fatherName = textBox2.Text;
            string contact = textBox3.Text;
            string email = textBox5.Text;
            string cnic = textBoxCnic.Text;  // Get Cnic value
            DateTime dob = dateTimePicker1.Value;
            string gender = comboBox1.SelectedItem?.ToString();
            string address = textBox6.Text;

            // Validation
            if (string.IsNullOrEmpty(teacherName) || string.IsNullOrEmpty(fatherName) || string.IsNullOrEmpty(contact) || string.IsNullOrEmpty(cnic))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            // Image path logic
            string imagePath = null;
            if (pictureBox1.Image != null)
            {
                imagePath = SaveImageToFileSystem(pictureBox1.Image);
            }

            // Database logic
            try
            {
                // SQL query to insert data
                string query = "INSERT INTO Teachers (Name, FatherName, Contact, Email, Cnic, DOB, Gender, Address, ImagePath) " +
                               "VALUES (@Name, @FatherName, @Contact, @Email, @Cnic, @DOB, @Gender, @Address, @ImagePath)";

                using (var connection = new SqlConnection("Data Source=PIRZADAHAROON\\SQLEXPRESS;Initial Catalog=schoolsysystem;Integrated Security=True;Encrypt=False")) // Add your connection string here
                {
                    var command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", teacherName);
                    command.Parameters.AddWithValue("@FatherName", fatherName);
                    command.Parameters.AddWithValue("@Contact", contact);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Cnic", cnic); // Add Cnic parameter
                    command.Parameters.AddWithValue("@DOB", dob);
                    command.Parameters.AddWithValue("@Gender", gender);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@ImagePath", imagePath ?? (object)DBNull.Value); // Save image path, or null if no image

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Teacher data saved successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Save image to file system and return the file path
        private string SaveImageToFileSystem(Image image)
        {
            try
            {
                string folderPath = @"C:\TeacherImages"; // Specify your folder for saving images
                if (!System.IO.Directory.Exists(folderPath))
                {
                    System.IO.Directory.CreateDirectory(folderPath);
                }

                string fileName = Guid.NewGuid().ToString() + ".jpg";
                string filePath = System.IO.Path.Combine(folderPath, fileName);
                image.Save(filePath);
                return filePath;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving image: " + ex.Message);
                return null;
            }
        }

        // Clear all form fields
        private void ClearForm()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBoxCnic.Clear(); // Clear Cnic TextBox
            comboBox1.SelectedIndex = -1;  // Clear ComboBox selection
            dateTimePicker1.Value = DateTime.Now;  // Reset DateTimePicker to current date
            pictureBox1.Image = null;  // Reset image if any
        }

        // Import image for teacher profile picture
        private void ImportImage()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
    }
}
