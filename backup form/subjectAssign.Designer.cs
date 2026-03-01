namespace backup_form
{
    partial class subjectAssign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(subjectAssign));
            panel1 = new Panel();
            label1 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            assignBtn = new Button();
            dataGridView1 = new DataGridView();
            pictureBoxSearchBtn = new PictureBox();
            textBoxSearch = new TextBox();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearchBtn).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(370, 121);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 93);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(268, 27);
            label1.Name = "label1";
            label1.Size = new Size(299, 45);
            label1.TabIndex = 0;
            label1.Text = "Add Class / Subject";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(594, 301);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(245, 33);
            comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(594, 370);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(245, 33);
            comboBox2.TabIndex = 3;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(594, 442);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(245, 33);
            comboBox3.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(379, 302);
            label2.Name = "label2";
            label2.Size = new Size(170, 32);
            label2.TabIndex = 5;
            label2.Text = "Select Teacher";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(379, 371);
            label3.Name = "label3";
            label3.Size = new Size(166, 32);
            label3.TabIndex = 6;
            label3.Text = "Select Subject";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(379, 439);
            label4.Name = "label4";
            label4.Size = new Size(140, 32);
            label4.TabIndex = 7;
            label4.Text = "Select Class";
            // 
            // assignBtn
            // 
            assignBtn.BackColor = Color.FromArgb(4, 87, 122);
            assignBtn.FlatStyle = FlatStyle.Flat;
            assignBtn.ForeColor = Color.White;
            assignBtn.Location = new Point(370, 537);
            assignBtn.Name = "assignBtn";
            assignBtn.Size = new Size(200, 40);
            assignBtn.TabIndex = 9;
            assignBtn.Text = "Assign";
            assignBtn.UseVisualStyleBackColor = false;
            assignBtn.Click += assignBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(892, 305);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(460, 368);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pictureBoxSearchBtn
            // 
            pictureBoxSearchBtn.Image = (Image)resources.GetObject("pictureBoxSearchBtn.Image");
            pictureBoxSearchBtn.Location = new Point(1307, 255);
            pictureBoxSearchBtn.Name = "pictureBoxSearchBtn";
            pictureBoxSearchBtn.Size = new Size(43, 31);
            pictureBoxSearchBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxSearchBtn.TabIndex = 24;
            pictureBoxSearchBtn.TabStop = false;
            pictureBoxSearchBtn.Click += pictureBoxSearchBtn_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(1040, 255);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(245, 31);
            textBoxSearch.TabIndex = 23;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.FromArgb(4, 87, 122);
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.ForeColor = Color.White;
            buttonUpdate.Location = new Point(630, 537);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(200, 40);
            buttonUpdate.TabIndex = 22;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(4, 87, 122);
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(508, 621);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(200, 40);
            buttonDelete.TabIndex = 25;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // subjectAssign
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonDelete);
            Controls.Add(pictureBoxSearchBtn);
            Controls.Add(textBoxSearch);
            Controls.Add(buttonUpdate);
            Controls.Add(dataGridView1);
            Controls.Add(assignBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(panel1);
            Name = "subjectAssign";
            Size = new Size(1597, 973);
            Load += subjectAssign_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearchBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button assignBtn;
        private DataGridView dataGridView1;  // Declaring the DataGridView
        private PictureBox pictureBoxSearchBtn;
        private TextBox textBoxSearch;
        private Button buttonUpdate;
        private Button buttonDelete;
    }
}
