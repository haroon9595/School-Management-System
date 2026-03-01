using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace backup_form
{
    public partial class viewFeeRecord : UserControl
    {
        string connectionString = @"Data Source=PIRZADAHAROON\SQLEXPRESS;Initial Catalog=schoolsysystem;Integrated Security=True;Encrypt=False";

        public viewFeeRecord()
        {
            InitializeComponent();
        }

        private void viewFeeRecord_Load(object sender, EventArgs e)
        {
            LoadFeeRecords(); // Load all records when form loads
        }

        // Load fee records, filter by searchTerm if provided
        private void LoadFeeRecords(string searchTerm = "")
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            F.FeeID AS [Fee ID],
                            S.RollNumber AS [Roll Number],
                            S.Name AS [Student Name],
                            C.ClassName AS [Class],
                            F.Month AS [Month],
                            F.TotalAmount AS [Monthly Fee],
                            F.CarryForward AS [Previous Balance],
                            F.GrandTotal AS [Total Fee],
                            F.PaidAmount AS [Paid],
                            F.RemainingAmount AS [Remaining],
                            F.Status AS [Status],
                            F.PaymentMethod AS [Payment Method],
                            F.PaymentDate AS [Payment Date],
                            F.Notes AS [Notes]
                        FROM Fee F
                        INNER JOIN Students S ON F.StudentID = S.StudentID
                        INNER JOIN Class C ON S.ClassID = C.ClassID
                        WHERE 
                            (@search = '') -- If empty search, select all
                            OR S.Name LIKE @search
                            OR S.RollNumber LIKE @search
                            OR C.ClassName LIKE @search
                            OR F.Month LIKE @search
                        ORDER BY F.PaymentDate DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        string searchParam = string.IsNullOrWhiteSpace(searchTerm) ? "" : "%" + searchTerm + "%";
                        cmd.Parameters.AddWithValue("@search", searchParam);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = dt;
                            FormatGrid();
                        }
                        else
                        {
                            dataGridView1.DataSource = null;
                            // Optional: Show a label for no results instead of popup
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("⚠️ An error occurred while loading fee records:\n\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Format DataGridView columns and style
        private void FormatGrid()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView1.RowTemplate.Height = 25;
        }

        // Search button click
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = textBoxSearch.Text.Trim();
            LoadFeeRecords(search);
        }

        // Refresh button click
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
            LoadFeeRecords();
        }

        // Optional cell click event
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Implement if needed
        }
    }
}
