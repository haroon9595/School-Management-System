using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace backup_form
{
    public partial class subjectAssign : UserControl
    {
        private string connectionString = "Data Source=PIRZADAHAROON\\SQLEXPRESS;Initial Catalog=schoolsysystem;Integrated Security=True;Encrypt=False";

        public subjectAssign()
        {
            InitializeComponent();
            this.VisibleChanged += subjectAssign_VisibleChanged;

        }

        private void subjectAssign_Load(object sender, EventArgs e)
        {
            // Populate ComboBoxes with data
            PopulateTeachers();
            PopulateSubjects();
            PopulateClasses();

            // Populate DataGridView with Teacher Assignments
            PopulateTeacherAssignments();
        }
        private void subjectAssign_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                PopulateTeachers();
                PopulateSubjects();
                PopulateClasses();
            }
        }


        // Method to populate the Teachers comboBox
        private void PopulateTeachers()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT TeacherID, Name FROM Teachers"; // Fetching TeacherID and Name
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "Name"; // Display Teacher's Name
                comboBox1.ValueMember = "TeacherID"; // Use TeacherID as the Value
            }
        }

        // Method to populate the Subjects comboBox
        private void PopulateSubjects()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT SubjectID, SubjectName FROM Subjects"; // Fetching SubjectID and SubjectName
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                comboBox2.DataSource = dt;
                comboBox2.DisplayMember = "SubjectName"; // Display Subject Name
                comboBox2.ValueMember = "SubjectID"; // Use SubjectID as the Value
            }
        }

        // Method to populate the Classes comboBox
        private void PopulateClasses()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ClassID, ClassName FROM Class"; // Fetching ClassID and ClassName
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                comboBox3.DataSource = dt;
                comboBox3.DisplayMember = "ClassName"; // Display Class Name
                comboBox3.ValueMember = "ClassID"; // Use ClassID as the Value
            }
        }

        // Method to populate DataGridView with Teacher Assignments
        // Method to populate DataGridView with Teacher Assignments
        private void PopulateTeacherAssignments()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT 
                ta.AssignmentID,
                t.Name AS TeacherName,
                s.SubjectName,
                c.ClassName
            FROM 
                TeacherAssignments ta
                JOIN Teachers t ON ta.TeacherID = t.TeacherID
                JOIN Subjects s ON ta.SubjectID = s.SubjectID
                JOIN Class c ON ta.ClassID = c.ClassID";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                // Hide the AssignmentID column but keep it in the DataGridView
                if (dataGridView1.Columns.Contains("AssignmentID"))
                {
                    dataGridView1.Columns["AssignmentID"].Visible = false;
                }
            }
        }


        // Search Functionality: Search by Teacher Name, Subject Name, or Class Name
        private void pictureBoxSearchBtn_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text.Trim(); // Get the search text

            if (!string.IsNullOrEmpty(searchText))
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                        SELECT 
                            ta.AssignmentID,
                            t.Name AS TeacherName,
                            s.SubjectName,
                            c.ClassName
                        FROM 
                            TeacherAssignments ta
                            JOIN Teachers t ON ta.TeacherID = t.TeacherID
                            JOIN Subjects s ON ta.SubjectID = s.SubjectID
                            JOIN Class c ON ta.ClassID = c.ClassID
                        WHERE 
                            t.Name LIKE @SearchText 
                            OR s.SubjectName LIKE @SearchText 
                            OR c.ClassName LIKE @SearchText";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt; // Update the DataGridView with the filtered data
                }
            }
            else
            {
                // If search text is empty, load all assignments
                PopulateTeacherAssignments();
            }
        }

        // Method to handle the update functionality for Teacher Assignments
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int assignmentID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["AssignmentID"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                UPDATE TeacherAssignments
                SET TeacherID = @TeacherID, SubjectID = @SubjectID, ClassID = @ClassID
                WHERE AssignmentID = @AssignmentID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TeacherID", comboBox1.SelectedValue);
                    cmd.Parameters.AddWithValue("@SubjectID", comboBox2.SelectedValue);
                    cmd.Parameters.AddWithValue("@ClassID", comboBox3.SelectedValue);
                    cmd.Parameters.AddWithValue("@AssignmentID", assignmentID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                MessageBox.Show("Assignment updated successfully.");
                PopulateTeacherAssignments();
                PopulateTeachers();   // Reload comboboxes
                PopulateSubjects();
                PopulateClasses();
            }
            else
            {
                MessageBox.Show("Please select an assignment to update.");
            }
        }


        private void assignBtn_Click(object sender, EventArgs e)
        {
            // Ensure that a Teacher, Subject, and Class are selected
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1 || comboBox3.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Teacher, Subject, and Class.");
                return;
            }

            // Get the selected values from ComboBoxes
            int teacherID = Convert.ToInt32(comboBox1.SelectedValue);
            int subjectID = Convert.ToInt32(comboBox2.SelectedValue);
            int classID = Convert.ToInt32(comboBox3.SelectedValue);

            // Insert the new assignment into the TeacherAssignments table
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    string query = @"
                INSERT INTO TeacherAssignments (TeacherID, SubjectID, ClassID)
                VALUES (@TeacherID, @SubjectID, @ClassID)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TeacherID", teacherID);
                    cmd.Parameters.AddWithValue("@SubjectID", subjectID);
                    cmd.Parameters.AddWithValue("@ClassID", classID);

                    conn.Open();
                    cmd.ExecuteNonQuery();  // Execute the insert query
                    conn.Close();

                    MessageBox.Show("Teacher assigned successfully!");

                    // Optionally, refresh the DataGridView to show the new assignment
                    PopulateTeacherAssignments();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Confirm deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this assignment?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int assignmentID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["AssignmentID"].Value);

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();
                            string query = "DELETE FROM TeacherAssignments WHERE AssignmentID = @AssignmentID";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@AssignmentID", assignmentID);
                            int rowsAffected = cmd.ExecuteNonQuery();
                            conn.Close();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Assignment deleted successfully.");
                                PopulateTeacherAssignments(); // Refresh the DataGridView
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete assignment.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an assignment to delete.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                string teacherName = selectedRow.Cells["TeacherName"].Value.ToString();
                string subjectName = selectedRow.Cells["SubjectName"].Value.ToString();
                string className = selectedRow.Cells["ClassName"].Value.ToString();

                // Set selected value in Teacher ComboBox
                for (int i = 0; i < comboBox1.Items.Count; i++)
                {
                    DataRowView drv = comboBox1.Items[i] as DataRowView;
                    if (drv != null && drv["Name"].ToString() == teacherName)
                    {
                        comboBox1.SelectedIndex = i;
                        break;
                    }
                }

                // Set selected value in Subject ComboBox
                for (int i = 0; i < comboBox2.Items.Count; i++)
                {
                    DataRowView drv = comboBox2.Items[i] as DataRowView;
                    if (drv != null && drv["SubjectName"].ToString() == subjectName)
                    {
                        comboBox2.SelectedIndex = i;
                        break;
                    }
                }

                // Set selected value in Class ComboBox
                for (int i = 0; i < comboBox3.Items.Count; i++)
                {
                    DataRowView drv = comboBox3.Items[i] as DataRowView;
                    if (drv != null && drv["ClassName"].ToString() == className)
                    {
                        comboBox3.SelectedIndex = i;
                        break;
                    }
                }
            }
        }
    }
}
