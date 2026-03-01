using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace backup_form
{
    public partial class addClassSub : UserControl
    {
        string connectionString = @"Data Source=PIRZADAHAROON\SQLEXPRESS;Initial Catalog=schoolsysystem;Integrated Security=True;Encrypt=False";

        public addClassSub()
        {
            InitializeComponent();

            buttonAddClass.Click += ButtonAddClass_Click;
            buttonAddSubject.Click += ButtonAddSubject_Click;
            buttonDeleteClass.Click += ButtonDeleteClass_Click;
            buttonDeleteSubject.Click += ButtonDeleteSubject_Click;
        }

        private void NotifyClassChange()
        {
            Control control = this;
            while (control != null && !(control is adminForm))
            {
                control = control.Parent;
            }

            var parentForm = control as adminForm;
            if (parentForm != null)
            {
                var addStd = parentForm.Controls.OfType<addstd>().FirstOrDefault();
                if (addStd != null)
                {
                    addStd.RefreshClassComboBox();
                }
            }
        }



        // ADD CLASS
        private void ButtonAddClass_Click(object sender, EventArgs e)
        {

        }

        // ADD SUBJECT
        private void ButtonAddSubject_Click(object sender, EventArgs e)
        {

        }

        // DELETE CLASS
        private void ButtonDeleteClass_Click(object sender, EventArgs e)
        {
           
        }

        // DELETE SUBJECT
        private void ButtonDeleteSubject_Click(object sender, EventArgs e)
        {

        }

        private void addClassSub_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddSubject_Click_1(object sender, EventArgs e)
        {
            string subjectName = textBoxSubject.Text.Trim();

            if (string.IsNullOrEmpty(subjectName))
            {
                MessageBox.Show("Please enter a subject name.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Subjects (SubjectName) VALUES (@SubjectName)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SubjectName", subjectName);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Subject added successfully!");
                    textBoxSubject.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void buttonDeleteSubject_Click_1(object sender, EventArgs e)
        {
            string subjectName = textBoxSubject.Text.Trim();

            if (string.IsNullOrEmpty(subjectName))
            {
                MessageBox.Show("Please enter a subject name to delete.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Step 1: Get SubjectID
                    string getSubjectIdQuery = "SELECT TOP 1 SubjectID FROM Subjects WHERE SubjectName = @SubjectName";
                    SqlCommand getSubjectIdCmd = new SqlCommand(getSubjectIdQuery, conn);
                    getSubjectIdCmd.Parameters.AddWithValue("@SubjectName", subjectName);
                    object result = getSubjectIdCmd.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show("Subject not found.");
                        return;
                    }

                    int subjectID = Convert.ToInt32(result);

                    // Step 2: Check if assigned to teacher
                    string checkQuery = "SELECT COUNT(*) FROM TeacherSubject WHERE SubjectID = @SubjectID";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@SubjectID", subjectID);
                    int inUse = (int)checkCmd.ExecuteScalar();

                    if (inUse > 0)
                    {
                        MessageBox.Show("Cannot delete this subject. It is assigned to teachers.");
                        return;
                    }

                    // Step 3: Delete
                    string deleteQuery = "DELETE FROM Subjects WHERE SubjectID = @SubjectID";
                    SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn);
                    deleteCmd.Parameters.AddWithValue("@SubjectID", subjectID);

                    int rows = deleteCmd.ExecuteNonQuery();
                    MessageBox.Show(rows > 0 ? "Subject deleted." : "Subject not found.");
                    textBoxSubject.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void buttonAddClass_Click_1(object sender, EventArgs e)
        {
            string className = textBoxClass.Text.Trim();

            if (string.IsNullOrEmpty(className))
            {
                MessageBox.Show("Please enter a class name.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Class (ClassName) VALUES (@ClassName)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ClassName", className);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Class added successfully!");
                    textBoxClass.Clear();

                    NotifyClassChange();  // <== Add this line
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void buttonDeleteClass_Click_1(object sender, EventArgs e)
        {
            string className = textBoxClass.Text.Trim();

            if (string.IsNullOrEmpty(className))
            {
                MessageBox.Show("Please enter a class name to delete.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Step 1: Get ClassID
                    string getClassIdQuery = "SELECT TOP 1 ClassID FROM Class WHERE ClassName = @ClassName";
                    SqlCommand getClassIdCmd = new SqlCommand(getClassIdQuery, conn);
                    getClassIdCmd.Parameters.AddWithValue("@ClassName", className);
                    object result = getClassIdCmd.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show("Class not found.");
                        return;
                    }

                    int classID = Convert.ToInt32(result);

                    // Step 2: Check if assigned to students
                    string checkQuery = "SELECT COUNT(*) FROM Students WHERE ClassID = @ClassID";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@ClassID", classID);
                    int inUse = (int)checkCmd.ExecuteScalar();

                    if (inUse > 0)
                    {
                        MessageBox.Show("Cannot delete this class. It is assigned to students.");
                        return;
                    }

                    // Step 3: Delete
                    string deleteQuery = "DELETE FROM Class WHERE ClassID = @ClassID";
                    SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn);
                    deleteCmd.Parameters.AddWithValue("@ClassID", classID);

                    int rows = deleteCmd.ExecuteNonQuery();

                    MessageBox.Show(rows > 0 ? "Class deleted." : "Class not found.");
                    textBoxClass.Clear();
                    NotifyClassChange();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
