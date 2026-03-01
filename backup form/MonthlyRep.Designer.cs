namespace backup_form
{
    partial class MonthlyRep
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
            labelSearchByName = new Label();
            textBoxRenvue = new TextBox();
            btnMonthly = new Button();
            buttonWeekly = new Button();
            buttonTotally = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(156, 127);
            panel1.Name = "panel1";
            panel1.Size = new Size(1248, 93);
            panel1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(565, 27);
            label1.Name = "label1";
            label1.Size = new Size(119, 45);
            label1.TabIndex = 0;
            label1.Text = "Report";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.GradientActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(156, 382);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1258, 471);
            dataGridView1.TabIndex = 26;
            // 
            // labelSearchByName
            // 
            labelSearchByName.AutoSize = true;
            labelSearchByName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelSearchByName.Location = new Point(156, 301);
            labelSearchByName.Name = "labelSearchByName";
            labelSearchByName.Size = new Size(128, 28);
            labelSearchByName.TabIndex = 29;
            labelSearchByName.Text = "Total Renvue";
            // 
            // textBoxRenvue
            // 
            textBoxRenvue.Location = new Point(156, 342);
            textBoxRenvue.Name = "textBoxRenvue";
            textBoxRenvue.Size = new Size(307, 31);
            textBoxRenvue.TabIndex = 28;
            textBoxRenvue.TextChanged += textBoxRenvue_TextChanged;
            // 
            // btnMonthly
            // 
            btnMonthly.BackColor = Color.FromArgb(4, 87, 122);
            btnMonthly.FlatStyle = FlatStyle.Flat;
            btnMonthly.ForeColor = Color.White;
            btnMonthly.Location = new Point(1233, 330);
            btnMonthly.Name = "btnMonthly";
            btnMonthly.Size = new Size(171, 34);
            btnMonthly.TabIndex = 30;
            btnMonthly.Text = "Monthly";
            btnMonthly.UseVisualStyleBackColor = false;
            btnMonthly.Click += btnMonthly_Click;
            // 
            // buttonWeekly
            // 
            buttonWeekly.BackColor = Color.FromArgb(4, 87, 122);
            buttonWeekly.FlatStyle = FlatStyle.Flat;
            buttonWeekly.ForeColor = Color.White;
            buttonWeekly.Location = new Point(1009, 330);
            buttonWeekly.Name = "buttonWeekly";
            buttonWeekly.Size = new Size(171, 34);
            buttonWeekly.TabIndex = 31;
            buttonWeekly.Text = "Weekly";
            buttonWeekly.UseVisualStyleBackColor = false;
            buttonWeekly.Click += buttonWeekly_Click;
            // 
            // buttonTotally
            // 
            buttonTotally.BackColor = Color.FromArgb(4, 87, 122);
            buttonTotally.FlatStyle = FlatStyle.Flat;
            buttonTotally.ForeColor = Color.White;
            buttonTotally.Location = new Point(786, 330);
            buttonTotally.Name = "buttonTotally";
            buttonTotally.Size = new Size(171, 34);
            buttonTotally.TabIndex = 32;
            buttonTotally.Text = "Totally";
            buttonTotally.UseVisualStyleBackColor = false;
            buttonTotally.Click += buttonTotally_Click;
            // 
            // MonthlyRep
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonTotally);
            Controls.Add(buttonWeekly);
            Controls.Add(btnMonthly);
            Controls.Add(labelSearchByName);
            Controls.Add(textBoxRenvue);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "MonthlyRep";
            Size = new Size(1597, 973);
            Load += MonthlyRep_Load;
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
        private Label labelSearchByName;
        private TextBox textBoxRenvue;
        private Button btnMonthly;
        private Button buttonWeekly;
        private Button buttonTotally;
    }
}
