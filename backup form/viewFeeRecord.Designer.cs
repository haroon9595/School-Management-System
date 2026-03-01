namespace backup_form
{
    partial class viewFeeRecord
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
            buttonRefresh = new Button();
            labelSearchByName = new Label();
            textBoxSearch = new TextBox();
            btnSearch = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(169, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(1258, 93);
            panel1.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(539, 26);
            label1.Name = "label1";
            label1.Size = new Size(180, 45);
            label1.TabIndex = 0;
            label1.Text = "Fee Record";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.GradientActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(169, 360);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1258, 471);
            dataGridView1.TabIndex = 25;
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackColor = Color.FromArgb(4, 87, 122);
            buttonRefresh.FlatStyle = FlatStyle.Flat;
            buttonRefresh.ForeColor = Color.White;
            buttonRefresh.Location = new Point(1256, 852);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(171, 34);
            buttonRefresh.TabIndex = 26;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = false;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // labelSearchByName
            // 
            labelSearchByName.AutoSize = true;
            labelSearchByName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelSearchByName.Location = new Point(169, 247);
            labelSearchByName.Name = "labelSearchByName";
            labelSearchByName.Size = new Size(149, 28);
            labelSearchByName.TabIndex = 24;
            labelSearchByName.Text = "Search Student";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(169, 288);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(307, 31);
            textBoxSearch.TabIndex = 23;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(4, 87, 122);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(535, 284);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(171, 34);
            btnSearch.TabIndex = 22;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // viewFeeRecord
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(buttonRefresh);
            Controls.Add(labelSearchByName);
            Controls.Add(textBoxSearch);
            Controls.Add(btnSearch);
            Name = "viewFeeRecord";
            Size = new Size(1597, 973);
            Load += viewFeeRecord_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private Button buttonRefresh;
        private Label labelSearchByName;
        private TextBox textBoxSearch;
        private Button btnSearch;
    }
}
