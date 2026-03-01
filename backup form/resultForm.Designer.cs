namespace backup_form
{
    partial class resultForm
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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            subject = new DataGridViewTextBoxColumn();
            totalmarks = new DataGridViewTextBoxColumn();
            obtainmarks = new DataGridViewTextBoxColumn();
            grade = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            label2 = new Label();
            remarkmsgTB = new TextBox();
            percentageTB = new Label();
            textBox1 = new TextBox();
            refreshBT = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(378, 26);
            label1.Name = "label1";
            label1.Size = new Size(196, 45);
            label1.TabIndex = 0;
            label1.Text = "Exam Result";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(30, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(929, 93);
            panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.GradientActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { subject, totalmarks, obtainmarks, grade, status });
            dataGridView1.Location = new Point(30, 167);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(929, 409);
            dataGridView1.TabIndex = 2;
            // 
            // subject
            // 
            subject.HeaderText = "Subject";
            subject.MinimumWidth = 8;
            subject.Name = "subject";
            subject.ReadOnly = true;
            // 
            // totalmarks
            // 
            totalmarks.HeaderText = "Total Marks";
            totalmarks.MinimumWidth = 8;
            totalmarks.Name = "totalmarks";
            totalmarks.ReadOnly = true;
            // 
            // obtainmarks
            // 
            obtainmarks.HeaderText = "Obtained Marks";
            obtainmarks.MinimumWidth = 8;
            obtainmarks.Name = "obtainmarks";
            obtainmarks.ReadOnly = true;
            // 
            // grade
            // 
            grade.HeaderText = "Grade";
            grade.MinimumWidth = 8;
            grade.Name = "grade";
            grade.ReadOnly = true;
            // 
            // status
            // 
            status.HeaderText = "Status";
            status.MinimumWidth = 8;
            status.Name = "status";
            status.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(30, 624);
            label2.Name = "label2";
            label2.Size = new Size(129, 38);
            label2.TabIndex = 3;
            label2.Text = "Remark: ";
            label2.Click += label2_Click;
            // 
            // remarkmsgTB
            // 
            remarkmsgTB.Location = new Point(165, 627);
            remarkmsgTB.Multiline = true;
            remarkmsgTB.Name = "remarkmsgTB";
            remarkmsgTB.Size = new Size(280, 37);
            remarkmsgTB.TabIndex = 4;
            // 
            // percentageTB
            // 
            percentageTB.AutoSize = true;
            percentageTB.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            percentageTB.ForeColor = SystemColors.HotTrack;
            percentageTB.Location = new Point(631, 621);
            percentageTB.Name = "percentageTB";
            percentageTB.Size = new Size(165, 38);
            percentageTB.TabIndex = 5;
            percentageTB.Text = "Percentage:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(819, 623);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 37);
            textBox1.TabIndex = 6;
            // 
            // refreshBT
            // 
            refreshBT.BackColor = SystemColors.HotTrack;
            refreshBT.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 192);
            refreshBT.FlatStyle = FlatStyle.Flat;
            refreshBT.ForeColor = SystemColors.HighlightText;
            refreshBT.Location = new Point(832, 687);
            refreshBT.Name = "refreshBT";
            refreshBT.Size = new Size(112, 34);
            refreshBT.TabIndex = 7;
            refreshBT.Text = "Refresh";
            refreshBT.UseVisualStyleBackColor = false;
            // 
            // resultForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(refreshBT);
            Controls.Add(textBox1);
            Controls.Add(percentageTB);
            Controls.Add(remarkmsgTB);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "resultForm";
            Size = new Size(984, 732);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn subject;
        private DataGridViewTextBoxColumn totalmarks;
        private DataGridViewTextBoxColumn obtainmarks;
        private DataGridViewTextBoxColumn grade;
        private DataGridViewTextBoxColumn status;
        private Label label2;
        private TextBox remarkmsgTB;
        private Label percentageTB;
        private TextBox textBox1;
        private Button refreshBT;
    }
}
