namespace backup_form
{
    partial class AssignFee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignFee));
            panel1 = new Panel();
            label1 = new Label();
            buttonAssignFee = new Button();
            label3 = new Label();
            label2 = new Label();
            comboBoxClass = new ComboBox();
            textBoxFeeAmount = new TextBox();
            buttonUpdateFee = new Button();
            dataGridViewFees = new DataGridView();
            textBoxSearch = new TextBox();
            pictureBoxSearchBtn = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFees).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearchBtn).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(352, 132);
            panel1.Name = "panel1";
            panel1.Size = new Size(831, 93);
            panel1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(328, 27);
            label1.Name = "label1";
            label1.Size = new Size(174, 45);
            label1.TabIndex = 0;
            label1.Text = "Assign Fee";
            // 
            // buttonAssignFee
            // 
            buttonAssignFee.BackColor = Color.FromArgb(4, 87, 122);
            buttonAssignFee.FlatStyle = FlatStyle.Flat;
            buttonAssignFee.ForeColor = Color.White;
            buttonAssignFee.Location = new Point(349, 489);
            buttonAssignFee.Name = "buttonAssignFee";
            buttonAssignFee.Size = new Size(200, 40);
            buttonAssignFee.TabIndex = 17;
            buttonAssignFee.Text = "Assign";
            buttonAssignFee.UseVisualStyleBackColor = false;
            buttonAssignFee.Click += buttonAssignFee_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(368, 387);
            label3.Name = "label3";
            label3.Size = new Size(116, 32);
            label3.TabIndex = 15;
            label3.Text = "Enter Fee";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(368, 318);
            label2.Name = "label2";
            label2.Size = new Size(140, 32);
            label2.TabIndex = 14;
            label2.Text = "Select Class";
            // 
            // comboBoxClass
            // 
            comboBoxClass.FormattingEnabled = true;
            comboBoxClass.Location = new Point(583, 317);
            comboBoxClass.Name = "comboBoxClass";
            comboBoxClass.Size = new Size(245, 33);
            comboBoxClass.TabIndex = 11;
            // 
            // textBoxFeeAmount
            // 
            textBoxFeeAmount.Location = new Point(583, 390);
            textBoxFeeAmount.Name = "textBoxFeeAmount";
            textBoxFeeAmount.Size = new Size(245, 31);
            textBoxFeeAmount.TabIndex = 9;
            // 
            // buttonUpdateFee
            // 
            buttonUpdateFee.BackColor = Color.FromArgb(4, 87, 122);
            buttonUpdateFee.FlatStyle = FlatStyle.Flat;
            buttonUpdateFee.ForeColor = Color.White;
            buttonUpdateFee.Location = new Point(648, 489);
            buttonUpdateFee.Name = "buttonUpdateFee";
            buttonUpdateFee.Size = new Size(200, 40);
            buttonUpdateFee.TabIndex = 18;
            buttonUpdateFee.Text = "Update";
            buttonUpdateFee.UseVisualStyleBackColor = false;
            buttonUpdateFee.Click += buttonUpdateFee_Click;
            // 
            // dataGridViewFees
            // 
            dataGridViewFees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFees.Location = new Point(885, 301);
            dataGridViewFees.Name = "dataGridViewFees";
            dataGridViewFees.RowHeadersWidth = 62;
            dataGridViewFees.Size = new Size(445, 307);
            dataGridViewFees.TabIndex = 19;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(1017, 264);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(245, 31);
            textBoxSearch.TabIndex = 20;
            // 
            // pictureBoxSearchBtn
            // 
            pictureBoxSearchBtn.Image = (Image)resources.GetObject("pictureBoxSearchBtn.Image");
            pictureBoxSearchBtn.Location = new Point(1284, 264);
            pictureBoxSearchBtn.Name = "pictureBoxSearchBtn";
            pictureBoxSearchBtn.Size = new Size(43, 31);
            pictureBoxSearchBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxSearchBtn.TabIndex = 21;
            pictureBoxSearchBtn.TabStop = false;
            pictureBoxSearchBtn.Click += pictureBoxSearchBtn_Click_1;
            // 
            // AssignFee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBoxSearchBtn);
            Controls.Add(textBoxSearch);
            Controls.Add(dataGridViewFees);
            Controls.Add(buttonUpdateFee);
            Controls.Add(textBoxFeeAmount);
            Controls.Add(panel1);
            Controls.Add(buttonAssignFee);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBoxClass);
            Name = "AssignFee";
            Size = new Size(1597, 973);
            Load += AssignFee_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFees).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearchBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button buttonAssignFee;
        private Label label3;
        private Label label2;
        private ComboBox comboBoxClass;
        private TextBox textBoxFeeAmount;
        private Button buttonUpdateFee;
        private DataGridView dataGridViewFees;
        private TextBox textBoxSearch;
        private PictureBox pictureBoxSearchBtn;
    }
}
