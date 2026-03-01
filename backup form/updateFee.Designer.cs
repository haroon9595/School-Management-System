namespace backup_form
{
    partial class updateFee
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            label3 = new Label();
            payMethodComboBox = new ComboBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            buttonShowFeeHistory = new Button();
            buttonAddFee = new Button();
            textBoxRemainingFee = new TextBox();
            labelRemainingFee = new Label();
            comboBoxPaidStatus = new ComboBox();
            textBoxFeeAmount = new TextBox();
            labelFeeAmount = new Label();
            labelSubject = new Label();
            textBoxStudentID = new TextBox();
            labelStudentID = new Label();
            label1 = new Label();
            labelPaidStatus = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(691, 504);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(320, 31);
            textBox1.TabIndex = 46;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label3.Location = new Point(446, 672);
            label3.Name = "label3";
            label3.Size = new Size(99, 38);
            label3.TabIndex = 45;
            label3.Text = "Notes:";
            // 
            // payMethodComboBox
            // 
            payMethodComboBox.FormattingEnabled = true;
            payMethodComboBox.Items.AddRange(new object[] { "Paid", "Unpaid" });
            payMethodComboBox.Location = new Point(691, 561);
            payMethodComboBox.Name = "payMethodComboBox";
            payMethodComboBox.Size = new Size(320, 33);
            payMethodComboBox.TabIndex = 44;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label2.Location = new Point(446, 561);
            label2.Name = "label2";
            label2.Size = new Size(243, 38);
            label2.TabIndex = 43;
            label2.Text = "Payment Method:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(691, 384);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(320, 31);
            dateTimePicker1.TabIndex = 42;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(4, 87, 122);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(691, 759);
            button1.Name = "button1";
            button1.Size = new Size(180, 40);
            button1.TabIndex = 41;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            // 
            // buttonShowFeeHistory
            // 
            buttonShowFeeHistory.BackColor = Color.FromArgb(4, 87, 122);
            buttonShowFeeHistory.FlatStyle = FlatStyle.Flat;
            buttonShowFeeHistory.ForeColor = Color.White;
            buttonShowFeeHistory.Location = new Point(962, 759);
            buttonShowFeeHistory.Name = "buttonShowFeeHistory";
            buttonShowFeeHistory.Size = new Size(200, 40);
            buttonShowFeeHistory.TabIndex = 40;
            buttonShowFeeHistory.Text = "Show Fee History";
            buttonShowFeeHistory.UseVisualStyleBackColor = false;
            // 
            // buttonAddFee
            // 
            buttonAddFee.BackColor = Color.FromArgb(4, 87, 122);
            buttonAddFee.FlatStyle = FlatStyle.Flat;
            buttonAddFee.ForeColor = Color.White;
            buttonAddFee.Location = new Point(403, 759);
            buttonAddFee.Name = "buttonAddFee";
            buttonAddFee.Size = new Size(180, 40);
            buttonAddFee.TabIndex = 39;
            buttonAddFee.Text = "Add Fee";
            buttonAddFee.UseVisualStyleBackColor = false;
            // 
            // textBoxRemainingFee
            // 
            textBoxRemainingFee.Location = new Point(691, 672);
            textBoxRemainingFee.Name = "textBoxRemainingFee";
            textBoxRemainingFee.Size = new Size(320, 31);
            textBoxRemainingFee.TabIndex = 38;
            // 
            // labelRemainingFee
            // 
            labelRemainingFee.AutoSize = true;
            labelRemainingFee.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            labelRemainingFee.Location = new Point(445, 504);
            labelRemainingFee.Name = "labelRemainingFee";
            labelRemainingFee.Size = new Size(210, 38);
            labelRemainingFee.TabIndex = 37;
            labelRemainingFee.Text = "Remaining Fee:";
            // 
            // comboBoxPaidStatus
            // 
            comboBoxPaidStatus.FormattingEnabled = true;
            comboBoxPaidStatus.Items.AddRange(new object[] { "Paid", "Unpaid" });
            comboBoxPaidStatus.Location = new Point(691, 619);
            comboBoxPaidStatus.Name = "comboBoxPaidStatus";
            comboBoxPaidStatus.Size = new Size(320, 33);
            comboBoxPaidStatus.TabIndex = 36;
            // 
            // textBoxFeeAmount
            // 
            textBoxFeeAmount.Location = new Point(691, 442);
            textBoxFeeAmount.Name = "textBoxFeeAmount";
            textBoxFeeAmount.Size = new Size(320, 31);
            textBoxFeeAmount.TabIndex = 34;
            // 
            // labelFeeAmount
            // 
            labelFeeAmount.AutoSize = true;
            labelFeeAmount.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            labelFeeAmount.Location = new Point(445, 442);
            labelFeeAmount.Name = "labelFeeAmount";
            labelFeeAmount.Size = new Size(179, 38);
            labelFeeAmount.TabIndex = 33;
            labelFeeAmount.Text = "Fee Amount:";
            // 
            // labelSubject
            // 
            labelSubject.AutoSize = true;
            labelSubject.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            labelSubject.Location = new Point(446, 378);
            labelSubject.Name = "labelSubject";
            labelSubject.Size = new Size(158, 38);
            labelSubject.TabIndex = 32;
            labelSubject.Text = "Enter Date:";
            // 
            // textBoxStudentID
            // 
            textBoxStudentID.Location = new Point(691, 307);
            textBoxStudentID.Name = "textBoxStudentID";
            textBoxStudentID.Size = new Size(320, 31);
            textBoxStudentID.TabIndex = 31;
            // 
            // labelStudentID
            // 
            labelStudentID.AutoSize = true;
            labelStudentID.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            labelStudentID.Location = new Point(445, 307);
            labelStudentID.Name = "labelStudentID";
            labelStudentID.Size = new Size(178, 38);
            labelStudentID.TabIndex = 30;
            labelStudentID.Text = "Student Reg:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(333, 23);
            label1.Name = "label1";
            label1.Size = new Size(186, 45);
            label1.TabIndex = 0;
            label1.Text = "Update Fee";
            // 
            // labelPaidStatus
            // 
            labelPaidStatus.AutoSize = true;
            labelPaidStatus.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            labelPaidStatus.Location = new Point(445, 619);
            labelPaidStatus.Name = "labelPaidStatus";
            labelPaidStatus.Size = new Size(101, 38);
            labelPaidStatus.TabIndex = 35;
            labelPaidStatus.Text = "Status:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(383, 174);
            panel1.Name = "panel1";
            panel1.Size = new Size(831, 93);
            panel1.TabIndex = 29;
            // 
            // updateFee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(payMethodComboBox);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(buttonShowFeeHistory);
            Controls.Add(buttonAddFee);
            Controls.Add(textBoxRemainingFee);
            Controls.Add(labelRemainingFee);
            Controls.Add(comboBoxPaidStatus);
            Controls.Add(textBoxFeeAmount);
            Controls.Add(labelFeeAmount);
            Controls.Add(labelSubject);
            Controls.Add(textBoxStudentID);
            Controls.Add(labelStudentID);
            Controls.Add(labelPaidStatus);
            Controls.Add(panel1);
            Name = "updateFee";
            Size = new Size(1597, 973);
            Load += updateFee_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label3;
        private ComboBox payMethodComboBox;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button buttonShowFeeHistory;
        private Button buttonAddFee;
        private TextBox textBoxRemainingFee;
        private Label labelRemainingFee;
        private ComboBox comboBoxPaidStatus;
        private TextBox textBoxFeeAmount;
        private Label labelFeeAmount;
        private Label labelSubject;
        private TextBox textBoxStudentID;
        private Label labelStudentID;
        private Label label1;
        private Label labelPaidStatus;
        private Panel panel1;
    }
}
