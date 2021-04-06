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
            dataGridView1.DataSource = LecRepo.GetAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
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
            if(!string.IsNullOrEmpty(txtlecname.Text) && !string.IsNullOrEmpty(cmbFac.Text) && !string.IsNullOrEmpty(cmbDep.Text) && !string.IsNullOrEmpty(cmbCenter.Text) && !string.IsNullOrEmpty(cmbBuild.Text) && !string.IsNullOrEmpty(cmblvl.Text) && !string.IsNullOrEmpty(txtrank.Text))
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
                dataGridView1.DataSource = LecRepo.GetAll();
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
                dataGridView1.DataSource = LecRepo.GetAll();
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

                dataGridView1.DataSource = LecRepo.GetAll();
            }
        }
    }
}
