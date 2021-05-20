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
        TeachRepo TeachRepo = new TeachRepo();
        SubjectRepo SubjectRepo = new SubjectRepo();
        LocationModuleRepo LocationModuleRepo = new LocationModuleRepo();
        LocationLecturerRepo LocationLecturerRepo = new LocationLecturerRepo();
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
            txtrank.Text = txtlecname.Text + '.' + cmblvl.Text;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TeachRepo.GetAll();
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
               TeachRepo.Add(new Teacher
                {
                    Lecturer_name = txtlecname.Text,
                    Faculty = cmbFac.Text,
                    Department = cmbDep.Text,
                    Center = cmbCenter.Text,
                    Building = cmbBuild.Text,
                    Lvl = cmblvl.Text
                });
                txtlecname.Text = string.Empty;
                cmbFac.Text = string.Empty;
                cmbDep.Text = string.Empty;
                cmbCenter.Text = string.Empty;
                cmbBuild.Text = string.Empty;
                cmblvl.Text = string.Empty;
                txtrank.Text = string.Empty;
                dataGridView4.DataSource = TeachRepo.GetAll();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                var teacher = (Teacher)row.DataBoundItem;
                txtUid.Text = teacher.Lecturer_ID.ToString();
                txtUlec.Text = teacher.Lecturer_name;
                cmbUfac.Text = teacher.Faculty;
                cmbUdep.Text = teacher.Department;
                cmbUcen.Text = teacher.Center;
                cmbUbuild.Text = teacher.Building;
                cmbUlvl.Text = teacher.Lvl;
                txtUrank.Text = teacher.Rank;
            }
        }

        private void btnMUpdate_Click(object sender, EventArgs e)
        {
        }

        private void btnLMupdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUid.Text) && !string.IsNullOrEmpty(txtUlec.Text) && !string.IsNullOrEmpty(cmbUfac.Text) && !string.IsNullOrEmpty(cmbUdep.Text) && !string.IsNullOrEmpty(cmbUcen.Text) && !string.IsNullOrEmpty(cmbUbuild.Text) && !string.IsNullOrEmpty(cmbUlvl.Text))
            {
                TeachRepo.Update(new Teacher
                {
                    Lecturer_ID = int.Parse(txtUid.Text),
                    Lecturer_name = txtUlec.Text,
                    Faculty = cmbUfac.Text,
                    Department = cmbUdep.Text,
                    Center = cmbUcen.Text,
                    Building = cmbUbuild.Text,
                    Lvl = cmbUlvl.Text,
                    //Rank = txtUrank.Text,
                });
                dataGridView1.DataSource = TeachRepo.GetAll();

            }
        }
        private void btnMdelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUid.Text) && !string.IsNullOrEmpty(txtUlec.Text) && !string.IsNullOrEmpty(cmbUfac.Text) && !string.IsNullOrEmpty(cmbUdep.Text) && !string.IsNullOrEmpty(cmbUcen.Text) && !string.IsNullOrEmpty(cmbUbuild.Text) && !string.IsNullOrEmpty(cmbUlvl.Text))
            {
                TeachRepo.Delete(int.Parse(txtUid.Text));
                txtUid.Text = string.Empty;
                txtUlec.Text = string.Empty;
                cmbUfac.Text = string.Empty;
                cmbUdep.Text = string.Empty;
                cmbUcen.Text = string.Empty;
                cmbUbuild.Text = string.Empty;
                cmbUlvl.Text = string.Empty;
                txtUrank.Text = string.Empty;

                dataGridView1.DataSource = TeachRepo.GetAll();

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

        private void cmblvl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtlecname.Text = string.Empty;
            cmbFac.Text = string.Empty;
            cmbDep.Text = string.Empty;
            cmbCenter.Text = string.Empty;
            cmbBuild.Text = string.Empty;
            cmblvl.Text = string.Empty;
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                var teacher = (Teacher)row.DataBoundItem;
                txtUid.Text = teacher.Lecturer_ID.ToString();
                txtUlec.Text = teacher.Lecturer_name;
                cmbUfac.Text = teacher.Faculty;
                cmbUdep.Text = teacher.Department;
                cmbCenter.Text = teacher.Center;
                cmbUbuild.Text = teacher.Building;
                cmbUlvl.Text = teacher.Lvl;
                txtUrank.Text = teacher.Rank;

            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            dataGridView4.DataSource = TeachRepo.GetAll();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void Lecturer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_time_table_managementDataSet59.LocationModule' table. You can move, or remove it, as needed.
            this.locationModuleTableAdapter2.Fill(this._time_table_managementDataSet59.LocationModule);
            // TODO: This line of code loads data into the '_time_table_managementDataSet58.LocationModule' table. You can move, or remove it, as needed.
            //this.locationModuleTableAdapter1.Fill(this._time_table_managementDataSet58.LocationModule);
            // TODO: This line of code loads data into the '_time_table_managementDataSet57.LocationModule' table. You can move, or remove it, as needed.
            //this.locationModuleTableAdapter.Fill(this._time_table_managementDataSet57.LocationModule);
            // TODO: This line of code loads data into the '_time_table_managementDataSet56.Location' table. You can move, or remove it, as needed.
            this.locationTableAdapter1.Fill(this._time_table_managementDataSet56.Location);
            // TODO: This line of code loads data into the '_time_table_managementDataSet55.Subject' table. You can move, or remove it, as needed.
            this.subjectTableAdapter1.Fill(this._time_table_managementDataSet55.Subject);
            // TODO: This line of code loads data into the '_time_table_managementDataSet54.Subject' table. You can move, or remove it, as needed.
            this.subjectTableAdapter.Fill(this._time_table_managementDataSet54.Subject);
            // TODO: This line of code loads data into the '_time_table_managementDataSet53.LectureSession' table. You can move, or remove it, as needed.
            this.lectureSessionTableAdapter.Fill(this._time_table_managementDataSet53.LectureSession);
            // TODO: This line of code loads data into the '_time_table_managementDataSet52.Location' table. You can move, or remove it, as needed.
            this.locationTableAdapter.Fill(this._time_table_managementDataSet52.Location);
            // TODO: This line of code loads data into the '_time_table_managementDataSet51.Teacher' table. You can move, or remove it, as needed.
            this.teacherTableAdapter.Fill(this._time_table_managementDataSet51.Teacher);

        }

        private void btnLLSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbLLName.Text) && !string.IsNullOrEmpty(cmbLLRoom.Text))
            {
                LocationLecturerRepo.Add(new LocationLecturer
                {
                    Lecture_Name = cmbLLName.Text,
                    Room_Name = cmbLLRoom.Text
                });
                cmbLLName.Text = string.Empty;
                cmbLLRoom.Text = string.Empty;
                dataGridView5.DataSource = LocationLecturerRepo.GetAll();

            }
        }

        private void btnLLClear_Click(object sender, EventArgs e)
        {
            cmbLLName.Text = string.Empty;
            cmbLLRoom.Text = string.Empty;
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {
            dataGridView5.DataSource = LocationLecturerRepo.GetAll();
        }

        private void BtnSL_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbSubject.Text) && !string.IsNullOrEmpty(cmbSubName.Text) && !string.IsNullOrEmpty(cmbRoomName.Text))
            {
                LocationModuleRepo.Add(new LocationModule
                {
                    Module_ID = cmbSubject.Text,
                    Module_Name = cmbSubName.Text,
                    Room_Name = cmbRoomName.Text
                });
                cmbSubject.Text = string.Empty;
                cmbSubName.Text = string.Empty;
                cmbRoomName.Text = string.Empty;
                dataGridView6.DataSource = LocationModuleRepo.GetAll();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cmbSubject.Text = string.Empty;
            cmbSubName.Text = string.Empty;
            cmbRoomName.Text = string.Empty;
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {
            dataGridView6.DataSource = LocationModuleRepo.GetAll();
        }
    }
}
