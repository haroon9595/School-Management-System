namespace backup_form
{
    partial class adminForm
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminForm));
            panel1 = new Panel();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            accedmicSubMenuPanel = new Panel();
            buttonReport = new Button();
            button20 = new Button();
            button19 = new Button();
            button12 = new Button();
            button11 = new Button();
            button23 = new Button();
            button18 = new Button();
            teacherSubMenuPanel = new Panel();
            button13 = new Button();
            button15 = new Button();
            button17 = new Button();
            button1 = new Button();
            stdSubMenuPanel = new Panel();
            button8 = new Button();
            button5 = new Button();
            button3 = new Button();
            button2 = new Button();
            panel3 = new Panel();
            label2 = new Label();
            menuTransition = new System.Windows.Forms.Timer(components);
            panel4 = new Panel();
            editTeacherRecord1 = new EditTeacherRecord();
            monthlyRep1 = new MonthlyRep();
            viewFeeRecord1 = new viewFeeRecord();
            assignFee1 = new AssignFee();
            viewTeacher1 = new viewTeacher();
            feeForm1 = new FeeForm();
            addClassSub1 = new addClassSub();
            subjectAssign2 = new subjectAssign();
            addTeacherForm1 = new addTeacherForm();
            addstd1 = new addstd();
            dashboardForm1 = new dashboardForm();
            subjectAssign1 = new subjectAssign();
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            accedmicSubMenuPanel.SuspendLayout();
            teacherSubMenuPanel.SuspendLayout();
            stdSubMenuPanel.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(guna2Panel1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(317, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1607, 77);
            panel1.TabIndex = 3;
            // 
            // guna2Panel1
            // 
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Location = new Point(1, 83);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(1005, 779);
            guna2Panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(631, 22);
            label1.Name = "label1";
            label1.Size = new Size(433, 45);
            label1.TabIndex = 0;
            label1.Text = "School Management System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(532, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.AutoScrollMinSize = new Size(0, 1500);
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Controls.Add(accedmicSubMenuPanel);
            panel2.Controls.Add(button18);
            panel2.Controls.Add(teacherSubMenuPanel);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(stdSubMenuPanel);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(317, 1050);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // accedmicSubMenuPanel
            // 
            accedmicSubMenuPanel.Controls.Add(buttonReport);
            accedmicSubMenuPanel.Controls.Add(button20);
            accedmicSubMenuPanel.Controls.Add(button19);
            accedmicSubMenuPanel.Controls.Add(button12);
            accedmicSubMenuPanel.Controls.Add(button11);
            accedmicSubMenuPanel.Controls.Add(button23);
            accedmicSubMenuPanel.Dock = DockStyle.Top;
            accedmicSubMenuPanel.Location = new Point(0, 658);
            accedmicSubMenuPanel.Name = "accedmicSubMenuPanel";
            accedmicSubMenuPanel.Size = new Size(291, 348);
            accedmicSubMenuPanel.TabIndex = 16;
            // 
            // buttonReport
            // 
            buttonReport.BackColor = SystemColors.MenuHighlight;
            buttonReport.Dock = DockStyle.Top;
            buttonReport.FlatAppearance.BorderColor = SystemColors.HotTrack;
            buttonReport.FlatAppearance.MouseDownBackColor = Color.Navy;
            buttonReport.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            buttonReport.ForeColor = SystemColors.ButtonHighlight;
            buttonReport.Image = (Image)resources.GetObject("buttonReport.Image");
            buttonReport.ImageAlign = ContentAlignment.MiddleLeft;
            buttonReport.Location = new Point(0, 281);
            buttonReport.Name = "buttonReport";
            buttonReport.Padding = new Padding(7);
            buttonReport.Size = new Size(291, 61);
            buttonReport.TabIndex = 17;
            buttonReport.Text = "  Report";
            buttonReport.UseVisualStyleBackColor = false;
            buttonReport.Click += buttonReport_Click;
            // 
            // button20
            // 
            button20.BackColor = SystemColors.MenuHighlight;
            button20.Dock = DockStyle.Top;
            button20.FlatAppearance.BorderColor = SystemColors.HotTrack;
            button20.FlatAppearance.MouseDownBackColor = Color.Navy;
            button20.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button20.ForeColor = SystemColors.ButtonHighlight;
            button20.Image = (Image)resources.GetObject("button20.Image");
            button20.ImageAlign = ContentAlignment.MiddleLeft;
            button20.Location = new Point(0, 220);
            button20.Name = "button20";
            button20.Padding = new Padding(7);
            button20.Size = new Size(291, 61);
            button20.TabIndex = 16;
            button20.Text = "  Assign Fee";
            button20.UseVisualStyleBackColor = false;
            button20.Click += button20_Click;
            // 
            // button19
            // 
            button19.BackColor = SystemColors.MenuHighlight;
            button19.Dock = DockStyle.Top;
            button19.FlatAppearance.BorderColor = SystemColors.HotTrack;
            button19.FlatAppearance.MouseDownBackColor = Color.Navy;
            button19.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button19.ForeColor = SystemColors.ButtonHighlight;
            button19.Image = (Image)resources.GetObject("button19.Image");
            button19.ImageAlign = ContentAlignment.MiddleLeft;
            button19.Location = new Point(0, 165);
            button19.Name = "button19";
            button19.Padding = new Padding(7);
            button19.Size = new Size(291, 55);
            button19.TabIndex = 15;
            button19.Text = "  Fee Record";
            button19.UseVisualStyleBackColor = false;
            button19.Click += button19_Click;
            // 
            // button12
            // 
            button12.BackColor = SystemColors.MenuHighlight;
            button12.Dock = DockStyle.Top;
            button12.FlatAppearance.BorderColor = SystemColors.HotTrack;
            button12.FlatAppearance.MouseDownBackColor = Color.Navy;
            button12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button12.ForeColor = SystemColors.ButtonHighlight;
            button12.Image = (Image)resources.GetObject("button12.Image");
            button12.ImageAlign = ContentAlignment.MiddleLeft;
            button12.Location = new Point(0, 110);
            button12.Name = "button12";
            button12.Padding = new Padding(7);
            button12.Size = new Size(291, 55);
            button12.TabIndex = 13;
            button12.Text = "   Student Fee";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button11
            // 
            button11.BackColor = SystemColors.MenuHighlight;
            button11.Dock = DockStyle.Top;
            button11.FlatAppearance.MouseDownBackColor = Color.Navy;
            button11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button11.ForeColor = SystemColors.ButtonHighlight;
            button11.Image = (Image)resources.GetObject("button11.Image");
            button11.ImageAlign = ContentAlignment.MiddleLeft;
            button11.Location = new Point(0, 55);
            button11.Name = "button11";
            button11.Padding = new Padding(7);
            button11.Size = new Size(291, 55);
            button11.TabIndex = 14;
            button11.Text = " Assignment";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button23
            // 
            button23.BackColor = SystemColors.MenuHighlight;
            button23.Dock = DockStyle.Top;
            button23.FlatAppearance.MouseDownBackColor = Color.Navy;
            button23.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button23.ForeColor = SystemColors.ButtonHighlight;
            button23.Image = (Image)resources.GetObject("button23.Image");
            button23.ImageAlign = ContentAlignment.MiddleLeft;
            button23.Location = new Point(0, 0);
            button23.Name = "button23";
            button23.Padding = new Padding(7);
            button23.Size = new Size(291, 55);
            button23.TabIndex = 9;
            button23.Text = "       Add Class / Subject";
            button23.UseVisualStyleBackColor = false;
            button23.Click += button23_Click;
            // 
            // button18
            // 
            button18.BackColor = SystemColors.HotTrack;
            button18.Dock = DockStyle.Top;
            button18.FlatAppearance.MouseDownBackColor = Color.Navy;
            button18.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button18.ForeColor = SystemColors.ButtonHighlight;
            button18.Image = (Image)resources.GetObject("button18.Image");
            button18.ImageAlign = ContentAlignment.MiddleLeft;
            button18.Location = new Point(0, 603);
            button18.Name = "button18";
            button18.Padding = new Padding(7);
            button18.Size = new Size(291, 55);
            button18.TabIndex = 15;
            button18.Text = "        Manage Accedmic";
            button18.UseVisualStyleBackColor = false;
            button18.Click += button18_Click_1;
            // 
            // teacherSubMenuPanel
            // 
            teacherSubMenuPanel.Controls.Add(button13);
            teacherSubMenuPanel.Controls.Add(button15);
            teacherSubMenuPanel.Controls.Add(button17);
            teacherSubMenuPanel.Dock = DockStyle.Top;
            teacherSubMenuPanel.Location = new Point(0, 436);
            teacherSubMenuPanel.Name = "teacherSubMenuPanel";
            teacherSubMenuPanel.Size = new Size(291, 167);
            teacherSubMenuPanel.TabIndex = 12;
            // 
            // button13
            // 
            button13.BackColor = SystemColors.MenuHighlight;
            button13.Dock = DockStyle.Top;
            button13.FlatAppearance.MouseDownBackColor = Color.Navy;
            button13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button13.ForeColor = SystemColors.ButtonHighlight;
            button13.Image = (Image)resources.GetObject("button13.Image");
            button13.ImageAlign = ContentAlignment.MiddleLeft;
            button13.Location = new Point(0, 110);
            button13.Name = "button13";
            button13.Padding = new Padding(7);
            button13.Size = new Size(291, 55);
            button13.TabIndex = 13;
            button13.Text = " View Teacher";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // button15
            // 
            button15.BackColor = SystemColors.MenuHighlight;
            button15.Dock = DockStyle.Top;
            button15.FlatAppearance.MouseDownBackColor = Color.Navy;
            button15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button15.ForeColor = SystemColors.ButtonHighlight;
            button15.Image = (Image)resources.GetObject("button15.Image");
            button15.ImageAlign = ContentAlignment.MiddleLeft;
            button15.Location = new Point(0, 55);
            button15.Name = "button15";
            button15.Padding = new Padding(7);
            button15.Size = new Size(291, 55);
            button15.TabIndex = 11;
            button15.Text = "   Delete Teacher";
            button15.UseVisualStyleBackColor = false;
            button15.Click += button15_Click;
            // 
            // button17
            // 
            button17.BackColor = SystemColors.MenuHighlight;
            button17.Dock = DockStyle.Top;
            button17.FlatAppearance.MouseDownBackColor = Color.Navy;
            button17.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button17.ForeColor = SystemColors.ButtonHighlight;
            button17.Image = (Image)resources.GetObject("button17.Image");
            button17.ImageAlign = ContentAlignment.MiddleLeft;
            button17.Location = new Point(0, 0);
            button17.Name = "button17";
            button17.Padding = new Padding(7);
            button17.Size = new Size(291, 55);
            button17.TabIndex = 9;
            button17.Text = " Add Teacher";
            button17.UseVisualStyleBackColor = false;
            button17.Click += button17_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderColor = SystemColors.HotTrack;
            button1.FlatAppearance.MouseDownBackColor = Color.Navy;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 381);
            button1.Name = "button1";
            button1.Padding = new Padding(7);
            button1.Size = new Size(291, 55);
            button1.TabIndex = 11;
            button1.Text = "    Manage Teacher";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // stdSubMenuPanel
            // 
            stdSubMenuPanel.Controls.Add(button8);
            stdSubMenuPanel.Controls.Add(button5);
            stdSubMenuPanel.Dock = DockStyle.Top;
            stdSubMenuPanel.Location = new Point(0, 269);
            stdSubMenuPanel.Name = "stdSubMenuPanel";
            stdSubMenuPanel.Size = new Size(291, 112);
            stdSubMenuPanel.TabIndex = 10;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.MenuHighlight;
            button8.Dock = DockStyle.Top;
            button8.FlatAppearance.MouseDownBackColor = Color.Navy;
            button8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button8.ForeColor = SystemColors.ButtonHighlight;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(0, 55);
            button8.Name = "button8";
            button8.Padding = new Padding(7);
            button8.Size = new Size(291, 55);
            button8.TabIndex = 12;
            button8.Text = "  View Student";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.MenuHighlight;
            button5.Dock = DockStyle.Top;
            button5.FlatAppearance.MouseDownBackColor = Color.Fuchsia;
            button5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(0, 0);
            button5.Name = "button5";
            button5.Padding = new Padding(7);
            button5.Size = new Size(291, 55);
            button5.TabIndex = 9;
            button5.Text = "  Add Student";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.HotTrack;
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderColor = SystemColors.HotTrack;
            button3.FlatAppearance.MouseDownBackColor = Color.Navy;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 214);
            button3.Name = "button3";
            button3.Padding = new Padding(7);
            button3.Size = new Size(291, 55);
            button3.TabIndex = 9;
            button3.Text = "    Manage Student";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_2;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HotTrack;
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderColor = SystemColors.HotTrack;
            button2.FlatAppearance.MouseDownBackColor = Color.Navy;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 159);
            button2.Name = "button2";
            button2.Padding = new Padding(7);
            button2.Size = new Size(291, 55);
            button2.TabIndex = 10;
            button2.Text = "    DashBoard";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_2;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(291, 159);
            panel3.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(70, 59);
            label2.Name = "label2";
            label2.Size = new Size(142, 51);
            label2.TabIndex = 0;
            label2.Text = "Admin";
            label2.Click += label2_Click_1;
            // 
            // menuTransition
            // 
            menuTransition.Interval = 10;
            // 
            // panel4
            // 
            panel4.Controls.Add(editTeacherRecord1);
            panel4.Controls.Add(monthlyRep1);
            panel4.Controls.Add(viewFeeRecord1);
            panel4.Controls.Add(assignFee1);
            panel4.Controls.Add(viewTeacher1);
            panel4.Controls.Add(feeForm1);
            panel4.Controls.Add(addClassSub1);
            panel4.Controls.Add(subjectAssign2);
            panel4.Controls.Add(addTeacherForm1);
            panel4.Controls.Add(addstd1);
            panel4.Controls.Add(dashboardForm1);
            panel4.Controls.Add(subjectAssign1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(317, 77);
            panel4.Name = "panel4";
            panel4.Size = new Size(1607, 973);
            panel4.TabIndex = 5;
            panel4.Paint += panel4_Paint;
            // 
            // editTeacherRecord1
            // 
            editTeacherRecord1.Location = new Point(0, 0);
            editTeacherRecord1.Name = "editTeacherRecord1";
            editTeacherRecord1.Size = new Size(2396, 1460);
            editTeacherRecord1.TabIndex = 27;
            editTeacherRecord1.Load += editTeacherRecord1_Load;
            // 
            // monthlyRep1
            // 
            monthlyRep1.Dock = DockStyle.Fill;
            monthlyRep1.Location = new Point(0, 0);
            monthlyRep1.Name = "monthlyRep1";
            monthlyRep1.Size = new Size(1607, 973);
            monthlyRep1.TabIndex = 26;
            // 
            // viewFeeRecord1
            // 
            viewFeeRecord1.Location = new Point(0, 0);
            viewFeeRecord1.Name = "viewFeeRecord1";
            viewFeeRecord1.Size = new Size(2396, 1460);
            viewFeeRecord1.TabIndex = 25;
            // 
            // assignFee1
            // 
            assignFee1.Location = new Point(0, 0);
            assignFee1.Name = "assignFee1";
            assignFee1.Size = new Size(2396, 1460);
            assignFee1.TabIndex = 24;
            assignFee1.Load += assignFee1_Load;
            // 
            // viewTeacher1
            // 
            viewTeacher1.Dock = DockStyle.Fill;
            viewTeacher1.Location = new Point(0, 0);
            viewTeacher1.Name = "viewTeacher1";
            viewTeacher1.Size = new Size(1607, 973);
            viewTeacher1.TabIndex = 23;
            // 
            // feeForm1
            // 
            feeForm1.Location = new Point(0, 0);
            feeForm1.Name = "feeForm1";
            feeForm1.Size = new Size(1476, 1098);
            feeForm1.TabIndex = 21;
            // 
            // addClassSub1
            // 
            addClassSub1.Location = new Point(0, 0);
            addClassSub1.Name = "addClassSub1";
            addClassSub1.Size = new Size(1476, 1098);
            addClassSub1.TabIndex = 20;
            // 
            // subjectAssign2
            // 
            subjectAssign2.Location = new Point(0, 0);
            subjectAssign2.Name = "subjectAssign2";
            subjectAssign2.Size = new Size(1476, 1098);
            subjectAssign2.TabIndex = 19;
            // 
            // addTeacherForm1
            // 
            addTeacherForm1.Location = new Point(0, 0);
            addTeacherForm1.Name = "addTeacherForm1";
            addTeacherForm1.Size = new Size(1476, 1098);
            addTeacherForm1.TabIndex = 18;
            // 
            // addstd1
            // 
            addstd1.Location = new Point(6, 9);
            addstd1.Name = "addstd1";
            addstd1.Size = new Size(1476, 1098);
            addstd1.TabIndex = 15;
            // 
            // dashboardForm1
            // 
            dashboardForm1.Location = new Point(0, 9);
            dashboardForm1.Name = "dashboardForm1";
            dashboardForm1.Size = new Size(1476, 1098);
            dashboardForm1.TabIndex = 17;
            // 
            // subjectAssign1
            // 
            subjectAssign1.Location = new Point(0, 0);
            subjectAssign1.Name = "subjectAssign1";
            subjectAssign1.Size = new Size(1643, 1174);
            subjectAssign1.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.HotTrack;
            button4.FlatAppearance.MouseDownBackColor = Color.Red;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button4.ForeColor = SystemColors.HotTrack;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(1486, 12);
            button4.Name = "button4";
            button4.Padding = new Padding(7);
            button4.Size = new Size(67, 54);
            button4.TabIndex = 18;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // adminForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1924, 1050);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "adminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            WindowState = FormWindowState.Maximized;
            Load += adminForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            accedmicSubMenuPanel.ResumeLayout(false);
            teacherSubMenuPanel.ResumeLayout(false);
            stdSubMenuPanel.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Timer menuTransition;
        private Panel stdSubMenuPanel;
        private Button button5;
        private Button button3;
        private Panel panel3;
        private Button button8;
        private Button button2;
        private Button button12;
        private Panel teacherSubMenuPanel;
        private Button button11;
        private Button button13;
        private Button button15;
        private Button button17;
        private Button button1;
        private Label label2;
        public Panel panel4;
        
        private Panel accedmicSubMenuPanel;
        private Button button23;
        private Button button18;
        private addstd addstd1;
        public dashboardForm dashboardForm1;
        private addClassSub addClassSub1;
        private subjectAssign subjectAssign2;
        private addTeacherForm addTeacherForm1;
        private subjectAssign subjectAssign1;
        private FeeForm feeForm1;
        public viewStudent viewStudent1;
        private viewTeacher viewTeacher1;
      
        private Button button19;
        private Button button20;
        private AssignFee assignFee1;
        private viewFeeRecord viewFeeRecord1;
        private Button buttonReport;
        private MonthlyRep monthlyRep1;
        private EditTeacherRecord editTeacherRecord1;
        private Button button4;
    }
}