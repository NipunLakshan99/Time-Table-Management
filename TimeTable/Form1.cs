using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TimeTable
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

            lblStudent.Text = "LECTURER";
            this.pnlFormLoader.Controls.Clear();
            Lecturer lecturer = new Lecturer() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            lecturer.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(lecturer);
            lecturer.Show();

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblStudent.Text = "STUDENT";
            this.pnlFormLoader.Controls.Clear();
            Form3 form3 = new Form3() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            form3.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(form3);
            form3.Show();


            /* var newForm = new Form3();
             newForm.Show();*/
        }

        private void btnTag_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSubject_Click(object sender, EventArgs e)
        {
            

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblStudent_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            
        }

        private void btnWorkingdays_Click(object sender, EventArgs e)
        {

        }

        private void btnLecturer_Click(object sender, EventArgs e)
        {
            lblStudent.Text = "LECTURER";
            this.pnlFormLoader.Controls.Clear();
            Lecturer lecturer = new Lecturer() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            lecturer.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(lecturer);
            lecturer.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(null, "Do You Want to Exit", "Select", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnStatistic_Click_1(object sender, EventArgs e)
        {
            lblStudent.Text = "STATISTICS";
            this.pnlFormLoader.Controls.Clear();
            Statistics statistics = new Statistics() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            statistics.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(statistics);
            statistics.Show();
        }

        private void btnLocation_Click_1(object sender, EventArgs e)
        {
            lblStudent.Text = "LOCATION";
            this.pnlFormLoader.Controls.Clear();
            Location location = new Location() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            location.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(location);
            location.Show();
        }

        private void btnTag_Click_1(object sender, EventArgs e)
        {
            /* var newForm = new Form4();
             newForm.Show();*/
            lblStudent.Text = "TAGS";
            this.pnlFormLoader.Controls.Clear();
            Form4 form4 = new Form4() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            form4.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(form4);
            form4.Show();
        }

        private void btnSubject_Click_1(object sender, EventArgs e)
        {
            /*var newForm = new Form5();
            newForm.Show();*/
            lblStudent.Text = "SESSIONS";
            this.pnlFormLoader.Controls.Clear();
            Form5 form5 = new Form5() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            form5.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(form5);
            form5.Show();
        }
    }
}
