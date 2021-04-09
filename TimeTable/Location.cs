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
    public partial class Location : Form
    {
        PlaceRepo PlaceRepo = new PlaceRepo();
        public Location()
        {
            InitializeComponent();
        }

       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        string Rtype;
        private void btnLocsave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtbuildname.Text) && !string.IsNullOrEmpty(txtLRoomname.Text) && !string.IsNullOrEmpty(Rtype) && !string.IsNullOrEmpty(txtLcapacity.Text))
            {
                PlaceRepo.Add(new Place
                {
                    Building_name = txtbuildname.Text,
                    Room_name = txtLRoomname.Text,
                    Room_type = Rtype,
                    Capacity = txtLcapacity.Text,
                });
                txtbuildname.Text = string.Empty;
                txtLRoomname.Text = string.Empty;
                Rtype = string.Empty;
                txtLcapacity.Text = string.Empty;
                dataGridView1.DataSource = PlaceRepo.GetAll();
                dataGridView2.DataSource = PlaceRepo.GetAll();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Rtype = "Lecture Hall";       
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Rtype = "Laboratory";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                var place = (Place)row.DataBoundItem;
                txtlocID.Text = place.Location_ID.ToString();
                txtLUbuildingname.Text = place.Building_name;
                txtLURoomname.Text = place.Room_name;
                RUtype = place.Room_type;
                txtLUCapacity.Text = place.Capacity;
            }
            
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                var row = dataGridView2.SelectedRows[0];
                var place = (Place)row.DataBoundItem;
                txtbuildname.Text = place.Building_name;
                txtLRoomname.Text = place.Room_name;
                Rtype = place.Room_type;
                txtLcapacity.Text = place.Capacity;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = PlaceRepo.GetAll();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = PlaceRepo.GetAll();
        }

        string RUtype;
        private void btnLUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtlocID.Text) && !string.IsNullOrEmpty(txtLUbuildingname.Text) && !string.IsNullOrEmpty(txtLURoomname.Text) && !string.IsNullOrEmpty(RUtype) && !string.IsNullOrEmpty(txtLUCapacity.Text))
            {
                PlaceRepo.Update(new Place
                {
                    Location_ID = int.Parse(txtlocID.Text),
                    Building_name = txtLUbuildingname.Text,
                    Room_name = txtLURoomname.Text,
                    Room_type = RUtype,
                    Capacity = txtLUCapacity.Text,
                });
                dataGridView1.DataSource = PlaceRepo.GetAll();
            }
        }

        private void radioLulechall_CheckedChanged(object sender, EventArgs e)
        {
            RUtype = "Lecture Hall";
        }

        private void radioLUlab_CheckedChanged(object sender, EventArgs e)
        {
            RUtype = "Laboratory";
        }

        private void btnLDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtLUbuildingname.Text) && !string.IsNullOrEmpty(txtLURoomname.Text) && !string.IsNullOrEmpty(RUtype) && !string.IsNullOrEmpty(txtLUCapacity.Text))
            {
                PlaceRepo.Delete(int.Parse(txtlocID.Text));
                txtLUbuildingname.Text = string.Empty;
                txtLURoomname.Text = string.Empty;
                RUtype = string.Empty;
                txtLUCapacity.Text = string.Empty;

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
