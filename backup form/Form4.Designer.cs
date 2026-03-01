namespace backup_form
{
    partial class Form4
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            timetable1 = new timetable();
            resultForm1 = new resultForm();
            viewSubject1 = new viewSubject();
            sprofileForm1 = new SprofileForm();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(timetable1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1333, 76);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(70, 20);
            label2.Name = "label2";
            label2.Size = new Size(143, 45);
            label2.TabIndex = 1;
            label2.Text = "Student ";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(484, 20);
            label1.Name = "label1";
            label1.Size = new Size(433, 45);
            label1.TabIndex = 0;
            label1.Text = "School Management System";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(270, 789);
            panel2.TabIndex = 1;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.HotTrack;
            button5.FlatAppearance.MouseDownBackColor = Color.Navy;
            button5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(0, 523);
            button5.Name = "button5";
            button5.Padding = new Padding(7);
            button5.Size = new Size(268, 70);
            button5.TabIndex = 5;
            button5.Text = "TimeTable";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.HotTrack;
            button4.FlatAppearance.MouseDownBackColor = Color.Navy;
            button4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 714);
            button4.Name = "button4";
            button4.Padding = new Padding(7);
            button4.Size = new Size(267, 70);
            button4.TabIndex = 4;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.HotTrack;
            button3.FlatAppearance.MouseDownBackColor = Color.Navy;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-1, 447);
            button3.Name = "button3";
            button3.Padding = new Padding(7);
            button3.Size = new Size(268, 70);
            button3.TabIndex = 3;
            button3.Text = "   Exam Result";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HotTrack;
            button2.FlatAppearance.MouseDownBackColor = Color.Navy;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 368);
            button2.Name = "button2";
            button2.Padding = new Padding(7);
            button2.Size = new Size(267, 70);
            button2.TabIndex = 2;
            button2.Text = "   View Subject";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.FlatAppearance.MouseDownBackColor = Color.Navy;
            button1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 291);
            button1.Name = "button1";
            button1.Padding = new Padding(7);
            button1.Size = new Size(267, 70);
            button1.TabIndex = 1;
            button1.Text = "Profile";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(38, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 168);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(resultForm1);
            panel3.Controls.Add(viewSubject1);
            panel3.Controls.Add(sprofileForm1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(270, 76);
            panel3.Name = "panel3";
            panel3.Size = new Size(1063, 789);
            panel3.TabIndex = 2;
            // 
            // timetable1
            // 
            timetable1.Location = new Point(318, -14);
            timetable1.Name = "timetable1";
            timetable1.Size = new Size(1594, 1184);
            timetable1.TabIndex = 3;
            timetable1.Load += timetable1_Load;
            // 
            // resultForm1
            // 
            resultForm1.Location = new Point(0, 0);
            resultForm1.Name = "resultForm1";
            resultForm1.Size = new Size(1594, 1184);
            resultForm1.TabIndex = 2;
            // 
            // viewSubject1
            // 
            viewSubject1.Location = new Point(0, 0);
            viewSubject1.Name = "viewSubject1";
            viewSubject1.Size = new Size(1594, 1184);
            viewSubject1.TabIndex = 1;
            // 
            // sprofileForm1
            // 
            sprofileForm1.Location = new Point(0, 0);
            sprofileForm1.Name = "sprofileForm1";
            sprofileForm1.Size = new Size(1594, 1184);
            sprofileForm1.TabIndex = 0;
            sprofileForm1.Load += sprofileForm1_Load;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1333, 865);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            Load += Form4_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private Panel panel3;
        private Button button5;
        private SprofileForm sprofileForm1;
        private resultForm resultForm1;
        private viewSubject viewSubject1;
        private timetable timetable1;
        private Label label2;
    }
}