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
    public partial class Form3 : Form
    {
        StudentRepo studentRepo = new StudentRepo();
        LocationGroupRepo LocationGroupRepo = new LocationGroupRepo();
        public Form3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtAddGroupId.Text = txtAddAYS.Text + '.' + txtAddGroupNo.Text + '.' + '(' + txtAddProg.Text + ')';
            txtAddSubGroupId.Text = txtAddAYS.Text + '.' + txtAddGroupNo.Text + '.' + txtAddSubGroupNo.Text + '(' + txtAddProg.Text + ')';
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            /*dataGridView1_CellContentClick.DataSource = studentRepo.GetAll();*/
            dataGridView1.DataSource = studentRepo.GetAll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAddAYS.Text) && !string.IsNullOrEmpty(txtAddProg.Text) && !string.IsNullOrEmpty(txtAddGroupNo.Text) && !string.IsNullOrEmpty(txtAddSubGroupNo.Text) && !string.IsNullOrEmpty(txtAddGroupId.Text) && !string.IsNullOrEmpty(txtAddSubGroupId.Text))
            {
                studentRepo.Add(new Student
                {
                    Academic_Year_Semester = txtAddAYS.Text,
                    Programme = txtAddProg.Text,
                    Group_Number = txtAddGroupNo.Text,
                    Sub_Group_Number = txtAddSubGroupNo.Text,
                    /*Group_ID = txtAddGroupId.Text,
                    Sub_Group_ID = txtAddSubGroupId*/
                });
                txtAddAYS.Text = string.Empty;
                txtAddProg.Text = string.Empty;
                txtAddGroupNo.Text = string.Empty;
                txtAddSubGroupNo.Text = string.Empty;
                txtAddGroupId.Text = string.Empty;
                txtAddSubGroupId.Text = string.Empty;
                dataGridView2.DataSource = studentRepo.GetAll();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                var student = (Student)row.DataBoundItem;
                txtMSID.Text = student.Student_ID.ToString();
                txtMAYS.Text = student.Academic_Year_Semester;
                txtMProg.Text = student.Programme;
                txtMGN.Text = student.Group_Number;
                txtMSGN.Text = student.Sub_Group_Number;
                txtMGI.Text = student.Group_ID;
                txtSGI.Text = student.Sub_Group_ID;

            }
        }

        private void btnMUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMSID.Text) && !string.IsNullOrEmpty(txtMAYS.Text) && !string.IsNullOrEmpty(txtMProg.Text) && !string.IsNullOrEmpty(txtMGN.Text) && !string.IsNullOrEmpty(txtMSGN.Text) && !string.IsNullOrEmpty(txtMGI.Text) && !string.IsNullOrEmpty(txtSGI.Text))
            {
                studentRepo.Update(new Student
                {
                    Student_ID = int.Parse(txtMSID.Text),
                    Academic_Year_Semester = txtMAYS.Text,
                    Programme = txtMProg.Text,
                    Group_Number = txtMGN.Text,
                    Sub_Group_Number = txtMSGN.Text,

                });
                dataGridView1.DataSource = studentRepo.GetAll();
            }
        }

        private void btnMDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMSID.Text) && !string.IsNullOrEmpty(txtMAYS.Text) && !string.IsNullOrEmpty(txtMProg.Text) && !string.IsNullOrEmpty(txtMGN.Text) && !string.IsNullOrEmpty(txtMSGN.Text) && !string.IsNullOrEmpty(txtMGI.Text) && !string.IsNullOrEmpty(txtSGI.Text))
            {
                studentRepo.Delete(int.Parse(txtMSID.Text));
                txtMSID.Text = string.Empty;
                txtMAYS.Text = string.Empty;
                txtMProg.Text = string.Empty;
                txtMGN.Text = string.Empty;
                txtMSGN.Text = string.Empty;
                txtMGI.Text = string.Empty;
                txtSGI.Text = string.Empty;

                dataGridView1.DataSource = studentRepo.GetAll();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtAddAYS.Text = string.Empty;
            txtAddProg.Text = string.Empty;
            txtAddGroupNo.Text = string.Empty;
            txtAddSubGroupNo.Text = string.Empty;
            txtAddGroupId.Text = string.Empty;
            txtAddSubGroupId.Text = string.Empty;
        }

        private void btnMClear_Click(object sender, EventArgs e)
        {
            txtMSID.Text = string.Empty;
            txtMAYS.Text = string.Empty;
            txtMProg.Text = string.Empty;
            txtMGN.Text = string.Empty;
            txtMSGN.Text = string.Empty;
            txtMGI.Text = string.Empty;
            txtSGI.Text = string.Empty;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_time_table_managementDataSet83.Session' table. You can move, or remove it, as needed.
            //this.sessionTableAdapter.Fill(this._time_table_managementDataSet83.Session);
            // TODO: This line of code loads data into the '_time_table_managementDataSet82.Teacher' table. You can move, or remove it, as needed.
            //this.teacherTableAdapter.Fill(this._time_table_managementDataSet82.Teacher);
            // TODO: This line of code loads data into the '_time_table_managementDataSet81.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter3.Fill(this._time_table_managementDataSet81.Student);
            // TODO: This line of code loads data into the '_time_table_managementDataSet80.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter2.Fill(this._time_table_managementDataSet80.Student);
            // TODO: This line of code loads data into the '_time_table_managementDataSet63.LocationGroup' table. You can move, or remove it, as needed.
            this.locationGroupTableAdapter.Fill(this._time_table_managementDataSet63.LocationGroup);
            // TODO: This line of code loads data into the '_time_table_managementDataSet62.Location' table. You can move, or remove it, as needed.
            this.locationTableAdapter.Fill(this._time_table_managementDataSet62.Location);
            // TODO: This line of code loads data into the '_time_table_managementDataSet61.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter1.Fill(this._time_table_managementDataSet61.Student);
            // TODO: This line of code loads data into the '_time_table_managementDataSet60.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this._time_table_managementDataSet60.Student);

        }

        private void btnSaveG_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbGroup.Text) || !string.IsNullOrEmpty(cmbSubGroup.Text) && !string.IsNullOrEmpty(cmbGRoom.Text))
            {
                LocationGroupRepo.Add(new LocationGroup
                {
                    Group_ID = cmbGroup.Text,
                    Sub_Group_ID = cmbSubGroup.Text,
                    Room_Name = cmbGRoom.Text,

                });
                cmbGroup.Text = string.Empty;
                cmbSubGroup.Text = string.Empty;
                cmbGRoom.Text = string.Empty;

                dataGridView6.DataSource = LocationGroupRepo.GetAll();
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            dataGridView6.DataSource = LocationGroupRepo.GetAll();
        }

        private void btnClearG_Click(object sender, EventArgs e)
        {
            cmbGroup.Text = string.Empty;
            cmbSubGroup.Text = string.Empty;
            cmbGRoom.Text = string.Empty;
        }
    }
}
