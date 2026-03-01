namespace backup_form
{
    partial class viewStudent
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
            btnSearch = new Button();
            textBoxSearch = new TextBox();
            labelSearchByName = new Label();
            dataGridView1 = new DataGridView();
            buttonRefresh = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(169, 114);
            panel1.Name = "panel1";
            panel1.Size = new Size(1258, 93);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(516, 26);
            label1.Name = "label1";
            label1.Size = new Size(227, 45);
            label1.TabIndex = 0;
            label1.Text = "View Students";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(4, 87, 122);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(535, 312);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(171, 34);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
           // btnSearch.Click += btnSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(169, 316);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(307, 31);
            textBoxSearch.TabIndex = 3;
            // 
            // labelSearchByName
            // 
            labelSearchByName.AutoSize = true;
            labelSearchByName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelSearchByName.Location = new Point(169, 275);
            labelSearchByName.Name = "labelSearchByName";
            labelSearchByName.Size = new Size(149, 28);
            labelSearchByName.TabIndex = 5;
            labelSearchByName.Text = "Search Student";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.GradientActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(169, 388);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1258, 471);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellMouseMove += dataGridView1_CellMouseMove;
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackColor = Color.FromArgb(4, 87, 122);
            buttonRefresh.FlatStyle = FlatStyle.Flat;
            buttonRefresh.ForeColor = Color.White;
            buttonRefresh.Location = new Point(1256, 880);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(171, 34);
            buttonRefresh.TabIndex = 8;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = false;
            // 
            // viewStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonRefresh);
            Controls.Add(dataGridView1);
            Controls.Add(labelSearchByName);
            Controls.Add(textBoxSearch);
            Controls.Add(btnSearch);
            Controls.Add(panel1);
            Name = "viewStudent";
            Size = new Size(1597, 973);
            Load += viewStudent_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnSearch;
        private TextBox textBoxSearch;
        private Label labelSearchByName;
        private DataGridView dataGridView1;
        private Button buttonRefresh;
    }
}
