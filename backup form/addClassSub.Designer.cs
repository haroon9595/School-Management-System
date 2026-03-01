namespace backup_form
{
    partial class addClassSub
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
            labelClass = new Label();
            textBoxClass = new TextBox();
            labelSubject = new Label();
            textBoxSubject = new TextBox();
            buttonAddClass = new Button();
            buttonAddSubject = new Button();
            buttonDeleteClass = new Button();
            buttonDeleteSubject = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(352, 138);
            panel1.Name = "panel1";
            panel1.Size = new Size(831, 93);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(266, 27);
            label1.Name = "label1";
            label1.Size = new Size(299, 45);
            label1.TabIndex = 0;
            label1.Text = "Add Class / Subject";
            // 
            // labelClass
            // 
            labelClass.AutoSize = true;
            labelClass.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            labelClass.Location = new Point(588, 315);
            labelClass.Name = "labelClass";
            labelClass.Size = new Size(95, 38);
            labelClass.TabIndex = 1;
            labelClass.Text = "Class :";
            // 
            // textBoxClass
            // 
            textBoxClass.Location = new Point(708, 321);
            textBoxClass.Name = "textBoxClass";
            textBoxClass.Size = new Size(320, 31);
            textBoxClass.TabIndex = 2;
            // 
            // labelSubject
            // 
            labelSubject.AutoSize = true;
            labelSubject.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            labelSubject.Location = new Point(568, 395);
            labelSubject.Name = "labelSubject";
            labelSubject.Size = new Size(125, 38);
            labelSubject.TabIndex = 3;
            labelSubject.Text = "Subject :";
            // 
            // textBoxSubject
            // 
            textBoxSubject.Location = new Point(708, 401);
            textBoxSubject.Name = "textBoxSubject";
            textBoxSubject.Size = new Size(320, 31);
            textBoxSubject.TabIndex = 4;
            // 
            // buttonAddClass
            // 
            buttonAddClass.BackColor = Color.FromArgb(4, 87, 122);
            buttonAddClass.FlatStyle = FlatStyle.Flat;
            buttonAddClass.ForeColor = Color.White;
            buttonAddClass.Location = new Point(413, 495);
            buttonAddClass.Name = "buttonAddClass";
            buttonAddClass.Size = new Size(180, 40);
            buttonAddClass.TabIndex = 5;
            buttonAddClass.Text = "Add Class";
            buttonAddClass.UseVisualStyleBackColor = false;
            buttonAddClass.Click += buttonAddClass_Click_1;
            // 
            // buttonAddSubject
            // 
            buttonAddSubject.BackColor = Color.FromArgb(4, 87, 122);
            buttonAddSubject.FlatStyle = FlatStyle.Flat;
            buttonAddSubject.ForeColor = Color.White;
            buttonAddSubject.Location = new Point(813, 495);
            buttonAddSubject.Name = "buttonAddSubject";
            buttonAddSubject.Size = new Size(180, 40);
            buttonAddSubject.TabIndex = 6;
            buttonAddSubject.Text = "Add Subject";
            buttonAddSubject.UseVisualStyleBackColor = false;
            buttonAddSubject.Click += buttonAddSubject_Click_1;
            // 
            // buttonDeleteClass
            // 
            buttonDeleteClass.BackColor = Color.FromArgb(4, 87, 122);
            buttonDeleteClass.FlatStyle = FlatStyle.Flat;
            buttonDeleteClass.ForeColor = Color.White;
            buttonDeleteClass.Location = new Point(603, 495);
            buttonDeleteClass.Name = "buttonDeleteClass";
            buttonDeleteClass.Size = new Size(180, 40);
            buttonDeleteClass.TabIndex = 7;
            buttonDeleteClass.Text = "Delete Class";
            buttonDeleteClass.UseVisualStyleBackColor = false;
            buttonDeleteClass.Click += buttonDeleteClass_Click_1;
            // 
            // buttonDeleteSubject
            // 
            buttonDeleteSubject.BackColor = Color.FromArgb(4, 87, 122);
            buttonDeleteSubject.FlatStyle = FlatStyle.Flat;
            buttonDeleteSubject.ForeColor = Color.White;
            buttonDeleteSubject.Location = new Point(1003, 495);
            buttonDeleteSubject.Name = "buttonDeleteSubject";
            buttonDeleteSubject.Size = new Size(180, 40);
            buttonDeleteSubject.TabIndex = 8;
            buttonDeleteSubject.Text = "Delete Subject";
            buttonDeleteSubject.UseVisualStyleBackColor = false;
            buttonDeleteSubject.Click += buttonDeleteSubject_Click_1;
            // 
            // addClassSub
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonDeleteSubject);
            Controls.Add(buttonDeleteClass);
            Controls.Add(buttonAddSubject);
            Controls.Add(buttonAddClass);
            Controls.Add(textBoxSubject);
            Controls.Add(labelSubject);
            Controls.Add(textBoxClass);
            Controls.Add(labelClass);
            Controls.Add(panel1);
            Name = "addClassSub";
            Size = new Size(1597, 973);
            Load += addClassSub_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label labelClass;
        private TextBox textBoxClass;
        private Label labelSubject;
        private TextBox textBoxSubject;
        private Button buttonAddClass;
        private Button buttonAddSubject;
        private Button buttonDeleteClass;
        private Button buttonDeleteSubject;
    }
}
