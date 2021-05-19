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

namespace TimeTable
{
    public partial class Form5 : Form
    {
        WorkingRepo WorkingRepo = new WorkingRepo();
        SessionRepo SessionRepo = new SessionRepo();
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
            if(!string.IsNullOrEmpty(txtAddNWD.Text) && !string.IsNullOrEmpty(Wdays) && !string.IsNullOrEmpty(txtDays.Text) && !string.IsNullOrEmpty(txtAddWTD.Text) && !string.IsNullOrEmpty(txtAddSTH.Text) && !string.IsNullOrEmpty(txtAddETH.Text) && !string.IsNullOrEmpty(Tslot))
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
            if (!string.IsNullOrEmpty(comboBox24.Text) && !string.IsNullOrEmpty(comboBox26.Text) && !string.IsNullOrEmpty(comboBox22.Text) && !string.IsNullOrEmpty(comboBox21.Text) && !string.IsNullOrEmpty(comboBox23.Text) && !string.IsNullOrEmpty(comboBox20.Text) && !string.IsNullOrEmpty(comboBox19.Text))
            {
                SessionRepo.Add(new Session
                {
                    Lecture1 = comboBox24.Text,
                    Lecture2 = comboBox26.Text,
                    Group_ID = comboBox22.Text,
                    Subject = comboBox21.Text,
                    Tag = comboBox23.Text,
                    Noofstudent = comboBox20.Text,
                    Duration = comboBox19.Text

                });
                comboBox24.Text = string.Empty;
                comboBox26.Text = string.Empty;
                comboBox22.Text = string.Empty;
                comboBox21.Text = string.Empty;
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
                var session = (Session)row.DataBoundItem;

            }
        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void label52_Click(object sender, EventArgs e)
        {

        }
    }
}

