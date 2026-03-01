using static Guna.UI2.WinForms.Suite.Descriptions;

namespace backup_form
{
    partial class viewTeacherRole
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
            comboBoxClassFilter = new ComboBox();
            labelSearchByCnic = new Label();
            labelSearchByClass = new Label();
            dataGridViewRoles = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoles).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(169, 149);
            panel1.Name = "panel1";
            panel1.Size = new Size(1258, 93);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(517, 26);
            label1.Name = "label1";
            label1.Size = new Size(297, 45);
            label1.TabIndex = 0;
            label1.Text = "View Teacher Roles";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(4, 87, 122);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(848, 351);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(171, 34);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(169, 351);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(307, 31);
            textBoxSearch.TabIndex = 3;
            // 
            // comboBoxClassFilter
            // 
            comboBoxClassFilter.FormattingEnabled = true;
            comboBoxClassFilter.Location = new Point(574, 349);
            comboBoxClassFilter.Name = "comboBoxClassFilter";
            comboBoxClassFilter.Size = new Size(216, 33);
            comboBoxClassFilter.TabIndex = 4;
            // 
            // labelSearchByCnic
            // 
            labelSearchByCnic.AutoSize = true;
            labelSearchByCnic.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelSearchByCnic.Location = new Point(169, 310);
            labelSearchByCnic.Name = "labelSearchByCnic";
            labelSearchByCnic.Size = new Size(110, 28);
            labelSearchByCnic.TabIndex = 5;
            labelSearchByCnic.Text = "Enter CNIC";
            // 
            // labelSearchByClass
            // 
            labelSearchByClass.AutoSize = true;
            labelSearchByClass.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelSearchByClass.Location = new Point(574, 310);
            labelSearchByClass.Name = "labelSearchByClass";
            labelSearchByClass.Size = new Size(151, 28);
            labelSearchByClass.TabIndex = 6;
            labelSearchByClass.Text = "Search by Class";
            // 
            // dataGridViewRoles
            // 
            dataGridViewRoles.AllowUserToAddRows = false;
            dataGridViewRoles.AllowUserToDeleteRows = false;
            dataGridViewRoles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewRoles.BackgroundColor = SystemColors.GradientActiveCaption;
            dataGridViewRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRoles.Location = new Point(169, 465);
            dataGridViewRoles.Name = "dataGridViewRoles";
            dataGridViewRoles.ReadOnly = true;
            dataGridViewRoles.RowHeadersWidth = 62;
            dataGridViewRoles.Size = new Size(1258, 471);
            dataGridViewRoles.TabIndex = 8;
            // 
            // viewTeacherRole
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridViewRoles);
            Controls.Add(labelSearchByClass);
            Controls.Add(labelSearchByCnic);
            Controls.Add(comboBoxClassFilter);
            Controls.Add(textBoxSearch);
            Controls.Add(btnSearch);
            Controls.Add(panel1);
            Name = "viewTeacherRole";
            Size = new Size(1597, 973);
            Load += viewTeacherRole_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ComboBox comboBoxClassFilter;
        private System.Windows.Forms.Label labelSearchByCnic;
        private System.Windows.Forms.Label labelSearchByClass;
        private System.Windows.Forms.DataGridView dataGridViewRoles;
    }
}