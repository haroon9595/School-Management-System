using System.Data;
using System.Data.SqlClient;

namespace backup_form
{
    public partial class MonthlyRep : UserControl
    {
        string connectionString = "Data Source=PIRZADAHAROON\\SQLEXPRESS;Initial Catalog=schoolsysystem;Integrated Security=True;Encrypt=False";

        public MonthlyRep()
        {
            InitializeComponent();
            // Load report on startup
        }

        private void LoadReport(string condition)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = $@"
                SELECT 
                    c.ClassName,
                    s.Name AS StudentName,
                    f.Month,
                    f.TotalAmount,
                    f.PaidAmount,
                    f.CarryForward,
                    f.GrandTotal,
                    f.Status,
                    f.PaymentDate
                FROM Fee f
                JOIN Students s ON f.StudentID = s.StudentID
                JOIN Class c ON s.ClassID = c.ClassID
                WHERE 1=1 {condition}
                ORDER BY f.PaymentDate DESC;
            ";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    // Total Revenue
                    decimal totalRevenue = dt.AsEnumerable()
                        .Sum(row => row.Field<decimal>("PaidAmount"));

                    textBoxRenvue.Text = totalRevenue.ToString("0.00");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void btnMonthly_Click(object sender, EventArgs e)
        {
            string condition = "AND MONTH(f.PaymentDate) = MONTH(GETDATE()) AND YEAR(f.PaymentDate) = YEAR(GETDATE())";
            LoadReport(condition);
        }

        private void buttonWeekly_Click(object sender, EventArgs e)
        {
            string condition = "AND f.PaymentDate >= DATEADD(DAY, -7, GETDATE())";
            LoadReport(condition);
        }

        private void buttonTotally_Click(object sender, EventArgs e)
        {
            LoadReport(""); // No filter
        }


        private void textBoxRenvue_TextChanged(object sender, EventArgs e)
        {

        }

        private void MonthlyRep_Load(object sender, EventArgs e)
        {
            string condition = "AND MONTH(f.PaymentDate) = MONTH(GETDATE()) AND YEAR(f.PaymentDate) = YEAR(GETDATE())";
            LoadReport(condition); // Show current month's records
        }

    }
}
