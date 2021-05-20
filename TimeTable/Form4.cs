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
        TagRepo tagRepo = new TagRepo();
        SubjectTagLocationRepo SubjectTagLocationRepo = new SubjectTagLocationRepo();
        public Form4()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTagName.Text) && !string.IsNullOrEmpty(txtTagCode.Text) && !string.IsNullOrEmpty(txtRelatedTag.Text))
            {
                tagRepo.Add(new Tag
                {
                    Tag_Name = txtTagName.Text,
                    Tag_Code = txtTagCode.Text,
                    Related_Tag = txtRelatedTag.Text,

                });
                txtTagName.Text = string.Empty;
                txtTagCode.Text = string.Empty;
                txtRelatedTag.Text = string.Empty;

                dataGridView1.DataSource = tagRepo.GetAll();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTagName.Text = string.Empty;
            txtTagCode.Text = string.Empty;
            txtRelatedTag.Text = string.Empty;
        }

        private void btnMUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMTagID.Text) && !string.IsNullOrEmpty(txtMTagName.Text) && !string.IsNullOrEmpty(txtMTagCode.Text) && !string.IsNullOrEmpty(txtMRelatedTag.Text))
            {
                tagRepo.Update(new Tag
                {
                    Tag_ID = int.Parse(txtMTagID.Text),
                    Tag_Name = txtMTagName.Text,
                    Tag_Code = txtMTagCode.Text,
                    Related_Tag = txtMRelatedTag.Text,


                });
                dataGridView2.DataSource = tagRepo.GetAll();
            }
        }

        private void btnMDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMTagID.Text) && !string.IsNullOrEmpty(txtMTagName.Text) && !string.IsNullOrEmpty(txtMTagCode.Text) && !string.IsNullOrEmpty(txtMRelatedTag.Text))
            {
                tagRepo.Delete(int.Parse(txtMTagID.Text));
                txtMTagID.Text = string.Empty;
                txtMTagName.Text = string.Empty;
                txtMTagCode.Text = string.Empty;
                txtMRelatedTag.Text = string.Empty;

                dataGridView2.DataSource = tagRepo.GetAll();
            }
        }

        private void btnMClear_Click(object sender, EventArgs e)
        {
            txtMTagID.Text = string.Empty;
            txtMTagName.Text = string.Empty;
            txtMTagCode.Text = string.Empty;
            txtMRelatedTag.Text = string.Empty;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                var row = dataGridView2.SelectedRows[0];
                var tag = (Tag)row.DataBoundItem;
                txtMTagID.Text = tag.Tag_ID.ToString();
                txtMTagName.Text = tag.Tag_Name;
                txtMTagCode.Text = tag.Tag_Code;
                txtMRelatedTag.Text = tag.Related_Tag;

            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tagRepo.GetAll();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = tagRepo.GetAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
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
                dataGridView6.DataSource = SubjectTagLocationRepo.GetAll();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cmb1.Text = string.Empty;
            cmb2.Text = string.Empty;
            cmb3.Text = string.Empty;
            cmb4.Text = string.Empty;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            dataGridView6.DataSource = SubjectTagLocationRepo.GetAll();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_time_table_managementDataSet68.SubjectTag' table. You can move, or remove it, as needed.
            this.subjectTagTableAdapter.Fill(this._time_table_managementDataSet68.SubjectTag);
            // TODO: This line of code loads data into the '_time_table_managementDataSet67.Location' table. You can move, or remove it, as needed.
            this.locationTableAdapter.Fill(this._time_table_managementDataSet67.Location);
            // TODO: This line of code loads data into the '_time_table_managementDataSet66.Subject' table. You can move, or remove it, as needed.
            this.subjectTableAdapter1.Fill(this._time_table_managementDataSet66.Subject);
            // TODO: This line of code loads data into the '_time_table_managementDataSet65.Subject' table. You can move, or remove it, as needed.
            this.subjectTableAdapter.Fill(this._time_table_managementDataSet65.Subject);
            // TODO: This line of code loads data into the '_time_table_managementDataSet64.Tag' table. You can move, or remove it, as needed.
            this.tagTableAdapter.Fill(this._time_table_managementDataSet64.Tag);

        }
    }
 }
    
