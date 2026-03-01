namespace backup_form
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            label3 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            AloginBT = new Button();
            showPassBT = new CheckBox();
            label4 = new Label();
            passwordTB = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            usernameTB = new Guna.UI2.WinForms.Guna2TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            panel1.Size = new Size(477, 691);
            panel1.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Info;
            label3.Location = new Point(46, 93);
            label3.Name = "label3";
            label3.Size = new Size(395, 32);
            label3.TabIndex = 2;
            label3.Text = "make sure your account is secure";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(133, 48);
            label1.Name = "label1";
            label1.Size = new Size(227, 45);
            label1.TabIndex = 1;
            label1.Text = "Teacher Login";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(63, 180);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(363, 447);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(483, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(44, 37);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 26;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // AloginBT
            // 
            AloginBT.BackColor = SystemColors.HotTrack;
            AloginBT.FlatStyle = FlatStyle.Popup;
            AloginBT.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AloginBT.ForeColor = SystemColors.ButtonHighlight;
            AloginBT.Location = new Point(728, 564);
            AloginBT.Name = "AloginBT";
            AloginBT.Size = new Size(260, 52);
            AloginBT.TabIndex = 25;
            AloginBT.Text = "login";
            AloginBT.UseVisualStyleBackColor = false;
            AloginBT.Click += AloginBT_Click;
            // 
            // showPassBT
            // 
            showPassBT.AutoSize = true;
            showPassBT.Location = new Point(973, 463);
            showPassBT.Name = "showPassBT";
            showPassBT.Size = new Size(162, 29);
            showPassBT.TabIndex = 24;
            showPassBT.Text = "Show Password";
            showPassBT.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(554, 374);
            label4.Name = "label4";
            label4.Size = new Size(115, 32);
            label4.TabIndex = 23;
            label4.Text = "Password";
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
            passwordTB.Location = new Point(554, 411);
            passwordTB.Margin = new Padding(4, 5, 4, 5);
            passwordTB.Name = "passwordTB";
            passwordTB.PasswordChar = '*';
            passwordTB.PlaceholderText = "";
            passwordTB.SelectedText = "";
            passwordTB.ShadowDecoration.CustomizableEdges = customizableEdges2;
            passwordTB.Size = new Size(581, 44);
            passwordTB.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(554, 247);
            label2.Name = "label2";
            label2.Size = new Size(124, 32);
            label2.TabIndex = 21;
            label2.Text = "Username";
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
            usernameTB.Location = new Point(554, 296);
            usernameTB.Margin = new Padding(4, 5, 4, 5);
            usernameTB.Name = "usernameTB";
            usernameTB.PlaceholderText = "";
            usernameTB.SelectedText = "";
            usernameTB.ShadowDecoration.CustomizableEdges = customizableEdges4;
            usernameTB.Size = new Size(581, 44);
            usernameTB.TabIndex = 20;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(728, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 175);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 691);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(AloginBT);
            Controls.Add(showPassBT);
            Controls.Add(label4);
            Controls.Add(passwordTB);
            Controls.Add(label2);
            Controls.Add(usernameTB);
            Controls.Add(pictureBox1);
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button AloginBT;
        private CheckBox showPassBT;
        private Label label4;
        private Guna.UI2.WinForms.Guna2TextBox passwordTB;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox usernameTB;
        private PictureBox pictureBox1;
    }
}