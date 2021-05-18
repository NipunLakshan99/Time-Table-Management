using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        LNotAvailableTimeRepo LNotAvailableTimeRepo = new LNotAvailableTimeRepo();
        SessionRepo SessionRepo = new SessionRepo();
        SessionDayTimeRepo SessionDayTimeRepo = new SessionDayTimeRepo();
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

        private void radioWdaysend_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioWweekend_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioWweekday_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnWSave_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioBTwoH_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioBThirtyM_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtAddNWD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void LocationNotAvailable_Add_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(LNATRoom.Text) && !string.IsNullOrEmpty(LNATDay.Text) && !string.IsNullOrEmpty(LNATStart_Time.Text) && !string.IsNullOrEmpty(LNATEnd_Time.Text))
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LNATEnd_Time_TextChanged(object sender, EventArgs e)
        {

        }

        private void LNATDay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView3.SelectedRows[0];
            var LNotAvailableTime = (LNotAvailableTime)row.DataBoundItem;
            //LNot_Available_Time_ID.Text = LNotAvailableTime.LNot_Available_Time_ID.ToString();
            LNATRoom.Text = LNotAvailableTime.Room;
            LNATDay.Text = LNotAvailableTime.Day;
            LNATStart_Time.Text = LNotAvailableTime.Start_Time;
            LNATEnd_Time.Text = LNotAvailableTime.End_Time;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = LNotAvailableTimeRepo.GetAll();
        }

        private void LNATDelete_Click(object sender, EventArgs e)
        {
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
            dataGridView4.DataSource = SessionDayTimeRepo.GetAll();
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {
            dataGridView5.DataSource = SessionRepo.GetAll();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void STimeSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SeLecturer1.Text) || !string.IsNullOrEmpty(SeLecturer2.Text) && !string.IsNullOrEmpty(SSubCode.Text) && !string.IsNullOrEmpty(SSubName.Text) && !string.IsNullOrEmpty(SGroupID.Text) && !string.IsNullOrEmpty(SeTag.Text) && !string.IsNullOrEmpty(SeRoom.Text) && !string.IsNullOrEmpty(SessionDay.Text) && !string.IsNullOrEmpty(SessionSTime.Text) && !string.IsNullOrEmpty(SessionETime.Text))
            {
                SessionDayTimeRepo.Add(new SessionDayTime
                {
                    Lecturer_1 = SeLecturer1.Text,
                    Lecturer_2 = SeLecturer2.Text,
                    Subject_Code = SSubCode.Text,
                    Subject_Name = SSubName.Text,
                    Group_ID = SGroupID.Text,
                    Tag = SeTag.Text,
                    Room = SeRoom.Text,
                    Day = SessionDay.Text,
                    Start_Time = SessionSTime.Text,
                    End_Time = SessionETime.Text,
                });

                SeLecturer1.Text = string.Empty;
                SeLecturer2.Text = string.Empty;
                SSubCode.Text = string.Empty;
                SSubName.Text = string.Empty;
                SGroupID.Text = string.Empty;
                SeTag.Text = string.Empty;
                SeRoom.Text = string.Empty;
                SessionDay.Text = string.Empty;
                SessionSTime.Text = string.Empty;
                SessionETime.Text = string.Empty;
                dataGridView4.DataSource = SessionDayTimeRepo.GetAll();

            }
        }

        private void SessionADD_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SLecturer1.Text) && !string.IsNullOrEmpty(SLecturer2.Text) && !string.IsNullOrEmpty(SubCode.Text) && !string.IsNullOrEmpty(SubName.Text) && !string.IsNullOrEmpty(GroupID.Text) && !string.IsNullOrEmpty(STag.Text) && !string.IsNullOrEmpty(SRoom.Text))
            {
                SessionRepo.Add(new Session
                {
                    Lecturer_1 = SLecturer1.Text,
                    Lecturer_2 = SLecturer2.Text,
                    Subject_Code = SubCode.Text,
                    Subject_Name = SubName.Text,
                    Group_ID = GroupID.Text,
                    Tag = STag.Text,
                    Room = SRoom.Text,
                });
                SLecturer1.Text = string.Empty;
                SLecturer2.Text = string.Empty;
                SubCode.Text = string.Empty;
                SubName.Text = string.Empty;
                GroupID.Text = string.Empty;
                STag.Text = string.Empty;
                SRoom.Text = string.Empty;
                dataGridView5.DataSource = SessionRepo.GetAll();

            }
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView5.SelectedRows[0];
            var session = (Session)row.DataBoundItem;
            SLecturer1.Text = session.Lecturer_1;
            SLecturer2.Text = session.Lecturer_2;
            SubCode.Text = session.Subject_Code;
            SubName.Text = session.Subject_Name;
            GroupID.Text = session.Group_ID;
            STag.Text = session.Tag;
            SRoom.Text = session.Room;
        }

        private void SessionSTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void SessionETime_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView4.SelectedRows[0];
            var sessionDayTime = (SessionDayTime)row.DataBoundItem;
            //SessionID.Text = sessionDayTime.ID;
            SeLecturer1.Text = sessionDayTime.Lecturer_1;
            SeLecturer2.Text = sessionDayTime.Lecturer_2;
            SSubCode.Text = sessionDayTime.Subject_Code;
            SSubName.Text = sessionDayTime.Subject_Name;
            SGroupID.Text = sessionDayTime.Group_ID;
            SeTag.Text = sessionDayTime.Tag;
            SeRoom.Text = sessionDayTime.Room;
            SessionDay.Text = sessionDayTime.Day;
            SessionSTime.Text = sessionDayTime.Start_Time;
            SessionETime.Text = sessionDayTime.End_Time;
        }

        private void SessionID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = @"Data Source=(LocalDb)\AnudiDB;Initial Catalog=Timetable;Integrated Security=True";
            SqlConnection con = new SqlConnection(str);

            try
            {
                con.Open();

                string query = "SELECT * FROM Sessions WHERE ID = '" + SessionID.Text + "'";
                SqlCommand cmd;
                cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //SessionID.Text = reader[ID].ToString();
                    SeLecturer1.Text = reader["Lecturer_1"].ToString();
                    SeLecturer2.Text = reader["Lecturer_2"].ToString();
                    SSubCode.Text = reader["Subject_Code"].ToString();
                    SSubName.Text = reader["Subject_Name"].ToString();
                    SGroupID.Text = reader["Group_Id"].ToString();
                    SeTag.Text = reader["Tag"].ToString();
                    SeRoom.Text = reader["Room"].ToString();
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void Location_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'timeTableDataSet1.Sessions' table. You can move, or remove it, as needed.
            this.sessionsTableAdapter.Fill(this.timeTableDataSet1.Sessions);

        }
    }
}