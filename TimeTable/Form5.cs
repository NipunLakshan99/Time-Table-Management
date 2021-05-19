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

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {


        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_time_table_managementDataSet2.Session_Time' table. You can move, or remove it, as needed.
            this.session_TimeTableAdapter2.Fill(this._time_table_managementDataSet2.Session_Time);
            DataGridViewCheckBoxColumn chkbox2 = new DataGridViewCheckBoxColumn();
            chkbox2.HeaderText = "";
            chkbox2.Width = 30;
            chkbox2.Name = "checkBoxColumn";
            dataGridView3.Columns.Insert(0, chkbox2);
            // TODO: This line of code loads data into the '_time_table_managementDataSet1.Session_Time' table. You can move, or remove it, as needed.
            this.session_TimeTableAdapter1.Fill(this._time_table_managementDataSet1.Session_Time);
            DataGridViewCheckBoxColumn chkbox1 = new DataGridViewCheckBoxColumn();
            chkbox1.HeaderText = "";
            chkbox1.Width = 30;
            chkbox1.Name = "checkBoxColumn";
            dataGridView2.Columns.Insert(0, chkbox1);
            // TODO: This line of code loads data into the '_time_table_managementDataSet.Session_Time' table. You can move, or remove it, as needed.
            this.session_TimeTableAdapter.Fill(this._time_table_managementDataSet.Session_Time);
            DataGridViewCheckBoxColumn chkbox  = new DataGridViewCheckBoxColumn();
            chkbox.HeaderText = "";
            chkbox.Width = 30;
            chkbox.Name = "checkBoxColumn";
            dataGridView1.Columns.Insert(0, chkbox);
  

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

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection("Server=tcp:time-table.database.windows.net,1433;Initial Catalog=time-table-management;Persist Security Info=False;User ID=nipun;Password=lakshan123@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            sc.Open();
            SqlDataAdapter sd = new SqlDataAdapter("select * from Session_Consecutive", sc);
            DataSet ds = new DataSet();
            sd.Fill(ds, "Session_Consecutive");
            dataGridView1.DataSource = ds.Tables[0];

            sc.Close();
        }

        private void consecutivebtnSave_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["TimeTable.Properties.Settings.TimeTableManagementConnectionString"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);

            foreach (DataGridViewRow dr in dataGridView1.Rows) 
            {
                bool chkboxselected = Convert.ToBoolean(dr.Cells["checkBoxColumn"].Value);
                if (chkboxselected)
                { 
                    string sqlquery = "Insert into [dbo].[Session_Consecutive] values(@Lecturer_Name_1,@Lecturer_Name_2,@Subject_Code,@Subject_Name,@Group_ID,@Tag,@Room,@Day,@Start_Time,@End_Time)";
                    SqlCommand sqlcomm = new SqlCommand(sqlquery,sqlconn);
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

        private void parallelbtnSave_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["TimeTable.Properties.Settings.TimeTableManagementConnectionString"].ConnectionString;
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

        private void nonoverlappingbtnAdd_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["TimeTable.Properties.Settings.TimeTableManagementConnectionString"].ConnectionString;
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
    }
}
