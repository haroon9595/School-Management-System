namespace backup_form
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            label3 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            loginBT = new Button();
            showPassBT = new CheckBox();
            label4 = new Label();
            passwordTB = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            usernameTB = new Guna.UI2.WinForms.Guna2TextBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(477, 1050);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Info;
            label3.Location = new Point(48, 170);
            label3.Name = "label3";
            label3.Size = new Size(395, 32);
            label3.TabIndex = 2;
            label3.Text = "make sure your account is secure";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(107, 125);
            label1.Name = "label1";
            label1.Size = new Size(267, 45);
            label1.TabIndex = 1;
            label1.Text = "Welcome Admin";
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(66, 249);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(363, 530);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // loginBT
            // 
            loginBT.BackColor = SystemColors.HotTrack;
            loginBT.FlatStyle = FlatStyle.Popup;
            loginBT.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBT.ForeColor = SystemColors.ButtonHighlight;
            loginBT.Location = new Point(904, 623);
            loginBT.Name = "loginBT";
            loginBT.Size = new Size(260, 52);
            loginBT.TabIndex = 16;
            loginBT.Text = "login";
            loginBT.UseVisualStyleBackColor = false;
            loginBT.Click += loginBT_Click;
            // 
            // showPassBT
            // 
            showPassBT.AutoSize = true;
            showPassBT.Location = new Point(1147, 524);
            showPassBT.Name = "showPassBT";
            showPassBT.Size = new Size(162, 29);
            showPassBT.TabIndex = 15;
            showPassBT.Text = "Show Password";
            showPassBT.UseVisualStyleBackColor = true;
            showPassBT.CheckedChanged += showPassBT_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(728, 435);
            label4.Name = "label4";
            label4.Size = new Size(115, 32);
            label4.TabIndex = 14;
            label4.Text = "Password";
            label4.Click += label4_Click;
            // 
            // passwordTB
            // 
            passwordTB.CustomizableEdges = customizableEdges1;
            passwordTB.DefaultText = "";
            passwordTB.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            passwordTB.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            passwordTB.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            passwordTB.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            passwordTB.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            passwordTB.Font = new Font("Segoe UI", 9F);
            passwordTB.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            passwordTB.IconLeft = (Image)resources.GetObject("passwordTB.IconLeft");
            passwordTB.Location = new Point(728, 472);
            passwordTB.Margin = new Padding(4, 5, 4, 5);
            passwordTB.Name = "passwordTB";
            passwordTB.PasswordChar = '*';
            passwordTB.PlaceholderText = "";
            passwordTB.SelectedText = "";
            passwordTB.ShadowDecoration.CustomizableEdges = customizableEdges2;
            passwordTB.Size = new Size(581, 44);
            passwordTB.TabIndex = 13;
            passwordTB.TextChanged += passwordTB_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(728, 308);
            label2.Name = "label2";
            label2.Size = new Size(124, 32);
            label2.TabIndex = 12;
            label2.Text = "Username";
            label2.Click += label2_Click;
            // 
            // usernameTB
            // 
            usernameTB.CustomizableEdges = customizableEdges3;
            usernameTB.DefaultText = "";
            usernameTB.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            usernameTB.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            usernameTB.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            usernameTB.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            usernameTB.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            usernameTB.Font = new Font("Segoe UI", 9F);
            usernameTB.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            usernameTB.IconLeft = (Image)resources.GetObject("usernameTB.IconLeft");
            usernameTB.Location = new Point(728, 357);
            usernameTB.Margin = new Padding(4, 5, 4, 5);
            usernameTB.Name = "usernameTB";
            usernameTB.PlaceholderText = "";
            usernameTB.SelectedText = "";
            usernameTB.ShadowDecoration.CustomizableEdges = customizableEdges4;
            usernameTB.Size = new Size(581, 44);
            usernameTB.TabIndex = 11;
            usernameTB.TextChanged += usernameTB_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(929, 107);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 175);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(492, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(44, 37);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1050);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            Controls.Add(loginBT);
            Controls.Add(showPassBT);
            Controls.Add(label4);
            Controls.Add(passwordTB);
            Controls.Add(label2);
            Controls.Add(usernameTB);
            Controls.Add(pictureBox1);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label1;
        private PictureBox pictureBox2;
        private Button loginBT;
        private CheckBox showPassBT;
        private Label label4;
        private Guna.UI2.WinForms.Guna2TextBox passwordTB;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox usernameTB;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
    }
}