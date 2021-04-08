﻿using System;
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
    public partial class Form7 : Form
    {
        TagRepo tagRepo = new TagRepo();
        public Form7()
        {
            InitializeComponent();
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
                
                dataGridView2.DataSource = tagRepo.GetAll();
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tagRepo.GetAll();
        }

        private void txtTagName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                var tag = (Tag)row.DataBoundItem;
                txtMTagID.Text = tag.Tag_ID.ToString();
                txtMTagName.Text = tag.Tag_Name;
                txtMTagCode.Text = tag.Tag_Code;
                txtMRelatedTag.Text = tag.Related_Tag;
               
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMTagID.Text) && !string.IsNullOrEmpty(txtMTagName.Text) && !string.IsNullOrEmpty(txtMTagCode.Text) && !string.IsNullOrEmpty(txtMRelatedTag.Text))
            {
                tagRepo.Delete(int.Parse(txtMTagID.Text));
                txtMTagID.Text = string.Empty;
                txtMTagName.Text = string.Empty;
                txtMTagCode.Text = string.Empty;
                txtMRelatedTag.Text = string.Empty;
               
                dataGridView1.DataSource = tagRepo.GetAll();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
                dataGridView1.DataSource = tagRepo.GetAll();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTagName.Text = string.Empty;
            txtTagCode.Text = string.Empty;
            txtRelatedTag.Text = string.Empty;
        }

        private void btnMClear_Click(object sender, EventArgs e)
        {
            txtMTagID.Text = string.Empty;
            txtMTagName.Text = string.Empty;
            txtMTagCode.Text = string.Empty;
            txtMRelatedTag.Text = string.Empty;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                var row = dataGridView2.SelectedRows[0];
                var tag = (Tag)row.DataBoundItem;
                //txtMTagID.Text = tag.Tag_ID.ToString();
                txtTagName.Text = tag.Tag_Name;
                txtTagCode.Text = tag.Tag_Code;
                txtRelatedTag.Text = tag.Related_Tag;

            }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = tagRepo.GetAll();

        }
    }
}
