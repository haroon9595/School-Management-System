using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace backup_form
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sprofileForm1.Visible = true;
            resultForm1.Visible = false;
            timetable1.Visible = false;
            viewSubject1.Visible = false;
        }

        private void timetable1_Load(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sprofileForm1.Visible = false;
            resultForm1.Visible = false;
            timetable1.Visible = false;
            viewSubject1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sprofileForm1.Visible = false;
            resultForm1.Visible = true;
            timetable1.Visible = false;
            viewSubject1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sprofileForm1.Visible = false;
            resultForm1.Visible = false;
            timetable1.Visible = true;
            viewSubject1.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void sprofileForm1_Load(object sender, EventArgs e)
        {

        }
    }
}
