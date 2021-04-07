using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTable
{
    public partial class Lecturer : Form
    {
        LecRepo LecRepo = new LecRepo();
        SubjectRepo SubjectRepo = new SubjectRepo();
        public Lecturer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = LecRepo.GetAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtlecname.Text) && !string.IsNullOrEmpty(cmbFac.Text) && !string.IsNullOrEmpty(cmbDep.Text) && !string.IsNullOrEmpty(cmbCenter.Text) && !string.IsNullOrEmpty(cmbBuild.Text) && !string.IsNullOrEmpty(cmblvl.Text) && !string.IsNullOrEmpty(txtrank.Text))
            {
                LecRepo.Add(new Lecs
                {
                    Lecturer_name = txtlecname.Text,
                    Faculty = cmbFac.Text,
                    Department = cmbDep.Text,
                    Building = cmbBuild.Text,
                    Level = cmblvl.Text
                });
                txtlecname.Text = string.Empty;
                cmbFac.Text = string.Empty;
                cmbDep.Text = string.Empty;
                cmbBuild.Text = string.Empty;
                cmblvl.Text = string.Empty;
                //dataGridView1.DataSource = LecRepo.GetAll();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                var lect = (Lecs)row.DataBoundItem;
                txtUid.Text = lect.Lecturer_ID.ToString();
                txtUlec.Text = lect.Lecturer_name;
                cmbUfac.Text = lect.Faculty;
                cmbUdep.Text = lect.Department;
                cmbUbuild.Text = lect.Building;
                cmbUlvl.Text = lect.Level;
                txtUrank.Text = lect.Rank;

            }
        }

        private void btnMUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUid.Text) && !string.IsNullOrEmpty(txtUlec.Text) && !string.IsNullOrEmpty(cmbUfac.Text) && !string.IsNullOrEmpty(cmbUdep.Text) && !string.IsNullOrEmpty(cmbUbuild.Text) && !string.IsNullOrEmpty(cmbUlvl.Text) && !string.IsNullOrEmpty(txtUrank.Text))
            {
                LecRepo.Update(new Lecs
                {
                    Lecturer_ID = int.Parse(txtUid.Text),
                    Lecturer_name = txtUlec.Text,
                    Faculty = cmbUfac.Text,
                    Department = cmbUdep.Text,
                    Building = cmbUbuild.Text,
                    //Lvl = cmbUlvl.Text,
                    //Rank = txtUrank.Text,

                });
                //dataGridView1.DataSource = LecRepo.GetAll();
            }
        }

        private void btnMdelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUid.Text) && !string.IsNullOrEmpty(txtUlec.Text) && !string.IsNullOrEmpty(cmbUfac.Text) && !string.IsNullOrEmpty(cmbUdep.Text) && !string.IsNullOrEmpty(cmbUbuild.Text) && !string.IsNullOrEmpty(cmbUlvl.Text) && !string.IsNullOrEmpty(txtUrank.Text))
            {
                LecRepo.Delete(int.Parse(txtlecid.Text));
                txtUlec.Text = string.Empty;
                cmbUfac.Text = string.Empty;
                cmbUdep.Text = string.Empty;
                cmbUbuild.Text = string.Empty;
                cmbUlvl.Text = string.Empty;
                txtUrank.Text = string.Empty;

                //dataGridView1.DataSource = LecRepo.GetAll();
            }
        }

        string Offeredsem;
        private void BtnSsave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbSoy.Text) && !string.IsNullOrEmpty(Offeredsem) && !string.IsNullOrEmpty(txtSsn.Text) && !string.IsNullOrEmpty(txtSsc.Text) && !string.IsNullOrEmpty(txtSnlh.Text) && !string.IsNullOrEmpty(txtSnth.Text) && !string.IsNullOrEmpty(txtlh.Text) && !string.IsNullOrEmpty(txtSneh.Text))
            {
                SubjectRepo.Add(new Subject
                {
                    Offerd_year = cmbSoy.Text,
                    Offerd_sem = Offeredsem,
                    Subject_name = txtSsn.Text,
                    Subject_Code = txtSsc.Text,
                    No_Lec_hrs = txtSnlh.Text,
                    No_Tute_hrs = txtSnth.Text,
                    No_Lab_hrs = txtlh.Text,
                    No_Evaluation_hrs = txtSneh.Text,
                });
                cmbSoy.Text = string.Empty;
                Offeredsem = string.Empty;
                txtSsn.Text = string.Empty;
                txtSsn.Text = string.Empty;
                txtSsc.Text = string.Empty;
                txtSnlh.Text = string.Empty;
                txtSnth.Text = string.Empty;
                txtlh.Text = string.Empty;
                txtSneh.Text = string.Empty;
                dataGridView2.DataSource = SubjectRepo.GetAll();
                dataGridView3.DataSource = SubjectRepo.GetAll();
            }
        }

        private void radiobtn1stsem_CheckedChanged(object sender, EventArgs e)
        {
            Offeredsem = "1St Semester";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            Offeredsem = "2nd Semester";
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                var row = dataGridView2.SelectedRows[0];
                var subject = (Subject)row.DataBoundItem;
                txtUSsubid.Text = subject.Subject_ID.ToString();
                cmbUoffyear.Text = subject.Offerd_year;
                Offeredsem = subject.Offerd_sem;
                txtUsubname.Text = subject.Subject_name;
                txtUsubCode.Text = subject.Subject_Code;
                txtUSnlh.Text = subject.No_Lec_hrs;
                txtUSnth.Text = subject.No_Tute_hrs;
                txtUSlh.Text = subject.No_Lab_hrs;
                txtUSneh.Text = subject.No_Evaluation_hrs;
            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = SubjectRepo.GetAll();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView3.SelectedRows.Count > 0)
            {
                var row = dataGridView3.SelectedRows[0];
                var subject = (Subject)row.DataBoundItem;
                cmbSoy.Text = subject.Offerd_year;
                Offeredsem = subject.Offerd_sem;
                txtSsn.Text = subject.Subject_name;
                txtSsc.Text = subject.Subject_Code;
                txtSnlh.Text = subject.No_Lec_hrs;
                txtSnth.Text = subject.No_Tute_hrs;
                txtlh.Text = subject.No_Lab_hrs;
                txtSneh.Text = subject.No_Evaluation_hrs;
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = SubjectRepo.GetAll();
        }

        private void btnSUupdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUSsubid.Text) && !string.IsNullOrEmpty(cmbUoffyear.Text) && !string.IsNullOrEmpty(Offeredsem) && !string.IsNullOrEmpty(txtUsubname.Text) && !string.IsNullOrEmpty(txtUsubCode.Text) && !string.IsNullOrEmpty(txtUSnlh.Text) && !string.IsNullOrEmpty(txtUSnth.Text) && !string.IsNullOrEmpty(txtUSlh.Text) && !string.IsNullOrEmpty(txtUSneh.Text))
            {
                SubjectRepo.Update(new Subject
                {
                    Subject_ID = int.Parse(txtUSsubid.Text),
                    Offerd_year = cmbUoffyear.Text,
                    Offerd_sem = Offeredsem,
                    Subject_name = txtUsubname.Text,
                    Subject_Code = txtUsubCode.Text,
                    No_Lec_hrs = txtUSnlh.Text,
                    No_Tute_hrs = txtUSnth.Text,
                    No_Lab_hrs = txtUSlh.Text,
                    No_Evaluation_hrs = txtUSneh.Text,
                });
                dataGridView2.DataSource = SubjectRepo.GetAll();
            }
        }

        private void btnSUdelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbUoffyear.Text) && !string.IsNullOrEmpty(Offeredsem) && !string.IsNullOrEmpty(txtUsubname.Text) && !string.IsNullOrEmpty(txtUsubCode.Text) && !string.IsNullOrEmpty(txtUSnlh.Text) && !string.IsNullOrEmpty(txtUSnth.Text) && !string.IsNullOrEmpty(txtUSlh.Text) && !string.IsNullOrEmpty(txtUSneh.Text))
            {
                SubjectRepo.Delete(int.Parse(txtUSsubid.Text));
                cmbUoffyear.Text = string.Empty;
                Offeredsem = string.Empty;
                txtUsubname.Text = string.Empty;
                txtUsubCode.Text = string.Empty;
                txtUSnlh.Text = string.Empty;
                txtUSnth.Text = string.Empty;
                txtUSlh.Text = string.Empty;
                txtUSneh.Text = string.Empty;

                dataGridView2.DataSource = SubjectRepo.GetAll();

            }

        }

        private void txtUSnlh_TextChanged(object sender, EventArgs e)
        {

        }
    
    }
}
