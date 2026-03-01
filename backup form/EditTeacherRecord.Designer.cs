namespace backup_form
{
    partial class EditTeacherRecord
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
            label5 = new Label();
            label1 = new Label();
            textBoxCnic = new TextBox();
            buttonClearFields = new Button();
            buttonDelete = new Button();
            textBoxAddress = new TextBox();
            label10 = new Label();
            label9 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBoxEmail = new TextBox();
            label8 = new Label();
            buttonImport = new Button();
            pictureBox1 = new PictureBox();
            comboBoxGender = new ComboBox();
            textBoxContact = new TextBox();
            label4 = new Label();
            textBoxFatherName = new TextBox();
            label3 = new Label();
            textBoxName = new TextBox();
            label2 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            buttonEnter = new Button();
            buttonUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(383, 297);
            label5.Name = "label5";
            label5.Size = new Size(178, 28);
            label5.TabIndex = 74;
            label5.Text = "Enter Teacher Cnic";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(289, 29);
            label1.Name = "label1";
            label1.Size = new Size(252, 45);
            label1.TabIndex = 0;
            label1.Text = "Update / Delete";
            // 
            // textBoxCnic
            // 
            textBoxCnic.Location = new Point(383, 328);
            textBoxCnic.Name = "textBoxCnic";
            textBoxCnic.Size = new Size(307, 31);
            textBoxCnic.TabIndex = 75;
            // 
            // buttonClearFields
            // 
            buttonClearFields.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonClearFields.BackColor = Color.FromArgb(4, 87, 122);
            buttonClearFields.FlatStyle = FlatStyle.Flat;
            buttonClearFields.ForeColor = Color.White;
            buttonClearFields.Location = new Point(1090, 905);
            buttonClearFields.Name = "buttonClearFields";
            buttonClearFields.Size = new Size(124, 34);
            buttonClearFields.TabIndex = 73;
            buttonClearFields.Text = "clear";
            buttonClearFields.UseVisualStyleBackColor = false;
            buttonClearFields.Click += buttonClearFields_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(4, 87, 122);
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(559, 905);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(124, 34);
            buttonDelete.TabIndex = 72;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(807, 672);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(432, 138);
            textBoxAddress.TabIndex = 71;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(811, 629);
            label10.Name = "label10";
            label10.Size = new Size(213, 28);
            label10.TabIndex = 70;
            label10.Text = "Enter Teacher Address";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(383, 766);
            label9.Name = "label9";
            label9.Size = new Size(181, 28);
            label9.TabIndex = 69;
            label9.Text = "Enter Teacher DOB";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(383, 807);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 68;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(383, 718);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(307, 31);
            textBoxEmail.TabIndex = 67;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(383, 687);
            label8.Name = "label8";
            label8.Size = new Size(188, 28);
            label8.TabIndex = 66;
            label8.Text = "Enter Teacher Email";
            // 
            // buttonImport
            // 
            buttonImport.BackColor = Color.FromArgb(4, 87, 122);
            buttonImport.FlatStyle = FlatStyle.Flat;
            buttonImport.ForeColor = Color.White;
            buttonImport.Location = new Point(1043, 493);
            buttonImport.Name = "buttonImport";
            buttonImport.Size = new Size(171, 34);
            buttonImport.TabIndex = 65;
            buttonImport.Text = "import";
            buttonImport.UseVisualStyleBackColor = false;
            buttonImport.Click += buttonImport_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDark;
            pictureBox1.Location = new Point(1043, 297);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 179);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 64;
            pictureBox1.TabStop = false;
            // 
            // comboBoxGender
            // 
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "Male", "Female" });
            comboBoxGender.Location = new Point(766, 328);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(209, 33);
            comboBoxGender.TabIndex = 63;
            // 
            // textBoxContact
            // 
            textBoxContact.Location = new Point(383, 639);
            textBoxContact.Name = "textBoxContact";
            textBoxContact.Size = new Size(307, 31);
            textBoxContact.TabIndex = 61;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(383, 608);
            label4.Name = "label4";
            label4.Size = new Size(209, 28);
            label4.TabIndex = 60;
            label4.Text = "Enter Teacher Contact";
            // 
            // textBoxFatherName
            // 
            textBoxFatherName.Location = new Point(383, 550);
            textBoxFatherName.Name = "textBoxFatherName";
            textBoxFatherName.Size = new Size(307, 31);
            textBoxFatherName.TabIndex = 59;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(383, 519);
            label3.Name = "label3";
            label3.Size = new Size(181, 28);
            label3.TabIndex = 58;
            label3.Text = "Enter Father Name";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(383, 458);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(307, 31);
            textBoxName.TabIndex = 57;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(383, 427);
            label2.Name = "label2";
            label2.Size = new Size(194, 28);
            label2.TabIndex = 56;
            label2.Text = "Enter Teacher Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(766, 297);
            label6.Name = "label6";
            label6.Size = new Size(207, 28);
            label6.TabIndex = 62;
            label6.Text = "Enter Teacher Gender";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(383, 152);
            panel2.Name = "panel2";
            panel2.Size = new Size(831, 93);
            panel2.TabIndex = 55;
            // 
            // buttonEnter
            // 
            buttonEnter.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonEnter.BackColor = Color.FromArgb(4, 87, 122);
            buttonEnter.FlatStyle = FlatStyle.Flat;
            buttonEnter.ForeColor = Color.White;
            buttonEnter.Location = new Point(566, 375);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(124, 34);
            buttonEnter.TabIndex = 76;
            buttonEnter.Text = "Enter";
            buttonEnter.UseVisualStyleBackColor = false;
            buttonEnter.Click += buttonEnter_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.FromArgb(4, 87, 122);
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.ForeColor = Color.White;
            buttonUpdate.Location = new Point(383, 905);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(124, 34);
            buttonUpdate.TabIndex = 77;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // EditTeacherRecord
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonUpdate);
            Controls.Add(buttonEnter);
            Controls.Add(label5);
            Controls.Add(textBoxCnic);
            Controls.Add(buttonClearFields);
            Controls.Add(buttonDelete);
            Controls.Add(textBoxAddress);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBoxEmail);
            Controls.Add(label8);
            Controls.Add(buttonImport);
            Controls.Add(pictureBox1);
            Controls.Add(comboBoxGender);
            Controls.Add(textBoxContact);
            Controls.Add(label4);
            Controls.Add(textBoxFatherName);
            Controls.Add(label3);
            Controls.Add(textBoxName);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(panel2);
            Name = "EditTeacherRecord";
            Size = new Size(1597, 973);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label1;
        private TextBox textBoxCnic;
        private Button buttonClearFields;
        private Button buttonDelete;
        private TextBox textBoxAddress;
        private Label label10;
        private Label label9;
        private DateTimePicker dateTimePicker1;
        private TextBox textBoxEmail;
        private Label label8;
        private Button buttonImport;
        private PictureBox pictureBox1;
        private ComboBox comboBoxGender;
        private TextBox textBoxContact;
        private Label label4;
        private TextBox textBoxFatherName;
        private Label label3;
        private TextBox textBoxName;
        private Label label2;
        private Label label6;
        private Panel panel2;
        private Button buttonEnter;
        private Button buttonUpdate;
    }
}
