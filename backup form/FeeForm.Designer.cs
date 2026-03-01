namespace backup_form
{
    partial class FeeForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            buttonAddFee = new Button();
            labelStudentID = new Label();
            textBoxStudentRoll = new TextBox();
            labelFeeAmount = new Label();
            textBoxFeeAmount = new TextBox();
            labelPaidStatus = new Label();
            labelRemainingFee = new Label();
            textBoxNotes = new TextBox();
            button1 = new Button();
            labelSubject = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            payMethodComboBox = new ComboBox();
            label3 = new Label();
            textBoxRemainingAmount = new TextBox();
            stdName = new TextBox();
            lablestdName = new Label();
            stdClass = new TextBox();
            labelStdClass = new Label();
            EnterBtn = new Button();
            textBoxPaidAmount = new TextBox();
            label4 = new Label();
            textBoxGrandTotal = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBoxMonthYear = new TextBox();
            textBoxStatus = new TextBox();
            labelFeeStatus = new Label();
            buttonCalculate = new Button();
            txtBoxCarryForward = new TextBox();
            label7 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(141, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(1261, 93);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(569, 24);
            label1.Name = "label1";
            label1.Size = new Size(154, 45);
            label1.TabIndex = 0;
            label1.Text = "Fee Form";
            // 
            // buttonAddFee
            // 
            buttonAddFee.BackColor = Color.FromArgb(4, 87, 122);
            buttonAddFee.FlatStyle = FlatStyle.Flat;
            buttonAddFee.ForeColor = Color.White;
            buttonAddFee.Location = new Point(556, 875);
            buttonAddFee.Name = "buttonAddFee";
            buttonAddFee.Size = new Size(180, 40);
            buttonAddFee.TabIndex = 13;
            buttonAddFee.Text = "Add Fee";
            buttonAddFee.UseVisualStyleBackColor = false;
            buttonAddFee.Click += buttonAddFee_Click_1;
            // 
            // labelStudentID
            // 
            labelStudentID.AutoSize = true;
            labelStudentID.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            labelStudentID.Location = new Point(141, 257);
            labelStudentID.Name = "labelStudentID";
            labelStudentID.Size = new Size(178, 38);
            labelStudentID.TabIndex = 1;
            labelStudentID.Text = "Student Reg:";
            // 
            // textBoxStudentRoll
            // 
            textBoxStudentRoll.Location = new Point(387, 257);
            textBoxStudentRoll.Name = "textBoxStudentRoll";
            textBoxStudentRoll.Size = new Size(320, 31);
            textBoxStudentRoll.TabIndex = 2;
            // 
            // labelFeeAmount
            // 
            labelFeeAmount.AutoSize = true;
            labelFeeAmount.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            labelFeeAmount.Location = new Point(141, 502);
            labelFeeAmount.Name = "labelFeeAmount";
            labelFeeAmount.Size = new Size(139, 38);
            labelFeeAmount.TabIndex = 7;
            labelFeeAmount.Text = "Class Fee:";
            labelFeeAmount.Click += labelFeeAmount_Click;
            // 
            // textBoxFeeAmount
            // 
            textBoxFeeAmount.Location = new Point(387, 502);
            textBoxFeeAmount.Name = "textBoxFeeAmount";
            textBoxFeeAmount.Size = new Size(320, 31);
            textBoxFeeAmount.TabIndex = 8;
            // 
            // labelPaidStatus
            // 
            labelPaidStatus.AutoSize = true;
            labelPaidStatus.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            labelPaidStatus.Location = new Point(141, 715);
            labelPaidStatus.Name = "labelPaidStatus";
            labelPaidStatus.Size = new Size(101, 38);
            labelPaidStatus.TabIndex = 9;
            labelPaidStatus.Text = "Status:";
            // 
            // labelRemainingFee
            // 
            labelRemainingFee.AutoSize = true;
            labelRemainingFee.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            labelRemainingFee.Location = new Point(141, 662);
            labelRemainingFee.Name = "labelRemainingFee";
            labelRemainingFee.Size = new Size(269, 38);
            labelRemainingFee.TabIndex = 11;
            labelRemainingFee.Text = "Remaining Amount:";
            // 
            // textBoxNotes
            // 
            textBoxNotes.Location = new Point(1055, 670);
            textBoxNotes.Multiline = true;
            textBoxNotes.Name = "textBoxNotes";
            textBoxNotes.Size = new Size(401, 159);
            textBoxNotes.TabIndex = 12;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(4, 87, 122);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(889, 872);
            button1.Name = "button1";
            button1.Size = new Size(180, 40);
            button1.TabIndex = 15;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // labelSubject
            // 
            labelSubject.AutoSize = true;
            labelSubject.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            labelSubject.Location = new Point(828, 488);
            labelSubject.Name = "labelSubject";
            labelSubject.Size = new Size(202, 38);
            labelSubject.TabIndex = 5;
            labelSubject.Text = "Payment Date:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(1100, 494);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(320, 31);
            dateTimePicker1.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label2.Location = new Point(830, 433);
            label2.Name = "label2";
            label2.Size = new Size(243, 38);
            label2.TabIndex = 24;
            label2.Text = "Payment Method:";
            // 
            // payMethodComboBox
            // 
            payMethodComboBox.FormattingEnabled = true;
            payMethodComboBox.Items.AddRange(new object[] { "Cash", "Online" });
            payMethodComboBox.Location = new Point(1099, 433);
            payMethodComboBox.Name = "payMethodComboBox";
            payMethodComboBox.Size = new Size(320, 33);
            payMethodComboBox.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label3.Location = new Point(921, 670);
            label3.Name = "label3";
            label3.Size = new Size(99, 38);
            label3.TabIndex = 27;
            label3.Text = "Notes:";
            // 
            // textBoxRemainingAmount
            // 
            textBoxRemainingAmount.Location = new Point(411, 662);
            textBoxRemainingAmount.Name = "textBoxRemainingAmount";
            textBoxRemainingAmount.Size = new Size(296, 31);
            textBoxRemainingAmount.TabIndex = 28;
            // 
            // stdName
            // 
            stdName.Location = new Point(387, 387);
            stdName.Name = "stdName";
            stdName.Size = new Size(320, 31);
            stdName.TabIndex = 30;
            // 
            // lablestdName
            // 
            lablestdName.AutoSize = true;
            lablestdName.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lablestdName.Location = new Point(141, 387);
            lablestdName.Name = "lablestdName";
            lablestdName.Size = new Size(100, 38);
            lablestdName.TabIndex = 29;
            lablestdName.Text = "Name:";
            // 
            // stdClass
            // 
            stdClass.Location = new Point(387, 448);
            stdClass.Name = "stdClass";
            stdClass.Size = new Size(320, 31);
            stdClass.TabIndex = 32;
            // 
            // labelStdClass
            // 
            labelStdClass.AutoSize = true;
            labelStdClass.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            labelStdClass.Location = new Point(141, 448);
            labelStdClass.Name = "labelStdClass";
            labelStdClass.Size = new Size(87, 38);
            labelStdClass.TabIndex = 31;
            labelStdClass.Text = "Class:";
            // 
            // EnterBtn
            // 
            EnterBtn.BackColor = Color.FromArgb(4, 87, 122);
            EnterBtn.FlatStyle = FlatStyle.Flat;
            EnterBtn.ForeColor = Color.White;
            EnterBtn.Location = new Point(527, 312);
            EnterBtn.Name = "EnterBtn";
            EnterBtn.Size = new Size(180, 40);
            EnterBtn.TabIndex = 33;
            EnterBtn.Text = "Enter";
            EnterBtn.UseVisualStyleBackColor = false;
            EnterBtn.Click += EnterBtn_Click;
            // 
            // textBoxPaidAmount
            // 
            textBoxPaidAmount.Location = new Point(1099, 374);
            textBoxPaidAmount.Name = "textBoxPaidAmount";
            textBoxPaidAmount.Size = new Size(320, 31);
            textBoxPaidAmount.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label4.Location = new Point(829, 374);
            label4.Name = "label4";
            label4.Size = new Size(189, 38);
            label4.TabIndex = 34;
            label4.Text = "Paid Amount:";
            // 
            // textBoxGrandTotal
            // 
            textBoxGrandTotal.Location = new Point(1099, 321);
            textBoxGrandTotal.Name = "textBoxGrandTotal";
            textBoxGrandTotal.Size = new Size(320, 31);
            textBoxGrandTotal.TabIndex = 37;
            textBoxGrandTotal.TextChanged += textBoxGrandTotal_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label5.Location = new Point(827, 321);
            label5.Name = "label5";
            label5.Size = new Size(171, 38);
            label5.TabIndex = 36;
            label5.Text = "Grand Total:";
            //label5.Click += this.label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label6.Location = new Point(141, 603);
            label6.Name = "label6";
            label6.Size = new Size(109, 38);
            label6.TabIndex = 38;
            label6.Text = "Month:";
            // 
            // textBoxMonthYear
            // 
            textBoxMonthYear.Location = new Point(413, 610);
            textBoxMonthYear.Name = "textBoxMonthYear";
            textBoxMonthYear.Size = new Size(292, 31);
            textBoxMonthYear.TabIndex = 39;
            // 
            // textBoxStatus
            // 
            textBoxStatus.Location = new Point(411, 715);
            textBoxStatus.Name = "textBoxStatus";
            textBoxStatus.Size = new Size(296, 31);
            textBoxStatus.TabIndex = 40;
            // 
            // labelFeeStatus
            // 
            labelFeeStatus.AutoSize = true;
            labelFeeStatus.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            labelFeeStatus.Location = new Point(635, 550);
            labelFeeStatus.Name = "labelFeeStatus";
            labelFeeStatus.Size = new Size(0, 38);
            labelFeeStatus.TabIndex = 41;
            // 
            // buttonCalculate
            // 
            buttonCalculate.BackColor = Color.FromArgb(4, 87, 122);
            buttonCalculate.FlatStyle = FlatStyle.Flat;
            buttonCalculate.ForeColor = Color.White;
            buttonCalculate.Location = new Point(1188, 587);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(180, 40);
            buttonCalculate.TabIndex = 42;
            buttonCalculate.Text = "Calculate";
            buttonCalculate.UseVisualStyleBackColor = false;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // txtBoxCarryForward
            // 
            txtBoxCarryForward.Location = new Point(1099, 267);
            txtBoxCarryForward.Name = "txtBoxCarryForward";
            txtBoxCarryForward.Size = new Size(320, 31);
            txtBoxCarryForward.TabIndex = 44;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label7.Location = new Point(827, 267);
            label7.Name = "label7";
            label7.Size = new Size(242, 38);
            label7.TabIndex = 43;
            label7.Text = "Previous Amount:";
            // 
            // FeeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtBoxCarryForward);
            Controls.Add(label7);
            Controls.Add(buttonCalculate);
            Controls.Add(labelFeeStatus);
            Controls.Add(textBoxStatus);
            Controls.Add(textBoxMonthYear);
            Controls.Add(label6);
            Controls.Add(textBoxGrandTotal);
            Controls.Add(label5);
            Controls.Add(textBoxPaidAmount);
            Controls.Add(label4);
            Controls.Add(EnterBtn);
            Controls.Add(stdClass);
            Controls.Add(labelStdClass);
            Controls.Add(stdName);
            Controls.Add(lablestdName);
            Controls.Add(textBoxRemainingAmount);
            Controls.Add(label3);
            Controls.Add(payMethodComboBox);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(buttonAddFee);
            Controls.Add(textBoxNotes);
            Controls.Add(labelRemainingFee);
            Controls.Add(labelPaidStatus);
            Controls.Add(textBoxFeeAmount);
            Controls.Add(labelFeeAmount);
            Controls.Add(labelSubject);
            Controls.Add(textBoxStudentRoll);
            Controls.Add(labelStudentID);
            Controls.Add(panel1);
            Name = "FeeForm";
            Size = new Size(1597, 973);
            Load += FeeForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label labelStudentID;
        private TextBox textBoxStudentRoll;
        private Label labelFeeAmount;
        private TextBox textBoxFeeAmount;
        private Label labelPaidStatus;
        private Label labelRemainingFee;
        private TextBox textBoxNotes;
        private Button buttonAddFee;
        private Button button1;
        private Label labelSubject;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private ComboBox payMethodComboBox;
        private Label label3;
        private TextBox textBoxRemainingAmount;
        private TextBox stdName;
        private Label lablestdName;
        private TextBox stdClass;
        private Label labelStdClass;
        private Button EnterBtn;
        private TextBox textBoxPaidAmount;
        private Label label4;
        private TextBox textBoxGrandTotal;
        private Label label5;
        private Label label6;
        private TextBox textBoxMonthYear;
        private TextBox textBoxStatus;
        private Label labelFeeStatus;
        private Button buttonCalculate;
        private TextBox txtBoxCarryForward;
        private Label label7;
    }
}
