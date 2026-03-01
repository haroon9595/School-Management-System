using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace backup_form
{
    public partial class viewStudent : UserControl
    {
        string connectionString = @"Data Source=PIRZADAHAROON\SQLEXPRESS;Initial Catalog=schoolsysystem;Integrated Security=True;Encrypt=False";

        private adminForm _mainForm;

        public viewStudent(adminForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();

            // Hook events
            dataGridView1.CellMouseMove += dataGridView1_CellMouseMove;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            buttonRefresh.Click += buttonRefresh_Click;
            btnSearch.Click += btnSearch_Click;
            this.Load += viewStudent_Load;
        }

        private void viewStudent_Load(object sender, EventArgs e)
        {
            try
            {
                LoadAllStudents();
                LoadClasses();
                SetupGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading student data: " + ex.Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
            LoadAllStudents();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text.Trim();
            LoadAllStudents(searchText);
        }

        private void LoadAllStudents(string searchText = "")
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT s.StudentID, s.RollNumber, s.Name, s.FatherName, s.Contact, s.Email, 
                       s.Gender, s.DOB, s.Address, c.ClassName 
                FROM Students s
                LEFT JOIN Class c ON s.ClassID = c.ClassID
                WHERE 1=1";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                if (!string.IsNullOrEmpty(searchText))
                {
                    query += @"
                    AND ( 
                        s.RollNumber LIKE @search OR
                        s.Name LIKE @search OR
                        s.FatherName LIKE @search OR
                        s.Contact LIKE @search OR
                        s.Email LIKE @search OR
                        s.Address LIKE @search OR
                        c.ClassName LIKE @search
                    )";
                    cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");
                }

                cmd.CommandText = query;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
                SetColumnHeaders();

                // Show message only if user searched and no rows found
                if (!string.IsNullOrEmpty(searchText) && dt.Rows.Count == 0)
                {
                    MessageBox.Show("No records found matching your search.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void LoadClasses()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Class";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                // You can populate a class ComboBox here if needed, e.g. comboBoxClass.DataSource = dt;
            }
        }

        private void DeleteStudent(int studentID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Delete related Fee records first
                    string deleteFeeQuery = "DELETE FROM Fee WHERE StudentID = @id";
                    SqlCommand cmdFee = new SqlCommand(deleteFeeQuery, conn, transaction);
                    cmdFee.Parameters.AddWithValue("@id", studentID);
                    cmdFee.ExecuteNonQuery();

                    // Delete student record
                    string deleteStudentQuery = "DELETE FROM Students WHERE StudentID = @id";
                    SqlCommand cmdStudent = new SqlCommand(deleteStudentQuery, conn, transaction);
                    cmdStudent.Parameters.AddWithValue("@id", studentID);
                    cmdStudent.ExecuteNonQuery();

                    transaction.Commit();

                    MessageBox.Show("Student deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error deleting student: " + ex.Message, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            LoadAllStudents();
        }

        private void SetColumnHeaders()
        {
            if (dataGridView1.Columns.Count == 0) return;

            dataGridView1.Columns["StudentID"].HeaderText = "ID";
            dataGridView1.Columns["RollNumber"].HeaderText = "Roll No.";
            dataGridView1.Columns["Name"].HeaderText = "Student Name";
            dataGridView1.Columns["FatherName"].HeaderText = "Father's Name";
            dataGridView1.Columns["Contact"].HeaderText = "Contact No.";
            dataGridView1.Columns["Email"].HeaderText = "Email";
            dataGridView1.Columns["Gender"].HeaderText = "Gender";
            dataGridView1.Columns["DOB"].HeaderText = "Date of Birth";
            dataGridView1.Columns["Address"].HeaderText = "Home Address";
            dataGridView1.Columns["ClassName"].HeaderText = "Class";
        }

        private void SetupGrid()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = false;

            // Remove old Edit/Delete columns if any
            if (dataGridView1.Columns.Contains("Edit")) dataGridView1.Columns.Remove("Edit");
            if (dataGridView1.Columns.Contains("Delete")) dataGridView1.Columns.Remove("Delete");

            // Add Edit button column
            DataGridViewButtonColumn editCol = new DataGridViewButtonColumn
            {
                Name = "Edit",
                HeaderText = "Edit",
                Text = "🖉",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Add(editCol);

            // Add Delete button column
            DataGridViewButtonColumn deleteCol = new DataGridViewButtonColumn
            {
                Name = "Delete",
                HeaderText = "Delete",
                Text = "🗑️",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Add(deleteCol);
        }

        private void dataGridView1_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 &&
                (dataGridView1.Columns[e.ColumnIndex].Name == "Edit" ||
                 dataGridView1.Columns[e.ColumnIndex].Name == "Delete"))
            {
                dataGridView1.Cursor = Cursors.Hand;
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightGray;
            }
            else
            {
                dataGridView1.Cursor = Cursors.Default;
                ResetButtonCellStyles();
            }
        }

        private void ResetButtonCellStyles()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Edit"] is DataGridViewCell editCell)
                    editCell.Style.BackColor = Color.White;
                if (row.Cells["Delete"] is DataGridViewCell deleteCell)
                    deleteCell.Style.BackColor = Color.White;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            try
            {
                string columnName = dataGridView1.Columns[e.ColumnIndex].Name;

                object idValue = dataGridView1.Rows[e.RowIndex].Cells["StudentID"].Value;
                if (idValue == null || idValue == DBNull.Value)
                    return;

                int studentID = Convert.ToInt32(idValue);

                if (columnName == "Delete")
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        DeleteStudent(studentID);
                        LoadAllStudents();
                    }
                }
                else if (columnName == "Edit")
                {
                    updatestd updateControl = new updatestd(studentID);
                    updateControl.Dock = DockStyle.Fill;

                    if (_mainForm != null)
                    {
                        Panel adminPanel = _mainForm.Controls["panel4"] as Panel;
                        if (adminPanel != null)
                        {
                            foreach (Control ctrl in adminPanel.Controls)
                                ctrl.Visible = false;

                            adminPanel.Controls.Add(updateControl);
                            updateControl.Visible = true;
                        }
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                // Ignore index errors (usually after deleting a row)
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
