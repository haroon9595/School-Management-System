// Inside your FeeForm.cs
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace backup_form
{
    public partial class FeeForm : UserControl
    {
        string connectionString = @"Data Source=PIRZADAHAROON\SQLEXPRESS;Initial Catalog=schoolsysystem;Integrated Security=True;Encrypt=False";

        public FeeForm()
        {
            InitializeComponent();
        }

        private void FeeForm_Load(object sender, EventArgs e)
        {
            buttonAddFee.Enabled = false;
            textBoxMonthYear.Text = dateTimePicker1.Value.ToString("MMMM yyyy");
        }


        private void EnterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string studentQuery = @"SELECT S.StudentID, S.ClassID, S.Name, C.ClassName 
                             FROM Students S
                             INNER JOIN Class C ON S.ClassID = C.ClassID
                             WHERE S.RollNumber = @RollNumber";

                    SqlCommand studentCmd = new SqlCommand(studentQuery, connection);
                    studentCmd.Parameters.AddWithValue("@RollNumber", textBoxStudentRoll.Text.Trim());

                    SqlDataReader reader = studentCmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string studentName = reader["Name"].ToString();
                        string className = reader["ClassName"].ToString();
                        int classId = Convert.ToInt32(reader["ClassID"]);
                        int studentId = Convert.ToInt32(reader["StudentID"]);

                        stdName.Text = studentName;
                        stdClass.Text = className;
                        reader.Close();

                        // Get Fee Amount for Class
                        string feeQuery = "SELECT FeeAmount FROM AssignedClassFees WHERE ClassID = @ClassID";
                        SqlCommand feeCmd = new SqlCommand(feeQuery, connection);
                        feeCmd.Parameters.AddWithValue("@ClassID", classId);

                        object feeAmountObj = feeCmd.ExecuteScalar();
                        decimal feeAmount = 0;
                        if (feeAmountObj != null)
                        {
                            feeAmount = Convert.ToDecimal(feeAmountObj);
                            textBoxFeeAmount.Text = feeAmount.ToString("F2");
                        }
                        else
                        {
                            textBoxFeeAmount.Text = "0.00";
                            MessageBox.Show("⚠️ Fee not assigned for this class.");
                        }

                        // Get Last CarryForward (Previous Balance)
                        decimal carryForward = 0;
                        string carryQuery = @"SELECT TOP 1 CarryForward FROM Fee 
                               WHERE StudentID = @StudentID ORDER BY PaymentDate DESC";
                        SqlCommand carryCmd = new SqlCommand(carryQuery, connection);
                        carryCmd.Parameters.AddWithValue("@StudentID", studentId);

                        object carryObj = carryCmd.ExecuteScalar();
                        if (carryObj != null)
                        {
                            carryForward = Convert.ToDecimal(carryObj);
                        }

                        // Show CarryForward and GrandTotal
                        txtBoxCarryForward.Text = carryForward.ToString("F2");
                        decimal grandTotal = feeAmount + carryForward;
                        textBoxGrandTotal.Text = grandTotal.ToString("F2");

                        // Get Paid Amount and calculate Remaining Amount
                        decimal paidAmount = string.IsNullOrEmpty(textBoxPaidAmount.Text) ? 0 : Convert.ToDecimal(textBoxPaidAmount.Text);
                        decimal remainingAmount = grandTotal - paidAmount;

                        // Check for overpayment (remainingAmount should not be negative)
                        if (remainingAmount < 0)
                        {
                            MessageBox.Show("❌ Overpayment is not allowed. Please ensure the paid amount does not exceed the grand total.");
                            return; // Exit the method
                        }

                        // Update Status Based on Remaining Amount
                        if (remainingAmount == 0)
                        {
                            textBoxStatus.Text = "Paid";
                            labelFeeStatus.Text = "Paid";
                            labelFeeStatus.ForeColor = Color.Green;
                        }
                        else if (remainingAmount > 0)
                        {
                            textBoxStatus.Text = "Unpaid";
                            labelFeeStatus.Text = "Unpaid";
                            labelFeeStatus.ForeColor = Color.Red;
                        }

                        // Optional: also clear previous fields
                        textBoxMonthYear.Clear();

                        buttonAddFee.Enabled = true;
                    }
                    else
                    {
                        reader.Close();
                        stdName.Clear();
                        stdClass.Clear();
                        textBoxFeeAmount.Clear();
                        txtBoxCarryForward.Clear();
                        textBoxGrandTotal.Clear();
                        labelFeeStatus.Text = "";
                        buttonAddFee.Enabled = false;
                        MessageBox.Show("❌ Student not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("⚠️ Error: " + ex.Message);
            }
        }


        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if inputs are empty
                if (string.IsNullOrWhiteSpace(textBoxFeeAmount.Text) || string.IsNullOrWhiteSpace(textBoxPaidAmount.Text))
                {
                    MessageBox.Show("⚠️ Please enter both Fee Amount and Paid Amount first.");
                    return;
                }

                decimal totalFee = Convert.ToDecimal(textBoxFeeAmount.Text);
                decimal paidAmount = Convert.ToDecimal(textBoxPaidAmount.Text);

                decimal previousCarryForward = 0;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string getStudentQuery = "SELECT StudentID FROM Students WHERE RollNumber = @RollNumber";
                    SqlCommand getStudentCmd = new SqlCommand(getStudentQuery, connection);
                    getStudentCmd.Parameters.AddWithValue("@RollNumber", textBoxStudentRoll.Text.Trim());
                    object studentIdObj = getStudentCmd.ExecuteScalar();

                    if (studentIdObj != null)
                    {
                        int studentID = Convert.ToInt32(studentIdObj);

                        string carryQuery = @"SELECT TOP 1 CarryForward FROM Fee WHERE StudentID = @StudentID ORDER BY PaymentDate DESC";
                        SqlCommand carryCmd = new SqlCommand(carryQuery, connection);
                        carryCmd.Parameters.AddWithValue("@StudentID", studentID);

                        object carryObj = carryCmd.ExecuteScalar();
                        if (carryObj != null)
                            previousCarryForward = Convert.ToDecimal(carryObj);
                    }
                }

                decimal grandTotal = totalFee + previousCarryForward;

                // Validation: Paid amount should not exceed grand total
                if (paidAmount > grandTotal)
                {
                    MessageBox.Show("❌ Paid amount cannot be greater than Total Fee + Carry Forward.");
                    return;
                }

                decimal remaining = grandTotal - paidAmount;

                // Show values
                textBoxGrandTotal.Text = grandTotal.ToString("F2");
                textBoxRemainingAmount.Text = remaining.ToString("F2");
                txtBoxCarryForward.Text = previousCarryForward.ToString("F2");

                string status = remaining == 0 ? "Paid" : "Unpaid";
                textBoxStatus.Text = status;

                // Ensure MonthYear is updated using DateTimePicker
                textBoxMonthYear.Text = dateTimePicker1.Value.ToString("MMMM yyyy");

                // Colored label
                labelFeeStatus.Text = status;
                labelFeeStatus.ForeColor = (status == "Paid") ? Color.Green : Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show("⚠️ Error during calculation: " + ex.Message);
            }
        }


        private void buttonAddFee_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Basic validation: required fields
                if (string.IsNullOrWhiteSpace(textBoxStudentRoll.Text))
                {
                    MessageBox.Show("⚠️ Please enter the student's Roll Number.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(textBoxMonthYear.Text))
                {
                    MessageBox.Show("⚠️ Please enter the Month and Year.");
                    return;
                }
                if (!decimal.TryParse(textBoxFeeAmount.Text, out decimal totalAmount) || totalAmount <= 0)
                {
                    MessageBox.Show("⚠️ Please enter a valid positive Fee Amount.");
                    return;
                }
                if (!decimal.TryParse(textBoxPaidAmount.Text, out decimal paidAmount) || paidAmount < 0)
                {
                    MessageBox.Show("⚠️ Please enter a valid Paid Amount (zero or positive).");
                    return;
                }
                if (!decimal.TryParse(textBoxRemainingAmount.Text, out decimal carryForward) || carryForward < 0)
                {
                    MessageBox.Show("⚠️ Please enter a valid Remaining Amount (zero or positive).");
                    return;
                }
                if (payMethodComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("⚠️ Please select a Payment Method.");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Get Student ID using RollNumber
                    string getStudentQuery = "SELECT StudentID FROM Students WHERE RollNumber = @RollNumber";
                    using SqlCommand getStudentCmd = new SqlCommand(getStudentQuery, connection);
                    getStudentCmd.Parameters.AddWithValue("@RollNumber", textBoxStudentRoll.Text.Trim());

                    object studentIdObj = getStudentCmd.ExecuteScalar();
                    if (studentIdObj == null)
                    {
                        MessageBox.Show("❌ Student not found. Please check the Roll Number.");
                        return;
                    }

                    int studentID = Convert.ToInt32(studentIdObj);

                    // Check if fee record exists for student and month
                    string checkStatusQuery = @"SELECT Status FROM Fee WHERE StudentID = @StudentID AND Month = @Month";
                    using SqlCommand checkStatusCmd = new SqlCommand(checkStatusQuery, connection);
                    checkStatusCmd.Parameters.AddWithValue("@StudentID", studentID);
                    checkStatusCmd.Parameters.AddWithValue("@Month", textBoxMonthYear.Text.Trim());

                    object statusObj = checkStatusCmd.ExecuteScalar();

                    if (statusObj != null)
                    {
                        string status = statusObj.ToString();

                        if (status == "Paid")
                        {
                            MessageBox.Show("❌ This student's fee has already been fully paid for this month.");
                            return;
                        }
                        else if (status == "Unpaid")
                        {
                            MessageBox.Show("😊 This student has an unpaid fee record for this month.");
                            // You may want to consider updating existing record instead of inserting duplicate,
                            // but as per your current logic, you allow insertion.
                        }
                    }

                    // Insert new fee record (Status is computed by DB, do NOT insert or update it manually)
                    string insertQuery = @"
                INSERT INTO Fee
                (StudentID, Month, TotalAmount, PaidAmount, CarryForward, PaymentDate, PaymentMethod, Notes)
                VALUES
                (@StudentID, @Month, @TotalAmount, @PaidAmount, @CarryForward, @PaymentDate, @PaymentMethod, @Notes)";

                    using SqlCommand insertCmd = new SqlCommand(insertQuery, connection);
                    insertCmd.Parameters.AddWithValue("@StudentID", studentID);
                    insertCmd.Parameters.AddWithValue("@Month", textBoxMonthYear.Text.Trim());
                    insertCmd.Parameters.AddWithValue("@TotalAmount", totalAmount);
                    insertCmd.Parameters.AddWithValue("@PaidAmount", paidAmount);
                    insertCmd.Parameters.AddWithValue("@CarryForward", carryForward);
                    insertCmd.Parameters.AddWithValue("@PaymentDate", dateTimePicker1.Value);
                    insertCmd.Parameters.AddWithValue("@PaymentMethod", payMethodComboBox.SelectedItem.ToString());
                    insertCmd.Parameters.AddWithValue("@Notes", string.IsNullOrWhiteSpace(textBoxNotes.Text) ? DBNull.Value : (object)textBoxNotes.Text.Trim());

                    int rowsAffected = insertCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("✅ Fee record added successfully! Thank you for your submission.");
                    }
                    else
                    {
                        MessageBox.Show("⚠️ Unable to add fee record. Please try again.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("⚠️ An error occurred: " + ex.Message);
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            // Clear input fields
            textBoxStudentRoll.Clear();
            stdName.Clear();
            stdClass.Clear();
            textBoxFeeAmount.Clear();
            textBoxPaidAmount.Clear();
            textBoxRemainingAmount.Clear();
            textBoxGrandTotal.Clear();
            textBoxStatus.Clear();
            textBoxMonthYear.Clear();
            textBoxNotes.Clear(); // Notes
            payMethodComboBox.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;

            // Reset status label
            labelFeeStatus.Text = "";
            labelFeeStatus.ForeColor = System.Drawing.Color.Black;

            // Disable Add Fee button until student is selected again
            buttonAddFee.Enabled = false;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBoxMonthYear.Text = dateTimePicker1.Value.ToString("MMMM yyyy");
        }


        private void labelFeeAmount_Click(object sender, EventArgs e)
        {
            //eventhandler
        }

        private void textBoxGrandTotal_TextChanged(object sender, EventArgs e)
        {
            //eventhandler
        }
    }
}
