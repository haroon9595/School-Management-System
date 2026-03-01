using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace backup_form
{
    public partial class viewTeacher : UserControl
    {
        string connectionString = @"Data Source=PIRZADAHAROON\SQLEXPRESS;Initial Catalog=schoolsysystem;Integrated Security=True;Encrypt=False";

        public viewTeacher()
        {
            InitializeComponent();

        }

        private void viewTeacher_Load(object sender, EventArgs e)
        {
            //try
            //{

            LoadAllTeachers();
            SetupGrid();

            //}
            //catch (Exception ex)
            //{
            // MessageBox.Show("Error loading teacher data: " + ex.Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void LoadAllTeachers()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Modify the query to select the ImagePath as well
                string query = @"SELECT TeacherID, Name, FatherName, Gender, DOB, Contact, Email, Cnic, Address, ImagePath
                                 FROM Teachers";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                SetColumnHeaders();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }


        private void SetColumnHeaders()
        {
            dataGridView1.ClearSelection();
            if (dataGridView1.Columns.Count == 0) return;

            dataGridView1.Columns["TeacherID"].HeaderText = "ID";
            dataGridView1.Columns["Name"].HeaderText = "Name";
            dataGridView1.Columns["FatherName"].HeaderText = "Father's Name";
            dataGridView1.Columns["Gender"].HeaderText = "Gender";
            dataGridView1.Columns["DOB"].HeaderText = "Date of Birth";
            dataGridView1.Columns["Contact"].HeaderText = "Contact No.";
            dataGridView1.Columns["Email"].HeaderText = "Email";
            dataGridView1.Columns["Cnic"].HeaderText = "CNIC";
            dataGridView1.Columns["Address"].HeaderText = "Address";
            dataGridView1.Columns["ImagePath"].HeaderText = "Image Path";  // Add this line for ImagePath
        }

        private void SetupGrid()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LavenderBlush;

            // Adding a new Image column to display the images in the grid
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.HeaderText = "Image";
            imageColumn.Name = "Image";
            dataGridView1.Columns.Add(imageColumn);

            // Display images in the Image column
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string imagePath = row.Cells["ImagePath"].Value.ToString();
                if (System.IO.File.Exists(imagePath))  // Check if file exists
                {
                    row.Cells["Image"].Value = System.Drawing.Image.FromFile(imagePath);  // Set image from path
                }
                else
                {
                    row.Cells["Image"].Value = null;  // Set null if image path is invalid
                }
            }
        }
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            // Empty event handler
        }

        private void btnSearch_Click_2(object sender, EventArgs e)
        {
            
            string keyword = textBoxSearch.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT TeacherID, Name, FatherName, Gender, DOB, Contact, Email, Cnic, Address, ImagePath
                         FROM Teachers
                         WHERE 1=1";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                if (!string.IsNullOrEmpty(keyword))
                {
                    query += @" AND (
                        Name LIKE '%' + @keyword + '%'
                        OR FatherName LIKE '%' + @keyword + '%'
                        OR Contact LIKE '%' + @keyword + '%'
                        OR Email LIKE '%' + @keyword + '%'
                        OR Cnic LIKE '%' + @keyword + '%'
                        OR Address LIKE '%' + @keyword + '%'
                        OR Gender Like  '%' + @keyword + '%'
                        OR DOB Like  '%' + @keyword + '%'
                        OR ImagePath Like  '%' + @keyword + '%'
                       )";
                    cmd.Parameters.AddWithValue("@keyword", keyword);
                }

                cmd.CommandText = query;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                SetColumnHeaders();

                if (dt.Rows.Count == 0)
                    MessageBox.Show("No teacher found matching your search.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
