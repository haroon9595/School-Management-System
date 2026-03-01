namespace backup_form
{
    partial class viewSubject
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
            panel1 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            courseid = new DataGridViewTextBoxColumn();
            course = new DataGridViewTextBoxColumn();
            teacher = new DataGridViewTextBoxColumn();
            refreshBT = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(334, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(929, 93);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(333, 26);
            label1.Name = "label1";
            label1.Size = new Size(261, 45);
            label1.TabIndex = 0;
            label1.Text = "Current Subjects";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.GradientActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { courseid, course, teacher });
            dataGridView1.Location = new Point(334, 282);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(929, 409);
            dataGridView1.TabIndex = 1;
            // 
            // courseid
            // 
            courseid.HeaderText = "Course ID";
            courseid.MinimumWidth = 8;
            courseid.Name = "courseid";
            courseid.ReadOnly = true;
            // 
            // course
            // 
            course.HeaderText = "Course Name";
            course.MinimumWidth = 8;
            course.Name = "course";
            course.ReadOnly = true;
            // 
            // teacher
            // 
            teacher.HeaderText = "Teacher Name";
            teacher.MinimumWidth = 8;
            teacher.Name = "teacher";
            teacher.ReadOnly = true;
            // 
            // refreshBT
            // 
            refreshBT.BackColor = SystemColors.HotTrack;
            refreshBT.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 192);
            refreshBT.FlatStyle = FlatStyle.Flat;
            refreshBT.ForeColor = SystemColors.HighlightText;
            refreshBT.Location = new Point(770, 721);
            refreshBT.Name = "refreshBT";
            refreshBT.Size = new Size(112, 34);
            refreshBT.TabIndex = 2;
            refreshBT.Text = "Refresh";
            refreshBT.UseVisualStyleBackColor = false;
            // 
            // viewSubject
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(refreshBT);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "viewSubject";
            Size = new Size(1597, 973);
            Load += viewSubject_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn courseid;
        private DataGridViewTextBoxColumn course;
        private DataGridViewTextBoxColumn teacher;
        private Button refreshBT;
    }
}
