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
    public partial class Form4 : Form
    {
        LocationTagRepo LocationTagRepo = new LocationTagRepo();
        SubjectTagLocationRepo SubjectTagLocationRepo = new SubjectTagLocationRepo();
        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = LocationTagRepo.GetAll();
        }

        private void cmbLRoom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTSave_Click(object sender, EventArgs e)
        {
            {
                if (!string.IsNullOrEmpty(cmbLTag.Text) && !string.IsNullOrEmpty(cmbLSubject.Text) && !string.IsNullOrEmpty(cmbLRoom.Text))
                {
                    LocationTagRepo.Add(new LocationTag
                    {
                        Tag = cmbLTag.Text,
                        Subject_Name = cmbLSubject.Text,
                        Room_Name = cmbLRoom.Text

                    });

                    cmbLTag.Text = string.Empty;
                    cmbLSubject.Text = string.Empty;
                    cmbLRoom.Text = string.Empty;
                    dataGridView2.DataSource = LocationTagRepo.GetAll();
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                var row = dataGridView2.SelectedRows[0];
                var LocationTag = (LocationTag)row.DataBoundItem;
                cmbLTag.Text = LocationTag.Tag;
                cmbLSubject.Text = LocationTag.Subject_Name;
                cmbLRoom.Text = LocationTag.Room_Name;
              
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            {
                if (!string.IsNullOrEmpty(cmb1.Text) && !string.IsNullOrEmpty(cmb2.Text) && !string.IsNullOrEmpty(cmb3.Text) && !string.IsNullOrEmpty(cmb4.Text))
                {
                    SubjectTagLocationRepo.Add(new SubjectTagLocation
                    {
                        Tag = cmb1.Text,
                        Subject_Code = cmb2.Text,
                        Subject_Name = cmb3.Text,
                        Room_Name = cmb4.Text

                    });

                    cmb1.Text = string.Empty;
                    cmb2.Text = string.Empty;
                    cmb3.Text = string.Empty;
                    cmb4.Text = string.Empty;
                    dataGridView7.DataSource = SubjectTagLocationRepo.GetAll();
                }
            }
        }

        private void label48_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
            dataGridView7.DataSource = SubjectTagLocationRepo.GetAll();
        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTClear_Click(object sender, EventArgs e)
        {
            cmbLTag.Text = string.Empty;
            cmbLSubject.Text = string.Empty;
            cmbLRoom.Text = string.Empty;
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            cmb1.Text = string.Empty;
            cmb2.Text = string.Empty;
            cmb3.Text = string.Empty;
            cmb4.Text = string.Empty;
        }
    }
}
