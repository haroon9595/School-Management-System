using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using backup_form;

namespace backup_form
{
    public partial class adminForm : Form
    {
        public adminForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            viewStudent1 = new viewStudent(this); // or new viewStudent(); if it doesn't take a parameter
            viewStudent1.Dock = DockStyle.Fill;
            panel4.Controls.Add(viewStudent1);

            CustomizeDesign();
        }


        public void adminForm_Load(object sender, EventArgs e)
        {
            // Optional: Set default visible control
            ShowUserControl(dashboardForm1);
        }

        private void CustomizeDesign()
        {
            stdSubMenuPanel.Visible = false;
            teacherSubMenuPanel.Visible = false;
            accedmicSubMenuPanel.Visible = false;
        }

        private void hideSubMenu()
        {
            stdSubMenuPanel.Visible = false;
            teacherSubMenuPanel.Visible = false;
            accedmicSubMenuPanel.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        // Use this method to show one user control and hide others
        public void ShowUserControl(UserControl controlToShow)
        {
            // Hide all
            addstd1.Visible = false;
            subjectAssign2.Visible = false;
            addClassSub1.Visible = false;
            dashboardForm1.Visible = false;
            addTeacherForm1.Visible = false;
            feeForm1.Visible = false;
            viewStudent1.Visible = false;
            assignFee1.Visible = false;
            viewFeeRecord1.Visible = false;
            monthlyRep1.Visible = false;
            editTeacherRecord1.Visible = false;






            // Show only selected
            controlToShow.Visible = true;
            controlToShow.BringToFront();

            // Hide menu
            hideSubMenu();
        }


        // STUDENT MENU BUTTON
        private void button3_Click_2(object sender, EventArgs e)
        {
            showSubMenu(stdSubMenuPanel);
        }

        // ADD STUDENT
        private void button5_Click(object sender, EventArgs e)
        {
            ShowUserControl(addstd1);
        }

        // VIEW STUDENT
        private void button8_Click(object sender, EventArgs e)
        {
            // Create an instance of the viewStudent UserControl and pass the current form (adminForm) to it
            //viewStudent studentView = new viewStudent(this);  // 'this' refers to the adminForm instance

            //studentView.Dock = DockStyle.Fill;  // Make sure it fills the container panel

            //// Find the panel where you want to display the UserControl (panel4)
            //panel4.Controls.Clear();  // Clear any existing controls in the container (panel4)
            //panel4.Controls.Add(studentView);  // Add the viewStudent UserControl to panel4
            ShowUserControl(viewStudent1);
        }



        // TEACHER MENU BUTTON
        private void button1_Click_1(object sender, EventArgs e)
        {
            showSubMenu(teacherSubMenuPanel);
        }

        // ADD TEACHER
        private void button17_Click(object sender, EventArgs e)
        {
            ShowUserControl(addTeacherForm1);
        }


        // ACADEMIC MENU BUTTON
        private void button18_Click_1(object sender, EventArgs e)
        {
            showSubMenu(accedmicSubMenuPanel);
        }

        // ASSIGN SUBJECTS
        private void button11_Click(object sender, EventArgs e)
        {
            ShowUserControl(subjectAssign2);
        }


        // CLASS & SUBJECTS
        private void button23_Click(object sender, EventArgs e)
        {
            ShowUserControl(addClassSub1);
        }

        // FEE FORM
        private void button12_Click(object sender, EventArgs e)
        {
            ShowUserControl(feeForm1);
        }

        // DASHBOARD
        private void button2_Click_2(object sender, EventArgs e)
        {
            ShowUserControl(dashboardForm1);
        }
        private void button13_Click(object sender, EventArgs e)
        {
            //viewTeacher t = new viewTeacher();
            //panel4.Controls.Add(t);
            ShowUserControl(viewTeacher1);
        }
        private void button20_Click(object sender, EventArgs e)
        {
            ShowUserControl(assignFee1);
        }
        private void button19_Click(object sender, EventArgs e)
        {
            ShowUserControl(viewFeeRecord1);
        }
        private void button16_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }







        // LOGOUT
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Form2 logout = new Form2();
                logout.Show();
                this.Hide();
            }
        }

        // PictureBox click also logout (optional)
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        // Empty event handlers can be removed safely unless used in designer
        private void label2_Click(object sender, EventArgs e) { }
        private void button3_Click(object sender, EventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void panel3_Paint(object sender, PaintEventArgs e) { }
        private void button6_Click(object sender, EventArgs e) { }
        private void button6_Click_1(object sender, EventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void menuContainer_Paint(object sender, PaintEventArgs e) { }
        private void button37_Click(object sender, EventArgs e) { }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
        private void button2_Click_1(object sender, EventArgs e) { }
        private void button3_Click_1(object sender, EventArgs e) { }
        private void addTeacherForm1_Load(object sender, EventArgs e) { }
        private void panel4_Paint(object sender, PaintEventArgs e) { }
        private void button6_Click_2(object sender, EventArgs e) { }
        private void label2_Click_1(object sender, EventArgs e) { }

        // These are placeholder handlers - customize as needed
        private void button6_Click_3(object sender, EventArgs e) { hideSubMenu(); }
        private void button7_Click(object sender, EventArgs e) { hideSubMenu(); }
        private void button9_Click(object sender, EventArgs e) { hideSubMenu(); }
        private void button10_Click(object sender, EventArgs e) { hideSubMenu(); }

        private void button15_Click(object sender, EventArgs e)
        {

            ShowUserControl(editTeacherRecord1);

        }
        private void button14_Click(object sender, EventArgs e) { hideSubMenu(); }

        private void button30_Click(object sender, EventArgs e) { hideSubMenu(); }
        private void button21_Click(object sender, EventArgs e) { hideSubMenu(); }


        private void viewTeacherRole1_Load(object sender, EventArgs e)
        {

        }

        private void assignFee1_Load(object sender, EventArgs e)
        {

        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            ShowUserControl(monthlyRep1);
        }

        private void editTeacherRecord1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Form2 loginForm = new Form2();  // replace with your actual login form name if different
                loginForm.Show();
                this.Hide(); // hides the current form (or use this.Close() if appropriate)
            }
        }
    }
}