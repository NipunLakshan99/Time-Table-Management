using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace TimeTable
{
    public partial class Form5 : Form
    {
        WorkingRepo WorkingRepo = new WorkingRepo();
        SessionRepo SessionRepo = new SessionRepo();
        NotAvailableLecturerRepo NotAvailableLecturerRepo = new NotAvailableLecturerRepo();
        NotAvailableSessionRepo NotAvailableSessionRepo = new NotAvailableSessionRepo();
        NotAvailableGroupRepo NotAvailableGroupRepo = new NotAvailableGroupRepo();
        SessionDayTimeRepo SessionDayTimeRepo = new SessionDayTimeRepo();
        SqlConnection con = new SqlConnection("Server=tcp:time-table.database.windows.net,1433;Initial Catalog=time-table-management;Persist Security Info=False;User ID=nipun;Password=lakshan123@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public Form5()
        {
            InitializeComponent();
        }


        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Update();
        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        string Wdays;
        string Tslot;
        private void BtnWSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAddNWD.Text) && !string.IsNullOrEmpty(Wdays) && !string.IsNullOrEmpty(txtDays.Text) && !string.IsNullOrEmpty(txtAddWTD.Text) && !string.IsNullOrEmpty(txtAddSTH.Text) && !string.IsNullOrEmpty(txtAddETH.Text) && !string.IsNullOrEmpty(Tslot))
            {
                WorkingRepo.Add(new Working
                {
                    No_worikng_days = txtAddNWD.Text,
                    Working_days = Wdays,
                    Days = txtDays.Text,
                    Working_Time = txtAddWTD.Text,
                    Start_Time = txtAddSTH.Text,
                    End_Time = txtAddETH.Text,
                    Time_Slot = Tslot,

                });
                txtAddNWD.Text = string.Empty;
                Wdays = string.Empty;
                txtDays.Text = string.Empty;
                txtAddWTD.Text = string.Empty;
                txtAddSTH.Text = string.Empty;
                txtAddETH.Text = string.Empty;
                Tslot = string.Empty;
            }

        }

        private void RadioBThirtyM_CheckedChanged(object sender, EventArgs e)
        {
            Tslot = "Thirty Minutes";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Tslot = "One Hour";
        }

        private void RadioBTwoH_CheckedChanged(object sender, EventArgs e)
        {
            Tslot = "Two Hour";
        }

        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView5.SelectedRows[0];
            var working = (Working)row.DataBoundItem;
            txtWorkID.Text = working.Working_ID.ToString();
            cmbWUnwd.Text = working.No_worikng_days;
            WUdays = working.Working_days;
            txtWUdays.Text = working.Days;
            cmbWUwtpd.Text = working.Working_Time;
            cmbWUsth.Text = working.Start_Time;
            cmbWUendh.Text = working.End_Time;
            TUslot = working.Time_Slot;




        }

        private void tabPage9_Click(object sender, EventArgs e)
        {
            dataGridView5.DataSource = WorkingRepo.GetAll();
        }

        string WUdays;
        string TUslot;
        private void BtnWUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtWorkID.Text) && !string.IsNullOrEmpty(cmbWUnwd.Text) && !string.IsNullOrEmpty(WUdays) && !string.IsNullOrEmpty(txtWUdays.Text) && !string.IsNullOrEmpty(cmbWUwtpd.Text) && !string.IsNullOrEmpty(cmbWUsth.Text) && !string.IsNullOrEmpty(cmbWUendh.Text) && !string.IsNullOrEmpty(TUslot))
            {
                WorkingRepo.Update(new Working
                {
                    Working_ID = int.Parse(txtWorkID.Text),
                    No_worikng_days = cmbWUnwd.Text,
                    Working_days = WUdays,
                    Days = txtWUdays.Text,
                    Working_Time = cmbWUwtpd.Text,
                    Start_Time = cmbWUsth.Text,
                    End_Time = cmbWUendh.Text,
                    Time_Slot = TUslot,
                });
                dataGridView5.DataSource = WorkingRepo.GetAll();
            }

        }

        private void radioWUthirty_CheckedChanged(object sender, EventArgs e)
        {
            TUslot = "Thirty Minutes";
        }

        private void radioWUhours_CheckedChanged(object sender, EventArgs e)
        {
            TUslot = "One Hour";
        }

        private void radioWUtwohours_CheckedChanged(object sender, EventArgs e)
        {
            TUslot = "Two Hour";
        }

        private void BtnWUDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtWorkID.Text) && !string.IsNullOrEmpty(cmbWUnwd.Text) && !string.IsNullOrEmpty(WUdays) && !string.IsNullOrEmpty(txtWUdays.Text) && !string.IsNullOrEmpty(cmbWUwtpd.Text) && !string.IsNullOrEmpty(cmbWUsth.Text) && !string.IsNullOrEmpty(cmbWUendh.Text) && !string.IsNullOrEmpty(TUslot))
            {
                WorkingRepo.Delete(int.Parse(txtWorkID.Text));
                cmbWUnwd.Text = string.Empty;
                cmbWUnwd.Text = string.Empty;
                txtWUdays.Text = string.Empty;
                cmbWUwtpd.Text = string.Empty;
                cmbWUsth.Text = string.Empty;
                cmbWUendh.Text = string.Empty;
                TUslot = string.Empty;

                dataGridView5.DataSource = WorkingRepo.GetAll();

            }
        }

        private void BtnWURefresh_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioWweekday_CheckedChanged(object sender, EventArgs e)
        {
            Wdays = "Weekday";
        }

        private void radioWweekend_CheckedChanged(object sender, EventArgs e)
        {
            Wdays = "WeekEnd";
        }

        private void radioWdaysend_CheckedChanged(object sender, EventArgs e)
        {
            Wdays = "Weekday and WeekEnd";
        }

        private void radioWUweekday_CheckedChanged(object sender, EventArgs e)
        {
            WUdays = "Weekday";
        }

        private void radioWUweekend_CheckedChanged(object sender, EventArgs e)
        {
            WUdays = "WeekEnd";
        }

        private void radioWUAll_CheckedChanged(object sender, EventArgs e)
        {
            WUdays = "Weekday and WeekEnd";
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_time_table_managementDataSet95.SessionLocations' table. You can move, or remove it, as needed.
            this.sessionLocationsTableAdapter7.Fill(this._time_table_managementDataSet95.SessionLocations);
            // TODO: This line of code loads data into the '_time_table_managementDataSet94.Session' table. You can move, or remove it, as needed.
            this.sessionTableAdapter12.Fill(this._time_table_managementDataSet94.Session);
            // TODO: This line of code loads data into the '_time_table_managementDataSet93.Session' table. You can move, or remove it, as needed.
            this.sessionTableAdapter11.Fill(this._time_table_managementDataSet93.Session);
            // TODO: This line of code loads data into the '_time_table_managementDataSet89.Session' table. You can move, or remove it, as needed.
            this.sessionTableAdapter10.Fill(this._time_table_managementDataSet89.Session);
            // TODO: This line of code loads data into the '_time_table_managementDataSet79.Session' table. You can move, or remove it, as needed.
            //this.sessionTableAdapter9.Fill(this._time_table_managementDataSet79.Session);
            // TODO: This line of code loads data into the '_time_table_managementDataSet78.Working' table. You can move, or remove it, as needed.
            this.workingTableAdapter.Fill(this._time_table_managementDataSet78.Working);
            // TODO: This line of code loads data into the '_time_table_managementDataSet77.Session' table. You can move, or remove it, as needed.
            this.sessionTableAdapter8.Fill(this._time_table_managementDataSet77.Session);
            // TODO: This line of code loads data into the '_time_table_managementDataSet76.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter6.Fill(this._time_table_managementDataSet76.Student);
            // TODO: This line of code loads data into the '_time_table_managementDataSet75.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter5.Fill(this._time_table_managementDataSet75.Student);
            // TODO: This line of code loads data into the '_time_table_managementDataSet74.Session' table. You can move, or remove it, as needed.
            this.sessionTableAdapter7.Fill(this._time_table_managementDataSet74.Session);
            // TODO: This line of code loads data into the '_time_table_managementDataSet73.Tag' table. You can move, or remove it, as needed.
            this.tagTableAdapter2.Fill(this._time_table_managementDataSet73.Tag);
            // TODO: This line of code loads data into the '_time_table_managementDataSet72.Subject' table. You can move, or remove it, as needed.
            this.subjectTableAdapter4.Fill(this._time_table_managementDataSet72.Subject);
            // TODO: This line of code loads data into the '_time_table_managementDataSet71.Subject' table. You can move, or remove it, as needed.
            this.subjectTableAdapter3.Fill(this._time_table_managementDataSet71.Subject);
            // TODO: This line of code loads data into the '_time_table_managementDataSet70.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter4.Fill(this._time_table_managementDataSet70.Student);
            // TODO: This line of code loads data into the '_time_table_managementDataSet69.Teacher' table. You can move, or remove it, as needed.
            this.teacherTableAdapter4.Fill(this._time_table_managementDataSet69.Teacher);
            // TODO: This line of code loads data into the '_time_table_managementDataSet48.Session' table. You can move, or remove it, as needed.
            this.sessionTableAdapter6.Fill(this._time_table_managementDataSet48.Session);
            // TODO: This line of code loads data into the '_time_table_managementDataSet47.Session' table. You can move, or remove it, as needed.
            this.sessionTableAdapter5.Fill(this._time_table_managementDataSet47.Session);
            // TODO: This line of code loads data into the '_time_table_managementDataSet46.Tag' table. You can move, or remove it, as needed.
            this.tagTableAdapter1.Fill(this._time_table_managementDataSet46.Tag);
            // TODO: This line of code loads data into the '_time_table_managementDataSet45.Subject' table. You can move, or remove it, as needed.
            this.subjectTableAdapter2.Fill(this._time_table_managementDataSet45.Subject);
            // TODO: This line of code loads data into the '_time_table_managementDataSet44.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter3.Fill(this._time_table_managementDataSet44.Student);
            // TODO: This line of code loads data into the '_time_table_managementDataSet43.Teacher' table. You can move, or remove it, as needed.
            this.teacherTableAdapter3.Fill(this._time_table_managementDataSet43.Teacher);
            // TODO: This line of code loads data into the '_time_table_managementDataSet42.Session' table. You can move, or remove it, as needed.
            this.sessionTableAdapter4.Fill(this._time_table_managementDataSet42.Session);
            // TODO: This line of code loads data into the '_time_table_managementDataSet41.Session' table. You can move, or remove it, as needed.
            this.sessionTableAdapter3.Fill(this._time_table_managementDataSet41.Session);
            // TODO: This line of code loads data into the '_time_table_managementDataSet40.Subject' table. You can move, or remove it, as needed.
            this.subjectTableAdapter1.Fill(this._time_table_managementDataSet40.Subject);
            // TODO: This line of code loads data into the '_time_table_managementDataSet32.SessionLocations' table. You can move, or remove it, as needed.
            this.sessionLocationsTableAdapter6.Fill(this._time_table_managementDataSet32.SessionLocations);
            // TODO: This line of code loads data into the '_time_table_managementDataSet31.SessionLocations' table. You can move, or remove it, as needed.
            this.sessionLocationsTableAdapter5.Fill(this._time_table_managementDataSet31.SessionLocations);
            // TODO: This line of code loads data into the '_time_table_managementDataSet30.SessionLocations' table. You can move, or remove it, as needed.
            this.sessionLocationsTableAdapter4.Fill(this._time_table_managementDataSet30.SessionLocations);
            // TODO: This line of code loads data into the '_time_table_managementDataSet29.SessionLocations' table. You can move, or remove it, as needed.
            this.sessionLocationsTableAdapter3.Fill(this._time_table_managementDataSet29.SessionLocations);
            // TODO: This line of code loads data into the '_time_table_managementDataSet28.SessionLocations' table. You can move, or remove it, as needed.
            this.sessionLocationsTableAdapter2.Fill(this._time_table_managementDataSet28.SessionLocations);
            // TODO: This line of code loads data into the '_time_table_managementDataSet27.SessionLocations' table. You can move, or remove it, as needed.
            this.sessionLocationsTableAdapter1.Fill(this._time_table_managementDataSet27.SessionLocations);
            // TODO: This line of code loads data into the '_time_table_managementDataSet26.SessionLocations' table. You can move, or remove it, as needed.
            this.sessionLocationsTableAdapter.Fill(this._time_table_managementDataSet26.SessionLocations);
            // TODO: This line of code loads data into the '_time_table_managementDataSet25.Session_Time' table. You can move, or remove it, as needed.
            this.session_TimeTableAdapter3.Fill(this._time_table_managementDataSet25.Session_Time);
            // TODO: This line of code loads data into the '_time_table_managementDataSet24.Not_Available_Group' table. You can move, or remove it, as needed.
            this.not_Available_GroupTableAdapter1.Fill(this._time_table_managementDataSet24.Not_Available_Group);
            // TODO: This line of code loads data into the '_time_table_managementDataSet23.Not_Available_Session' table. You can move, or remove it, as needed.
            this.not_Available_SessionTableAdapter1.Fill(this._time_table_managementDataSet23.Not_Available_Session);
            // TODO: This line of code loads data into the '_time_table_managementDataSet22.Not_Availabale_Lecturer' table. You can move, or remove it, as needed.
            this.not_Availabale_LecturerTableAdapter1.Fill(this._time_table_managementDataSet22.Not_Availabale_Lecturer);
            // TODO: This line of code loads data into the '_time_table_managementDataSet20.Teacher' table. You can move, or remove it, as needed.
            this.teacherTableAdapter2.Fill(this._time_table_managementDataSet20.Teacher);
            // TODO: This line of code loads data into the '_time_table_managementDataSet19.Session' table. You can move, or remove it, as needed.
            this.sessionTableAdapter2.Fill(this._time_table_managementDataSet19.Session);
            // TODO: This line of code loads data into the '_time_table_managementDataSet18.Not_Available_Group' table. You can move, or remove it, as needed.
            this.not_Available_GroupTableAdapter.Fill(this._time_table_managementDataSet18.Not_Available_Group);
            // TODO: This line of code loads data into the '_time_table_managementDataSet17.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter2.Fill(this._time_table_managementDataSet17.Student);
            // TODO: This line of code loads data into the '_time_table_managementDataSet16.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter1.Fill(this._time_table_managementDataSet16.Student);
            // TODO: This line of code loads data into the '_time_table_managementDataSet15.Not_Available_Session' table. You can move, or remove it, as needed.
            this.not_Available_SessionTableAdapter.Fill(this._time_table_managementDataSet15.Not_Available_Session);
            // TODO: This line of code loads data into the '_time_table_managementDataSet14.Session' table. You can move, or remove it, as needed.
            this.sessionTableAdapter1.Fill(this._time_table_managementDataSet14.Session);
            // TODO: This line of code loads data into the '_time_table_managementDataSet13.Not_Availabale_Lecturer' table. You can move, or remove it, as needed.
            this.not_Availabale_LecturerTableAdapter.Fill(this._time_table_managementDataSet13.Not_Availabale_Lecturer);
            // TODO: This line of code loads data into the '_time_table_managementDataSet12.Teacher' table. You can move, or remove it, as needed.
            this.teacherTableAdapter1.Fill(this._time_table_managementDataSet12.Teacher);
            // TODO: This line of code loads data into the '_time_table_managementDataSet11.Session_Time' table. You can move, or remove it, as needed.
            this.session_TimeTableAdapter2.Fill(this._time_table_managementDataSet11.Session_Time);
            DataGridViewCheckBoxColumn chkbox2 = new DataGridViewCheckBoxColumn();
            chkbox2.HeaderText = "";
            chkbox2.Width = 30;
            chkbox2.Name = "checkBoxColumn";
            dataGridView3.Columns.Insert(0, chkbox2);
            // TODO: This line of code loads data into the '_time_table_managementDataSet10.Session_Time' table. You can move, or remove it, as needed.
            this.session_TimeTableAdapter1.Fill(this._time_table_managementDataSet10.Session_Time);
            DataGridViewCheckBoxColumn chkbox1 = new DataGridViewCheckBoxColumn();
            chkbox1.HeaderText = "";
            chkbox1.Width = 30;
            chkbox1.Name = "checkBoxColumn";
            dataGridView2.Columns.Insert(0, chkbox1);
            // TODO: This line of code loads data into the '_time_table_managementDataSet9.Session_Time' table. You can move, or remove it, as needed.
            this.session_TimeTableAdapter.Fill(this._time_table_managementDataSet9.Session_Time);
            DataGridViewCheckBoxColumn chkbox = new DataGridViewCheckBoxColumn();
            chkbox.HeaderText = "";
            chkbox.Width = 30;
            chkbox.Name = "checkBoxColumn";
            dataGridView1.Columns.Insert(0, chkbox);
            // TODO: This line of code loads data into the '_time_table_managementDataSet8.Tag' table. You can move, or remove it, as needed.
            //this.tagTableAdapter1.Fill(this._time_table_managementDataSet8.Tag);
            // TODO: This line of code loads data into the '_time_table_managementDataSet7.Subject' table. You can move, or remove it, as needed.
            //this.subjectTableAdapter1.Fill(this._time_table_managementDataSet7.Subject);
            // TODO: This line of code loads data into the '_time_table_managementDataSet6.Student' table. You can move, or remove it, as needed.
            //this.studentTableAdapter1.Fill(this._time_table_managementDataSet6.Student);
            // TODO: This line of code loads data into the '_time_table_managementDataSet5.Teacher' table. You can move, or remove it, as needed.
            //this.teacherTableAdapter2.Fill(this._time_table_managementDataSet5.Teacher);
            // TODO: This line of code loads data into the '_time_table_managementDataSet4.Teacher' table. You can move, or remove it, as needed.
            //this.teacherTableAdapter1.Fill(this._time_table_managementDataSet4.Teacher);
            // TODO: This line of code loads data into the '_time_table_managementDataSet3.Session' table. You can move, or remove it, as needed.
            //this.sessionTableAdapter.Fill(this._time_table_managementDataSet3.Session);
            // TODO: This line of code loads data into the '_time_table_managementDataSet2.Session' table. You can move, or remove it, as needed.
            //this.sessionTableAdapter.Fill(this._time_table_managementDataSet2.Session);
            // TODO: This line of code loads data into the '_time_table_managementDataSet1.Tag' table. You can move, or remove it, as needed.
            //this.tagTableAdapter.Fill(this._time_table_managementDataSet1.Tag);
            // TODO: This line of code loads data into the '_time_table_managementDataSet.Subject' table. You can move, or remove it, as needed.
            //this.subjectTableAdapter.Fill(this._time_table_managementDataSet.Subject);
            // TODO: This line of code loads data into the 'timeDataSet1.Student' table. You can move, or remove it, as needed.
            //this.studentTableAdapter.Fill(this.timeDataSet1.Student);
            // TODO: This line of code loads data into the 'timeDataSet.Teacher' table. You can move, or remove it, as needed.
            //this.teacherTableAdapter.Fill(this.timeDataSet.Teacher);
            try
            {
                con.Open();
                SqlCommand sc = new SqlCommand("select (Lecturer_name) from Teacher", con);
                SqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Lecturer_name", typeof(string));
                dt.Load(reader);
                comboBox24.ValueMember = "Lecturer_name";
                comboBox24.DataSource = dt;

                reader = sc.ExecuteReader();
                DataTable ct = new DataTable();
                ct.Columns.Add("Lecturer_name", typeof(string));
                ct.Load(reader);
                upcomboBox28.ValueMember = "Lecturer_name";
                upcomboBox28.DataSource = ct;

                con.Close();
            }
            catch (Exception)
            {

            }
        }

        private void comboBox24_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBox24.Text) && !string.IsNullOrEmpty(comboBox26.Text) && !string.IsNullOrEmpty(comboBox22.Text) && !string.IsNullOrEmpty(comboBox21.Text) && !string.IsNullOrEmpty(comboBox1.Text) && !string.IsNullOrEmpty(comboBox23.Text) && !string.IsNullOrEmpty(comboBox20.Text) && !string.IsNullOrEmpty(comboBox19.Text))
            {
                SessionRepo.Add(new Session
                {
                    Lecture1 = comboBox24.Text,
                    Lecture2 = comboBox26.Text,
                    Group_ID = comboBox22.Text,
                    Subject_ID = comboBox21.Text,
                    Subject_Name = comboBox1.Text,
                    Tag = comboBox23.Text,
                    Noofstudent = comboBox20.Text,
                    Duration = comboBox19.Text

                });
                comboBox24.Text = string.Empty;
                comboBox26.Text = string.Empty;
                comboBox22.Text = string.Empty;
                comboBox21.Text = string.Empty;
                comboBox1.Text = string.Empty;
                comboBox23.Text = string.Empty;
                comboBox20.Text = string.Empty;
                comboBox19.Text = string.Empty;
                dataGridView6.DataSource = SessionRepo.GetAll();
            }
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {
            dataGridView4.DataSource = SessionRepo.GetAll();
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView4.SelectedRows.Count > 0)
            {
                var row = dataGridView4.SelectedRows[0];
                var Session = (Session)row.DataBoundItem;
                txtSessionid.Text = Session.Session_ID.ToString();
                upcomboBox28.Text = Session.Lecture1;
                upcomboBox27.Text = Session.Lecture2;
                upcomboBox32.Text = Session.Group_ID;
                upcomboBox31.Text = Session.Subject_ID;
                comboBox2.Text = Session.Subject_Name;
                upcomboBox33.Text = Session.Tag;
                upcomboBox30.Text = Session.Noofstudent;
                upcomboBox29.Text = Session.Duration;

            }
        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void label52_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void consecutivebtnSave_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["TimeTable.Properties.Settings.TimeConnectionString"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);

            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                bool chkboxselected = Convert.ToBoolean(dr.Cells["checkBoxColumn"].Value);
                if (chkboxselected)
                {
                    string sqlquery = "Insert into [dbo].[Session_Consecutive] values(@Lecturer_Name_1,@Lecturer_Name_2,@Subject_Code,@Subject_Name,@Group_ID,@Tag,@Room,@Day,@Start_Time,@End_Time)";
                    SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
                    sqlcomm.Parameters.AddWithValue("@Lecturer_Name_1", dr.Cells[2].Value);
                    sqlcomm.Parameters.AddWithValue("@Lecturer_Name_2", dr.Cells[3].Value);
                    sqlcomm.Parameters.AddWithValue("@Subject_Code", dr.Cells[4].Value);
                    sqlcomm.Parameters.AddWithValue("@Subject_Name", dr.Cells[5].Value);
                    sqlcomm.Parameters.AddWithValue("@Group_ID", dr.Cells[6].Value);
                    sqlcomm.Parameters.AddWithValue("@Tag", dr.Cells[7].Value);
                    sqlcomm.Parameters.AddWithValue("@Room", dr.Cells[8].Value);
                    sqlcomm.Parameters.AddWithValue("@Day", dr.Cells[9].Value);
                    sqlcomm.Parameters.AddWithValue("@Start_Time", dr.Cells[10].Value);
                    sqlcomm.Parameters.AddWithValue("@End_Time", dr.Cells[11].Value);
                    sqlconn.Open();
                    sqlcomm.ExecuteNonQuery();
                    sqlconn.Close();
                }


            }
            MessageBox.Show("Selected Records Inserted Successfully !!!");
        }

        private void consecutivebtnView_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection("Server=tcp:time-table.database.windows.net,1433;Initial Catalog=time-table-management;Persist Security Info=False;User ID=nipun;Password=lakshan123@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            sc.Open();
            SqlDataAdapter sd = new SqlDataAdapter("select * from Session_Consecutive", sc);
            DataSet ds = new DataSet();
            sd.Fill(ds, "Session_Consecutive");
            dataGridView1.DataSource = ds.Tables[0];

            sc.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection("Server=tcp:time-table.database.windows.net,1433;Initial Catalog=time-table-management;Persist Security Info=False;User ID=nipun;Password=lakshan123@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            sc.Open();
            SqlDataAdapter sd = new SqlDataAdapter("select * from Session_Time", sc);
            DataSet ds = new DataSet();
            sd.Fill(ds, "Session_Time");
            dataGridView1.DataSource = ds.Tables[0];

            sc.Close();
        }

        private void parallelbtnSave_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["TimeTable.Properties.Settings.TimeConnectionString"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);

            foreach (DataGridViewRow dr in dataGridView2.Rows)
            {
                bool chkboxselected = Convert.ToBoolean(dr.Cells["checkBoxColumn"].Value);
                if (chkboxselected)
                {
                    string sqlquery = "Insert into [dbo].[Session_Parallel] values(@Lecturer_Name_1,@Lecturer_Name_2,@Subject_Code,@Subject_Name,@Group_ID,@Tag,@Room,@Day,@Start_Time,@End_Time)";
                    SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
                    sqlcomm.Parameters.AddWithValue("@Lecturer_Name_1", dr.Cells[2].Value);
                    sqlcomm.Parameters.AddWithValue("@Lecturer_Name_2", dr.Cells[3].Value);
                    sqlcomm.Parameters.AddWithValue("@Subject_Code", dr.Cells[4].Value);
                    sqlcomm.Parameters.AddWithValue("@Subject_Name", dr.Cells[5].Value);
                    sqlcomm.Parameters.AddWithValue("@Group_ID", dr.Cells[6].Value);
                    sqlcomm.Parameters.AddWithValue("@Tag", dr.Cells[7].Value);
                    sqlcomm.Parameters.AddWithValue("@Room", dr.Cells[8].Value);
                    sqlcomm.Parameters.AddWithValue("@Day", dr.Cells[9].Value);
                    sqlcomm.Parameters.AddWithValue("@Start_Time", dr.Cells[10].Value);
                    sqlcomm.Parameters.AddWithValue("@End_Time", dr.Cells[11].Value);
                    sqlconn.Open();
                    sqlcomm.ExecuteNonQuery();
                    sqlconn.Close();

                }

            }
            MessageBox.Show("Selected Records Inserted Successfully !!!");
        }

        private void parallelbtnView_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection("Server=tcp:time-table.database.windows.net,1433;Initial Catalog=time-table-management;Persist Security Info=False;User ID=nipun;Password=lakshan123@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            sc.Open();
            SqlDataAdapter sd = new SqlDataAdapter("select * from Session_Parallel", sc);
            DataSet ds = new DataSet();
            sd.Fill(ds, "Session_Parallel");
            dataGridView2.DataSource = ds.Tables[0];

            sc.Close();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection("Server=tcp:time-table.database.windows.net,1433;Initial Catalog=time-table-management;Persist Security Info=False;User ID=nipun;Password=lakshan123@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            sc.Open();
            SqlDataAdapter sd = new SqlDataAdapter("select * from Session_Time", sc);
            DataSet ds = new DataSet();
            sd.Fill(ds, "Session_Time");
            dataGridView2.DataSource = ds.Tables[0];

            sc.Close();
        }

        private void nonoverlappingbtnAdd_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["TimeTable.Properties.Settings.TimeConnectionString"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);

            foreach (DataGridViewRow dr in dataGridView3.Rows)
            {
                bool chkboxselected = Convert.ToBoolean(dr.Cells["checkBoxColumn"].Value);
                if (chkboxselected)
                {
                    string sqlquery = "Insert into [dbo].[Session_Nonoverlapping] values(@Lecturer_Name_1,@Lecturer_Name_2,@Subject_Code,@Subject_Name,@Group_ID,@Tag,@Room,@Day,@Start_Time,@End_Time)";
                    SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
                    sqlcomm.Parameters.AddWithValue("@Lecturer_Name_1", dr.Cells[2].Value);
                    sqlcomm.Parameters.AddWithValue("@Lecturer_Name_2", dr.Cells[3].Value);
                    sqlcomm.Parameters.AddWithValue("@Subject_Code", dr.Cells[4].Value);
                    sqlcomm.Parameters.AddWithValue("@Subject_Name", dr.Cells[5].Value);
                    sqlcomm.Parameters.AddWithValue("@Group_ID", dr.Cells[6].Value);
                    sqlcomm.Parameters.AddWithValue("@Tag", dr.Cells[7].Value);
                    sqlcomm.Parameters.AddWithValue("@Room", dr.Cells[8].Value);
                    sqlcomm.Parameters.AddWithValue("@Day", dr.Cells[9].Value);
                    sqlcomm.Parameters.AddWithValue("@Start_Time", dr.Cells[10].Value);
                    sqlcomm.Parameters.AddWithValue("@End_Time", dr.Cells[11].Value);
                    sqlconn.Open();
                    sqlcomm.ExecuteNonQuery();
                    sqlconn.Close();
                }

            }
            MessageBox.Show("Selected Records Inserted Successfully !!!");
        }

        private void nonoverlappingbtnView_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection("Server=tcp:time-table.database.windows.net,1433;Initial Catalog=time-table-management;Persist Security Info=False;User ID=nipun;Password=lakshan123@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            sc.Open();
            SqlDataAdapter sd = new SqlDataAdapter("select * from Session_Nonoverlapping", sc);
            DataSet ds = new DataSet();
            sd.Fill(ds, "Session_Nonoverlapping");
            dataGridView3.DataSource = ds.Tables[0];

            sc.Close();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection("Server=tcp:time-table.database.windows.net,1433;Initial Catalog=time-table-management;Persist Security Info=False;User ID=nipun;Password=lakshan123@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            sc.Open();
            SqlDataAdapter sd = new SqlDataAdapter("select * from Session_Time", sc);
            DataSet ds = new DataSet();
            sd.Fill(ds, "Session_Time");
            dataGridView3.DataSource = ds.Tables[0];

            sc.Close();
        }

        private void NATLecturerADD_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NATLecturerName.Text) && !string.IsNullOrEmpty(NATLDay.Text) && !string.IsNullOrEmpty(NATLSTime.Text) && !string.IsNullOrEmpty(NATLETime.Text))
            {
                NotAvailableLecturerRepo.Add(new NotAvailableLecturer
                {
                    Lecturer_Name = NATLecturerName.Text,
                    Day = NATLDay.Text,
                    Start_Time = NATLSTime.Text,
                    End_Time = NATLETime.Text,
                });
                NATLecturerName.Text = string.Empty;
                NATLDay.Text = string.Empty;
                NATLSTime.Text = string.Empty;
                NATLETime.Text = string.Empty;
                dataGridView7.DataSource = NotAvailableLecturerRepo.GetAll();

            }
        }

        private void LECTURER_Click(object sender, EventArgs e)
        {
            dataGridView7.DataSource = NotAvailableLecturerRepo.GetAll();
        }

        private void NATSADD_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NATSessionID.Text) && !string.IsNullOrEmpty(NATSessionDay.Text) && !string.IsNullOrEmpty(NATSessionSTime.Text) && !string.IsNullOrEmpty(NATSessionETime.Text))
            {
                NotAvailableSessionRepo.Add(new NotAvailableSession
                {
                    Session_ID = NATSessionID.Text,
                    Day = NATSessionDay.Text,
                    Start_Time = NATSessionSTime.Text,
                    End_Time = NATSessionETime.Text,
                });
                NATSessionID.Text = string.Empty;
                NATSessionDay.Text = string.Empty;
                NATSessionSTime.Text = string.Empty;
                NATSessionETime.Text = string.Empty;
                dataGridView8.DataSource = NotAvailableSessionRepo.GetAll();

            }
        }

        private void SESSION_Click(object sender, EventArgs e)
        {
            dataGridView8.DataSource = NotAvailableSessionRepo.GetAll();
        }

        private void NATGroupADD_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NAMGroup.Text) || !string.IsNullOrEmpty(NASGroup.Text) && !string.IsNullOrEmpty(NAGroupDay.Text) && !string.IsNullOrEmpty(NAGroupSTime.Text) && !string.IsNullOrEmpty(NAGroupETime.Text))
            {
                NotAvailableGroupRepo.Add(new NotAvailableGroup
                {
                    Main_Group = NAMGroup.Text,
                    Sub_Group = NASGroup.Text,
                    Day = NAGroupDay.Text,
                    Start_Time = NAGroupSTime.Text,
                    End_Time = NAGroupETime.Text,
                });
                NAMGroup.Text = string.Empty;
                NASGroup.Text = string.Empty;
                NAGroupDay.Text = string.Empty;
                NAGroupSTime.Text = string.Empty;
                NAGroupETime.Text = string.Empty;
                dataGridView9.DataSource = NotAvailableGroupRepo.GetAll();

            }
        }

        private void tabPage10_Click(object sender, EventArgs e)
        {
            dataGridView9.DataSource = NotAvailableGroupRepo.GetAll();

        }

        private void tabPage11_Click(object sender, EventArgs e)
        {
            dataGridView10.DataSource = SessionDayTimeRepo.GetAll();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click_1(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click_1(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label54_Click(object sender, EventArgs e)
        {

        }

        private void label53_Click(object sender, EventArgs e)
        {

        }

        private void label55_Click(object sender, EventArgs e)
        {

        }

        private void STimeSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SeLecturer1.Text) || !string.IsNullOrEmpty(SeLecturer2.Text) && !string.IsNullOrEmpty(SSubCode.Text) && !string.IsNullOrEmpty(SSubName.Text) && !string.IsNullOrEmpty(SGroupID.Text) && !string.IsNullOrEmpty(SeTag.Text) && !string.IsNullOrEmpty(SeRoom.Text) && !string.IsNullOrEmpty(SessionDay.Text) && !string.IsNullOrEmpty(SessionSTime.Text) && !string.IsNullOrEmpty(SessionETime.Text))
            {
                SessionDayTimeRepo.Add(new SessionDayTime
                {
                    Lecturer_Name_1 = SeLecturer1.Text,
                    Lecturer_Name_2 = SeLecturer2.Text,
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
                dataGridView10.DataSource = SessionDayTimeRepo.GetAll();

            }
        }

        private void SessionID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = @"Server=tcp:time-table.database.windows.net,1433;Initial Catalog=time-table-management;Persist Security Info=False;User ID=nipun;Password=lakshan123@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection con = new SqlConnection(str);

            try
            {
                con.Open();

                string query = "SELECT * FROM SessionLocations WHERE ID = '" + SessionID.Text + "'";
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
                    SGroupID.Text = reader["Group_ID"].ToString();
                    SeTag.Text = reader["Tag"].ToString();
                    SeRoom.Text = reader["Room"].ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void label56_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSessionid.Text) && !string.IsNullOrEmpty(upcomboBox28.Text) && !string.IsNullOrEmpty(upcomboBox27.Text) && !string.IsNullOrEmpty(upcomboBox32.Text) && !string.IsNullOrEmpty(upcomboBox31.Text) && !string.IsNullOrEmpty(upcomboBox33.Text) && !string.IsNullOrEmpty(upcomboBox30.Text) && !string.IsNullOrEmpty(upcomboBox29.Text))
            {
                SessionRepo.Update(new Session
                {
                    Session_ID = int.Parse(txtSessionid.Text),
                    Lecture1 = upcomboBox28.Text,
                    Lecture2 = upcomboBox27.Text,
                    Group_ID = upcomboBox32.Text,
                    Subject_ID = upcomboBox31.Text,
                    Subject_Name = comboBox2.Text,
                    Tag = upcomboBox33.Text,
                    Noofstudent = upcomboBox30.Text,
                    Duration = upcomboBox29.Text,

                });
                dataGridView4.DataSource = SessionRepo.GetAll();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSessionid.Text) && !string.IsNullOrEmpty(upcomboBox28.Text) && !string.IsNullOrEmpty(upcomboBox27.Text) && !string.IsNullOrEmpty(upcomboBox32.Text) && !string.IsNullOrEmpty(upcomboBox31.Text) && !string.IsNullOrEmpty(upcomboBox33.Text) && !string.IsNullOrEmpty(upcomboBox30.Text) && !string.IsNullOrEmpty(upcomboBox29.Text))
            {
                SessionRepo.Delete(int.Parse(txtSessionid.Text));
                upcomboBox28.Text = string.Empty;
                upcomboBox27.Text = string.Empty;
                upcomboBox32.Text = string.Empty;
                upcomboBox31.Text = string.Empty;
                comboBox2.Text = string.Empty;
                upcomboBox33.Text = string.Empty;
                upcomboBox30.Text = string.Empty;
                upcomboBox29.Text = string.Empty;

                dataGridView4.DataSource = SessionRepo.GetAll();

            }
        }
    }
}

