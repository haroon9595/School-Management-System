using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace backup_form
{
    public partial class EditTeacherRecord : UserControl
    {
        string connectionString = "Data Source=PIRZADAHAROON\\SQLEXPRESS;Initial Catalog=schoolsysystem;Integrated Security=True;Encrypt=False";
        string selectedImagePath = "";

        public EditTeacherRecord()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string cnic = textBoxCnic.Text;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Teachers WHERE Cnic = @Cnic";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Cnic", cnic);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    textBoxName.Text = reader["Name"].ToString();
                    textBoxFatherName.Text = reader["FatherName"].ToString();
                    comboBoxGender.Text = reader["Gender"].ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(reader["DOB"]);
                    textBoxContact.Text = reader["Contact"].ToString();
                    textBoxEmail.Text = reader["Email"].ToString();
                    textBoxAddress.Text = reader["Address"].ToString();
                    selectedImagePath = reader["ImagePath"].ToString();

                    if (!string.IsNullOrEmpty(selectedImagePath) && File.Exists(selectedImagePath))
                    {
                        pictureBox1.Image = Image.FromFile(selectedImagePath);
                    }
                    else
                    {
                        pictureBox1.Image = null;
                    }
                }
                else
                {
                    MessageBox.Show("Teacher not found!");
                    ClearFields();
                }
            }
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = ofd.FileName;
                pictureBox1.Image = Image.FromFile(selectedImagePath);
            }
        }

        private void buttonClearFields_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string cnic = textBoxCnic.Text;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Teachers SET 
                                Name = @Name,
                                FatherName = @FatherName,
                                Gender = @Gender,
                                DOB = @DOB,
                                Contact = @Contact,
                                Email = @Email,
                                Address = @Address,
                                ImagePath = @ImagePath
                                WHERE Cnic = @Cnic";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", textBoxName.Text);
                cmd.Parameters.AddWithValue("@FatherName", textBoxFatherName.Text);
                cmd.Parameters.AddWithValue("@Gender", comboBoxGender.Text);
                cmd.Parameters.AddWithValue("@DOB", dateTimePicker1.Value.Date);
                cmd.Parameters.AddWithValue("@Contact", textBoxContact.Text);
                cmd.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                cmd.Parameters.AddWithValue("@Address", textBoxAddress.Text);
                cmd.Parameters.AddWithValue("@ImagePath", selectedImagePath);
                cmd.Parameters.AddWithValue("@Cnic", cnic);

                con.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Record updated successfully.");
                }
                else
                {
                    MessageBox.Show("Update failed.");
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string cnic = textBoxCnic.Text;

            DialogResult result = MessageBox.Show("Are you sure you want to delete this teacher?", "Confirm Delete", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // 1. Get TeacherID by CNIC
                    SqlCommand getIdCmd = new SqlCommand("SELECT TeacherID FROM Teachers WHERE Cnic = @Cnic", con);
                    getIdCmd.Parameters.AddWithValue("@Cnic", textBoxCnic.Text);
                    int teacherId = Convert.ToInt32(getIdCmd.ExecuteScalar());

                    // 2. Delete related records from TeacherAssignments
                    SqlCommand deleteAssignments = new SqlCommand("DELETE FROM TeacherAssignments WHERE TeacherID = @TeacherID", con);
                    deleteAssignments.Parameters.AddWithValue("@TeacherID", teacherId);
                    deleteAssignments.ExecuteNonQuery();

                    // 3. Delete teacher from Teachers
                    SqlCommand deleteTeacher = new SqlCommand("DELETE FROM Teachers WHERE TeacherID = @TeacherID", con);
                    deleteTeacher.Parameters.AddWithValue("@TeacherID", teacherId);
                    int rows = deleteTeacher.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Teacher deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Delete failed.");
                    }
                }

            }
        }

        private void ClearFields()
        {
            textBoxCnic.Clear();
            textBoxName.Clear();
            textBoxFatherName.Clear();
            comboBoxGender.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
            textBoxContact.Clear();
            textBoxEmail.Clear();
            textBoxAddress.Clear();
            selectedImagePath = "";
            pictureBox1.Image = null;
        }
    }
}
