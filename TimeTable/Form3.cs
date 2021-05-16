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
    }
}
