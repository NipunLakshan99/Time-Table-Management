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
            if (!string.IsNullOrEmpty(txtAddNWD.Text) && !string.IsNullOrEmpty(Tslot) && !string.IsNullOrEmpty(txtAddWTD.Text) && !string.IsNullOrEmpty(txtAddSTH.Text) && !string.IsNullOrEmpty(txtAddETH.Text) && !string.IsNullOrEmpty(Wdays))
            {
                WorkingRepo.Add(new Working
                {
                    No_worikng_days = txtAddNWD.Text,
                    Working_days = Tslot,
                    Working_Time = txtAddWTD.Text,
                    Start_Time = txtAddSTH.Text,
                    End_Time = txtAddETH.Text,
                    Time_Slot = Tslot,
                });
                txtAddNWD.Text = string.Empty;
                Wdays = string.Empty;
                txtAddWTD.Text = string.Empty;
                txtAddSTH.Text = string.Empty;
                txtAddETH.Text = string.Empty;
                Tslot = string.Empty;
                dataGridView5.DataSource = WorkingRepo.GetAll();
            }
        }

        private void chkMonday_CheckedChanged(object sender, EventArgs e)
        {
            Wdays = "Monday";
        }

        private void chkTuesday_CheckedChanged(object sender, EventArgs e)
        {
            Wdays = "Tuesday";
        }

        private void chkWednesday_CheckedChanged(object sender, EventArgs e)
        {
            Wdays = "Wednesday";
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            Wdays = "Thursday";
        }

        private void chkFriday_CheckedChanged(object sender, EventArgs e)
        {
            Wdays = "Friday";
        }
        private void chkSaturday_CheckedChanged(object sender, EventArgs e)
        {
            Wdays = "Saturday";
        }

        private void chkSunday_CheckedChanged(object sender, EventArgs e)
        {
            Wdays = "Sunday";
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
            if(dataGridView5.SelectedRows.Count > 0)
            {
                var row = dataGridView5.SelectedRows[0];
                var working = (Working)row.DataBoundItem;
                //txtWorkID.Text = working.Working_ID;
                txtAddWTD.Text = working.No_worikng_days;
                Wdays = working.Working_days;
                txtAddSTH.Text = working.Working_Time;
                txtAddETH.Text = working.End_Time;
                Tslot = working.Time_Slot;

            }
        }

        private void tabPage9_Click(object sender, EventArgs e)
        {
            dataGridView5.DataSource = WorkingRepo.GetAll();
        }

        string WUdays;
        string TUslot;
        private void BtnWUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtWorkID.Text) && !string.IsNullOrEmpty(cmbWUnwd.Text) && !string.IsNullOrEmpty(WUdays) && !string.IsNullOrEmpty(cmbWUwtpd.Text) && !string.IsNullOrEmpty(cmbWUsth.Text) && !string.IsNullOrEmpty(cmbWUendh.Text) && !string.IsNullOrEmpty(TUslot))
            {
                WorkingRepo.Update(new Working
                {
                    Working_ID = int.Parse(txtWorkID.Text),
                    No_worikng_days = cmbWUnwd.Text,
                    Working_days = WUdays,
                    Working_Time = cmbWUwtpd.Text,
                    Start_Time = cmbWUsth.Text,
                    End_Time = cmbWUendh.Text,
                    Time_Slot = TUslot,

                });
                dataGridView5.DataSource = WorkingRepo.GetAll();
            }
        }

        private void CheckWUmon_CheckedChanged(object sender, EventArgs e)
        {
            WUdays = "Monday";
        }

        private void CheckWUtues_CheckedChanged(object sender, EventArgs e)
        {
            WUdays = "Tuesday";
        }

        private void CheckWUwed_CheckedChanged(object sender, EventArgs e)
        {
            WUdays = "Wednesday";
        }

        private void CheckWUthur_CheckedChanged(object sender, EventArgs e)
        {
            WUdays = "Thursday";
        }

        private void CheckWUfri_CheckedChanged(object sender, EventArgs e)
        {
            WUdays = "Friday";
        }

        private void CheckWUsatu_CheckedChanged(object sender, EventArgs e)
        {
            WUdays = "Saturday";
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            WUdays = "Sunday";
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
            if (!string.IsNullOrEmpty(cmbWUnwd.Text) && !string.IsNullOrEmpty(WUdays) && !string.IsNullOrEmpty(cmbWUwtpd.Text) && !string.IsNullOrEmpty(cmbWUsth.Text) && !string.IsNullOrEmpty(cmbWUendh.Text) && !string.IsNullOrEmpty(TUslot))
            {
                WorkingRepo.Delete(int.Parse(txtWorkID.Text));
                cmbWUnwd.Text = string.Empty;
                WUdays = string.Empty;
                cmbWUwtpd.Text = string.Empty;
                cmbWUsth.Text = string.Empty;
                cmbWUendh.Text = string.Empty;
                TUslot = string.Empty;

            }
        }

        private void BtnWURefresh_Click(object sender, EventArgs e)
        {
            cmbWUnwd.Text = string.Empty;
            WUdays = string.Empty;
            cmbWUwtpd.Text = string.Empty;
            cmbWUsth.Text = string.Empty;
            cmbWUendh.Text = string.Empty;
            TUslot = string.Empty;
        }
    }
}
