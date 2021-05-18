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
    public partial class Form5 : Form
    {
        WorkingRepo WorkingRepo = new WorkingRepo();
        NotAvailableLecturerRepo NotAvailableLecturerRepo = new NotAvailableLecturerRepo();
        NotAvailableSessionRepo NotAvailableSessionRepo = new NotAvailableSessionRepo();
        NotAvailableGroupRepo NotAvailableGroupRepo = new NotAvailableGroupRepo();

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

        private void txtAddSTH_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddNWD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbWUnwd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label49_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void comboBox26_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                dataGridView7.DataSource = NotAvailableSessionRepo.GetAll();
                
            }
        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView7.SelectedRows[0];
            var NASession = (NotAvailableSession)row.DataBoundItem;
            NATSessionID.Text = NASession.Session_ID;
            NATSessionDay.Text = NASession.Day;
            NATSessionSTime.Text = NASession.Start_Time;
            NATSessionETime.Text = NASession.End_Time;
        }

        private void label54_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

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
                dataGridView6.DataSource = NotAvailableLecturerRepo.GetAll();

            }
        }

        private void tabPage10_Click(object sender, EventArgs e)
        {
            dataGridView6.DataSource = NotAvailableLecturerRepo.GetAll();
        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView6.SelectedRows[0];
            var NALecturer = (NotAvailableLecturer)row.DataBoundItem;
            NATLecturerName.Text = NALecturer.Lecturer_Name;
            NATLDay.Text = NALecturer.Day;
            NATLSTime.Text = NALecturer.Start_Time;
            NATLETime.Text = NALecturer.End_Time;
        }

        private void tabPage11_Click(object sender, EventArgs e)
        {
            dataGridView7.DataSource = NotAvailableSessionRepo.GetAll();
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
                dataGridView8.DataSource = NotAvailableGroupRepo.GetAll();

            }
        }

        private void dataGridView8_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView8.SelectedRows[0];
            var NAGroup = (NotAvailableGroup)row.DataBoundItem;
            NAMGroup.Text = NAGroup.Main_Group;
            NASGroup.Text = NAGroup.Sub_Group;
            NAGroupDay.Text = NAGroup.Day;
            NAGroupSTime.Text = NAGroup.Start_Time;
            NAGroupETime.Text = NAGroup.End_Time;
        }

        private void tabPage12_Click(object sender, EventArgs e)
        {
            dataGridView8.DataSource = NotAvailableGroupRepo.GetAll();
        }
    }
}
