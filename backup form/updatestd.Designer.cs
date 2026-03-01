namespace backup_form
{
    partial class updatestd
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
            label1 = new Label();
            button3 = new Button();
            button2 = new Button();
            textBox6 = new TextBox();
            label10 = new Label();
            label9 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox5 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            comboBoxClass = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(297, 26);
            label1.Name = "label1";
            label1.Size = new Size(237, 45);
            label1.TabIndex = 0;
            label1.Text = "Update Record";
            // 
            // button3
            // 
            button3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button3.BackColor = Color.FromArgb(4, 87, 122);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(1043, 683);
            button3.Name = "button3";
            button3.Size = new Size(124, 34);
            button3.TabIndex = 76;
            button3.Text = "clear";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(4, 87, 122);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(886, 683);
            button2.Name = "button2";
            button2.Size = new Size(124, 34);
            button2.TabIndex = 75;
            button2.Text = "save";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(713, 447);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(432, 138);
            textBox6.TabIndex = 74;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(713, 409);
            label10.Name = "label10";
            label10.Size = new Size(138, 28);
            label10.TabIndex = 73;
            label10.Text = "Enter Address";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(336, 618);
            label9.Name = "label9";
            label9.Size = new Size(106, 28);
            label9.TabIndex = 72;
            label9.Text = "Enter DOB";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(336, 659);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 71;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(336, 570);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(307, 31);
            textBox5.TabIndex = 70;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(336, 539);
            label8.Name = "label8";
            label8.Size = new Size(113, 28);
            label8.TabIndex = 69;
            label8.Text = "Enter Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(719, 286);
            label7.Name = "label7";
            label7.Size = new Size(170, 28);
            label7.TabIndex = 68;
            label7.Text = "Enter Class Name";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(4, 87, 122);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(996, 390);
            button1.Name = "button1";
            button1.Size = new Size(171, 34);
            button1.TabIndex = 67;
            button1.Text = "import";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDark;
            pictureBox1.Location = new Point(996, 194);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 179);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 66;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(719, 225);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(209, 33);
            comboBox1.TabIndex = 65;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(336, 406);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(307, 31);
            textBox4.TabIndex = 63;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(336, 375);
            label5.Name = "label5";
            label5.Size = new Size(176, 28);
            label5.TabIndex = 62;
            label5.Text = "Enter Roll number";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(336, 491);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(307, 31);
            textBox3.TabIndex = 61;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(336, 460);
            label4.Name = "label4";
            label4.Size = new Size(134, 28);
            label4.TabIndex = 60;
            label4.Text = "Enter Contact";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(336, 317);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(307, 31);
            textBox2.TabIndex = 59;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(336, 286);
            label3.Name = "label3";
            label3.Size = new Size(181, 28);
            label3.TabIndex = 58;
            label3.Text = "Enter Father Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(336, 225);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(307, 31);
            textBox1.TabIndex = 57;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(336, 194);
            label2.Name = "label2";
            label2.Size = new Size(119, 28);
            label2.TabIndex = 56;
            label2.Text = "Enter Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(719, 194);
            label6.Name = "label6";
            label6.Size = new Size(132, 28);
            label6.TabIndex = 64;
            label6.Text = "Enter Gender";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(336, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(831, 93);
            panel2.TabIndex = 55;
            // 
            // comboBoxClass
            // 
            comboBoxClass.FormattingEnabled = true;
            comboBoxClass.Items.AddRange(new object[] { "Male", "Female" });
            comboBoxClass.Location = new Point(719, 317);
            comboBoxClass.Name = "comboBoxClass";
            comboBoxClass.Size = new Size(209, 33);
            comboBoxClass.TabIndex = 79;
            // 
            // updatestd
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBoxClass);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox6);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox5);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox1);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(panel2);
            Name = "updatestd";
            Size = new Size(1597, 973);
            Load += updatestd_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button3;
        private Button button2;
        private TextBox textBox6;
        private Label label10;
        private Label label9;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox5;
        private Label label8;
        private Label label7;
        private Button button1;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Label label6;
        private Panel panel2;
        private ComboBox comboBoxClass;
    }
}
