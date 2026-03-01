namespace backup_form
{
    partial class EditStudentForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            labelRollNo = new Label();
            labelName = new Label();
            labelFather = new Label();
            labelContact = new Label();
            labelEmail = new Label();
            labelAddress = new Label();
            labelDOB = new Label();
            dateTimeDOB = new DateTimePicker();
            labelGender = new Label();
            comboBoxGender = new ComboBox();
            labelClass = new Label();
            comboBoxClass = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // labelRollNo
            // 
            labelRollNo.Location = new Point(62, 72);
            labelRollNo.Name = "labelRollNo";
            labelRollNo.Size = new Size(100, 23);
            labelRollNo.TabIndex = 1;
            // 
            // labelName
            // 
            labelName.Location = new Point(0, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(100, 23);
            labelName.TabIndex = 3;
            // 
            // labelFather
            // 
            labelFather.Location = new Point(0, 0);
            labelFather.Name = "labelFather";
            labelFather.Size = new Size(100, 23);
            labelFather.TabIndex = 5;
            // 
            // labelContact
            // 
            labelContact.Location = new Point(0, 0);
            labelContact.Name = "labelContact";
            labelContact.Size = new Size(100, 23);
            labelContact.TabIndex = 7;
            // 
            // labelEmail
            // 
            labelEmail.Location = new Point(0, 0);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(100, 23);
            labelEmail.TabIndex = 9;
            // 
            // labelAddress
            // 
            labelAddress.Location = new Point(0, 0);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(100, 23);
            labelAddress.TabIndex = 11;
            // 
            // labelDOB
            // 
            labelDOB.Location = new Point(50, 370);
            labelDOB.Name = "labelDOB";
            labelDOB.Size = new Size(100, 23);
            labelDOB.TabIndex = 13;
            labelDOB.Text = "Date of Birth:";
            // 
            // dateTimeDOB
            // 
            dateTimeDOB.Location = new Point(170, 370);
            dateTimeDOB.Name = "dateTimeDOB";
            dateTimeDOB.Size = new Size(250, 31);
            dateTimeDOB.TabIndex = 14;
            // 
            // labelGender
            // 
            labelGender.Location = new Point(50, 410);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(100, 23);
            labelGender.TabIndex = 15;
            labelGender.Text = "Gender:";
            // 
            // comboBoxGender
            // 
            comboBoxGender.Items.AddRange(new object[] { "Male", "Female" });
            comboBoxGender.Location = new Point(170, 410);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(250, 33);
            comboBoxGender.TabIndex = 16;
            // 
            // labelClass
            // 
            labelClass.Location = new Point(50, 450);
            labelClass.Name = "labelClass";
            labelClass.Size = new Size(100, 23);
            labelClass.TabIndex = 17;
            labelClass.Text = "Class:";
            // 
            // comboBoxClass
            // 
            comboBoxClass.Location = new Point(170, 450);
            comboBoxClass.Name = "comboBoxClass";
            comboBoxClass.Size = new Size(250, 33);
            comboBoxClass.TabIndex = 18;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(170, 500);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 35);
            btnSave.TabIndex = 19;
            btnSave.Text = "Save";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(320, 500);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 35);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "Cancel";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(68, 23);
            label1.Name = "label1";
            label1.Size = new Size(355, 65);
            label1.TabIndex = 21;
            label1.Text = "Update Record";
            label1.Click += label1_Click;
            // 
            // EditStudentForm
            // 
            ClientSize = new Size(480, 570);
            Controls.Add(label1);
            Controls.Add(labelRollNo);
            Controls.Add(labelName);
            Controls.Add(labelFather);
            Controls.Add(labelContact);
            Controls.Add(labelEmail);
            Controls.Add(labelAddress);
            Controls.Add(labelDOB);
            Controls.Add(dateTimeDOB);
            Controls.Add(labelGender);
            Controls.Add(comboBoxGender);
            Controls.Add(labelClass);
            Controls.Add(comboBoxClass);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "EditStudentForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit Student Record";
            ResumeLayout(false);
            PerformLayout();
        }

        // Helper to create label and textbox
        private void AddLabelAndTextBox(string labelText, out Label label, out TextBox textBox, int y)
        {
            label = new Label();
            label.Text = labelText;
            label.Location = new System.Drawing.Point(50, y);
            label.Size = new System.Drawing.Size(100, 23);

            textBox = new TextBox();
            textBox.Location = new System.Drawing.Point(170, y);
            textBox.Size = new System.Drawing.Size(250, 23);

            this.Controls.Add(label);
            this.Controls.Add(textBox);
        }

#endregion
        private System.Windows.Forms.Label labelRollNo, labelName, labelFather, labelContact, labelEmail, labelAddress, labelDOB, labelGender, labelClass;
        private System.Windows.Forms.DateTimePicker dateTimeDOB;
        private System.Windows.Forms.ComboBox comboBoxGender, comboBoxClass;
        private System.Windows.Forms.Button btnSave, btnCancel;
        private Label label1;
    }
}
