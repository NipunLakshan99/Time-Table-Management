using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace TimeTable
{
    public partial class Location : Form
    {
        PlaceRepo PlaceRepo = new PlaceRepo();
        SessionRepo SessionRepo = new SessionRepo();
        LocationSessionRepo LocationSessionRepo = new LocationSessionRepo();
        LNotAvailableTimeRepo LNotAvailableTimeRepo = new LNotAvailableTimeRepo();
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

        private void LocationNotAvailable_Add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(LNATRoom.Text) && !string.IsNullOrEmpty(LNATDay.Text) && !string.IsNullOrEmpty(LNATStart_Time.Text) && !string.IsNullOrEmpty(LNATEnd_Time.Text))
            {
                LNotAvailableTimeRepo.Add(new LNotAvailableTime
                {
                    Room = LNATRoom.Text,
                    Day = LNATDay.Text,
                    Start_Time = LNATStart_Time.Text,
                    End_Time = LNATEnd_Time.Text,

                });
                LNATRoom.Text = string.Empty;
                LNATDay.Text = string.Empty;
                LNATStart_Time.Text = string.Empty;
                LNATEnd_Time.Text = string.Empty;
            }
        }

        private void Location_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_time_table_managementDataSet50.Session' table. You can move, or remove it, as needed.
            this.sessionTableAdapter5.Fill(this._time_table_managementDataSet50.Session);
            // TODO: This line of code loads data into the '_time_table_managementDataSet49.Session' table. You can move, or remove it, as needed.
            this.sessionTableAdapter4.Fill(this._time_table_managementDataSet49.Session);
            // TODO: This line of code loads data into the '_time_table_managementDataSet39.Location' table. You can move, or remove it, as needed.
            this.locationTableAdapter3.Fill(this._time_table_managementDataSet39.Location);
            // TODO: This line of code loads data into the '_time_table_managementDataSet38.Session' table. You can move, or remove it, as needed.
            //this.sessionTableAdapter3.Fill(this._time_table_managementDataSet38.Session);
            // TODO: This line of code loads data into the '_time_table_managementDataSet37.Location' table. You can move, or remove it, as needed.
            this.locationTableAdapter2.Fill(this._time_table_managementDataSet37.Location);
            // TODO: This line of code loads data into the '_time_table_managementDataSet36.Session' table. You can move, or remove it, as needed.
            this.sessionTableAdapter2.Fill(this._time_table_managementDataSet36.Session);
            // TODO: This line of code loads data into the '_time_table_managementDataSet35.Session' table. You can move, or remove it, as needed.
            //this.sessionTableAdapter1.Fill(this._time_table_managementDataSet35.Session);
            // TODO: This line of code loads data into the '_time_table_managementDataSet34.Location' table. You can move, or remove it, as needed.
            this.locationTableAdapter1.Fill(this._time_table_managementDataSet34.Location);
            // TODO: This line of code loads data into the '_time_table_managementDataSet33.Session' table. You can move, or remove it, as needed.
            this.sessionTableAdapter.Fill(this._time_table_managementDataSet33.Session);
            // TODO: This line of code loads data into the '_time_table_managementDataSet21.Location' table. You can move, or remove it, as needed.
            this.locationTableAdapter.Fill(this._time_table_managementDataSet21.Location);

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            dataGridView7.DataSource = LNotAvailableTimeRepo.GetAll();
        }

        private void btnSAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt1.Text) && !string.IsNullOrEmpty(txt3.Text) && !string.IsNullOrEmpty(txt4.Text) && !string.IsNullOrEmpty(txt5.Text) && !string.IsNullOrEmpty(txt6.Text) && !string.IsNullOrEmpty(cmbSRoom.Text))
            {
                LocationSessionRepo.Add(new LocationSession
                {
                    Lecturer_1 = txt1.Text,
                    Lecturer_2 = txt2.Text,
                    Subject_Code = txt3.Text,
                    Subject_Name = txt4.Text,
                    Group_ID = txt5.Text,
                    Tag = txt6.Text,
                    Room = cmbSRoom.Text,
                });
                txt1.Text = string.Empty;
                txt2.Text = string.Empty;
                txt3.Text = string.Empty;
                txt4.Text = string.Empty;
                txt5.Text = string.Empty;
                txt6.Text = string.Empty;
                cmbSRoom.Text = string.Empty;
                dataGridView5.DataSource = LocationSessionRepo.GetAll();

            }
        }

        private void btnSClear_Click(object sender, EventArgs e)
        {
            txt1.Text = string.Empty;
            txt2.Text = string.Empty;
            txt3.Text = string.Empty;
            txt4.Text = string.Empty;
            txt5.Text = string.Empty;
            txt6.Text = string.Empty;
            txt7.Text = string.Empty;
            cmbSRoom.Text = string.Empty;
        }

        private void cmbSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            String str = @"Server=tcp:time-table.database.windows.net,1433;Initial Catalog=time-table-management;Persist Security Info=False;User ID=nipun;Password=lakshan123@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection con = new SqlConnection(str);

            try
            {
                con.Open();

                string query = "SELECT * FROM Session WHERE Session_ID = '" + cmbSession.Text + "'";
                SqlCommand cmd;
                cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txt7.Text = reader["Session_ID"].ToString();
                    txt1.Text = reader["Lecture1"].ToString();
                    txt2.Text = reader["Lecture2"].ToString();
                    txt3.Text = reader["Subject_ID"].ToString();
                    txt4.Text = reader["Subject_Name"].ToString();
                    txt6.Text = reader["Tag"].ToString();
                    txt5.Text = reader["Group_ID"].ToString();
                    
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = SessionRepo.GetAll();
        }

        private void btnCSSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtc1.Text) && !string.IsNullOrEmpty(txtc3.Text) && !string.IsNullOrEmpty(txtc4.Text) && !string.IsNullOrEmpty(txtc5.Text) && !string.IsNullOrEmpty(txtc6.Text) && !string.IsNullOrEmpty(cmbRC.Text))
            {
                LocationSessionRepo.Add(new LocationSession
                {
                    Lecturer_1 = txtc1.Text,
                    Lecturer_2 = txtc2.Text,
                    Subject_Code = txtc3.Text,
                    Subject_Name = txtc4.Text,
                    Group_ID = txtc5.Text,
                    Tag = txtc6.Text,
                    Room = cmbRC.Text,
                });
                txtc1.Text = string.Empty;
                txtc2.Text = string.Empty;
                txtc3.Text = string.Empty;
                txtc4.Text = string.Empty;
                txtc5.Text = string.Empty;
                txtc6.Text = string.Empty;
                cmbRC.Text = string.Empty;
                dataGridView5.DataSource = LocationSessionRepo.GetAll();
            }
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {
            dataGridView4.DataSource = SessionRepo.GetAll();
        }

        private void cmbSC_SelectedIndexChanged(object sender, EventArgs e)
        {
            String str = @"Server=tcp:time-table.database.windows.net,1433;Initial Catalog=time-table-management;Persist Security Info=False;User ID=nipun;Password=lakshan123@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection con = new SqlConnection(str);

            try
            {
                con.Open();

                string query = "SELECT * FROM Session WHERE Session_ID = '" + cmbSC.Text + "'";
                SqlCommand cmd;
                cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtc7.Text = reader["Session_ID"].ToString();
                    txtc1.Text = reader["Lecture1"].ToString();
                    txtc2.Text = reader["Lecture2"].ToString();
                    txtc3.Text = reader["Subject_ID"].ToString();
                    txtc4.Text = reader["Subject_Name"].ToString();
                    txtc6.Text = reader["Tag"].ToString();
                    txtc5.Text = reader["Group_ID"].ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void btnCSClear_Click(object sender, EventArgs e)
        {
            txtc1.Text = string.Empty;
            txtc2.Text = string.Empty;
            txtc3.Text = string.Empty;
            txtc4.Text = string.Empty;
            txtc5.Text = string.Empty;
            txtc6.Text = string.Empty;
            txtc7.Text = string.Empty;
            cmbRC.Text = string.Empty;
            cmbSession.Text = string.Empty;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.Update();
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {
            dataGridView5.DataSource = LocationSessionRepo.GetAll();
        }
    }
}
