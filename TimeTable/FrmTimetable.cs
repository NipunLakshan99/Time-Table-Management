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
    public partial class FrmTimetable : Form
    {
        public int hr = 8;
        public int min = 30;
        public int sec = 0;
        SqlConnection con = new SqlConnection("Server=tcp:time-table.database.windows.net,1433;Initial Catalog=time-table-management;Persist Security Info=False;User ID=nipun;Password=lakshan123@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public FrmTimetable()
        {
            InitializeComponent();
        }

        private void FrmTimetable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_time_table_managementDataSet88.Location' table. You can move, or remove it, as needed.
            this.locationTableAdapter.Fill(this._time_table_managementDataSet88.Location);
            // TODO: This line of code loads data into the '_time_table_managementDataSet87.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this._time_table_managementDataSet87.Student);
            // TODO: This line of code loads data into the '_time_table_managementDataSet86.Teacher' table. You can move, or remove it, as needed.
            this.teacherTableAdapter.Fill(this._time_table_managementDataSet86.Teacher);

        }
        private void timeCalc(int hr1, int min1, int sec1)
        {

            sec += sec1;

            if (sec > 60)
            {
                min++;
                sec -= 60;
            }

            min += min1;

            if (min > 60)
            {
                hr++;
                min -= 60;
            }

            hr += hr1;
        }

        private void viewTbtn_Click(object sender, EventArgs e)
        {
            hr = 8;
            min = 30;
            sec = 0;

            
            SqlCommand cmd = new SqlCommand("select Subject_name,Group_ID,Subject_ID,Tag,Duration,'1' from Session where Lecture1 LIKE '%" + comboBox1.Text + "%'", con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);

            con.Close();

            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].Name = "";
            dataGridView1.Columns[1].Name = "Monday";
            dataGridView1.Columns[2].Name = "Tuesday";
            dataGridView1.Columns[3].Name = "Wednesday";
            dataGridView1.Columns[4].Name = "Thursday";
            dataGridView1.Columns[5].Name = "Friday";
            dataGridView1.Columns[6].Name = "Saturday";
            dataGridView1.Columns[7].Name = "Sunday";

            System.IO.StringWriter sw;
            string output;
            int xCount = 1;
            int yCount = 0;
            string[,] Tablero = new string[5, 8];


            for (int k = 0; k < Tablero.GetLength(0); k++)
            {
                for (int l = 0; l < Tablero.GetLength(1); l++)
                {
                    Tablero[k, l] = " --- ";
                }
            }

            // Loop through each row in the table.
            foreach (DataRow row in dt.Rows)
            {
                sw = new System.IO.StringWriter();

                // Loop through each column.
                foreach (DataColumn col in dt.Columns)
                {
                    // Output the value of each column's data.
                    sw.Write(row[col].ToString() + "\n");
                }

                output = sw.ToString();

                // Trim off the trailing ", ", so the output looks correct.
                if (output.Length > 2)
                    output = output.Substring(0, output.Length - 2);


                if (yCount == 5)
                {
                    yCount = 0;
                    xCount++;
                }
                try
                {

                    Tablero[yCount, xCount] = output;
                    yCount++;
                }
                catch (Exception ex)
                {
                }
            }

            do
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    try
                    {
                        dataGridView1.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            } while (dataGridView1.Rows.Count > 1);


            for (int k = 0; k < Tablero.GetLength(0); k++)
            {
                var arlist1 = new System.Collections.ArrayList();

                for (int l = 0; l < Tablero.GetLength(1); l++)
                {
                    arlist1.Add(Tablero[k, l]);
                }

                string srrr = (string)arlist1[1];
                string srrr2 = srrr.Substring(srrr.Length - 2);

                string[] row = new string[] {
                    hr + "." + min,
                    (string) arlist1[1],
                    (string) arlist1[2],
                    (string) arlist1[3],
                    (string) arlist1[4],
                    (string) arlist1[5],
                    (string) arlist1[6],
                    (string) arlist1[7]
                };

                try
                {
                    timeCalc(int.Parse(srrr2.Trim()), 0, 0);
                }
                catch (Exception ex)
                {

                }

                dataGridView1.Rows.Add(row);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hr = 8;
            min = 30;
            sec = 0;

            String query1 = "select Lecture1,Subject_Name,Subject_ID,Tag,Duration,'1' from Session where Group_ID LIKE '%" + comboBox2.Text + "%'";

            SqlCommand cmd = new SqlCommand(query1, con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);

            con.Close();

            dataGridView2.ColumnCount = 8;
            dataGridView2.Columns[0].Name = "";
            dataGridView2.Columns[1].Name = "Monday";
            dataGridView2.Columns[2].Name = "Tuesday";
            dataGridView2.Columns[3].Name = "Wednesday";
            dataGridView2.Columns[4].Name = "Thursday";
            dataGridView2.Columns[5].Name = "Friday";
            dataGridView2.Columns[6].Name = "Saturday";
            dataGridView2.Columns[7].Name = "Sunday";

            System.IO.StringWriter sw;
            string output;
            int xCount = 1;
            int yCount = 0;
            string[,] Tablero = new string[5, 8];


            for (int k = 0; k < Tablero.GetLength(0); k++)
            {
                for (int l = 0; l < Tablero.GetLength(1); l++)
                {
                    Tablero[k, l] = " --- ";
                }
            }

            // Loop through each row in the table.
            foreach (DataRow row in dt.Rows)
            {
                sw = new System.IO.StringWriter();

                // Loop through each column.
                foreach (DataColumn col in dt.Columns)
                {
                    // Output the value of each column's data.
                    sw.Write(row[col].ToString() + "\n");
                }

                output = sw.ToString();

                // Trim off the trailing ", ", so the output looks correct.
                if (output.Length > 2)
                    output = output.Substring(0, output.Length - 2);


                if (yCount == 5)
                {
                    yCount = 0;
                    xCount++;
                }
                try
                {

                    Tablero[yCount, xCount] = output;
                    yCount++;
                }
                catch (Exception ex)
                {
                }
            }

            do
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    try
                    {
                        dataGridView2.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            } while (dataGridView2.Rows.Count > 1);


            for (int k = 0; k < Tablero.GetLength(0); k++)
            {
                var arlist1 = new System.Collections.ArrayList();

                for (int l = 0; l < Tablero.GetLength(1); l++)
                {
                    arlist1.Add(Tablero[k, l]);
                }

                string srrr = (string)arlist1[1];
                string srrr2 = srrr.Substring(srrr.Length - 2);

                string[] row = new string[] {
                    hr + "." + min,
                    (string) arlist1[1],
                    (string) arlist1[2],
                    (string) arlist1[3],
                    (string) arlist1[4],
                    (string) arlist1[5],
                    (string) arlist1[6],
                    (string) arlist1[7]
                };

                try
                {
                    timeCalc(int.Parse(srrr2.Trim()), 0, 0);
                }
                catch (Exception ex)
                {
                }

                dataGridView2.Rows.Add(row);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hr = 8;
            min = 30;
            sec = 0;

            String query1 = "select Lecturer_1,Subject_Name,Subject_Code,Tag,'1' from SessionLocations where Group_ID LIKE '%" + comboBox3.Text + "%'";

            SqlCommand cmd = new SqlCommand(query1, con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);

            con.Close();

            dataGridView2.ColumnCount = 8;
            dataGridView2.Columns[0].Name = "";
            dataGridView2.Columns[1].Name = "Monday";
            dataGridView2.Columns[2].Name = "Tuesday";
            dataGridView2.Columns[3].Name = "Wednesday";
            dataGridView2.Columns[4].Name = "Thursday";
            dataGridView2.Columns[5].Name = "Friday";
            dataGridView2.Columns[6].Name = "Saturday";
            dataGridView2.Columns[7].Name = "Sunday";

            System.IO.StringWriter sw;
            string output;
            int xCount = 1;
            int yCount = 0;
            string[,] Tablero = new string[5, 8];


            for (int k = 0; k < Tablero.GetLength(0); k++)
            {
                for (int l = 0; l < Tablero.GetLength(1); l++)
                {
                    Tablero[k, l] = " --- ";
                }
            }

            // Loop through each row in the table.
            foreach (DataRow row in dt.Rows)
            {
                sw = new System.IO.StringWriter();

                // Loop through each column.
                foreach (DataColumn col in dt.Columns)
                {
                    // Output the value of each column's data.
                    sw.Write(row[col].ToString() + "\n");
                }

                output = sw.ToString();

                // Trim off the trailing ", ", so the output looks correct.
                if (output.Length > 2)
                    output = output.Substring(0, output.Length - 2);


                if (yCount == 5)
                {
                    yCount = 0;
                    xCount++;
                }
                try
                {

                    Tablero[yCount, xCount] = output;
                    yCount++;
                }
                catch (Exception ex)
                {
                }
            }

            do
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    try
                    {
                        dataGridView2.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            } while (dataGridView2.Rows.Count > 1);


            for (int k = 0; k < Tablero.GetLength(0); k++)
            {
                var arlist1 = new System.Collections.ArrayList();

                for (int l = 0; l < Tablero.GetLength(1); l++)
                {
                    arlist1.Add(Tablero[k, l]);
                }

                string srrr = (string)arlist1[1];
                string srrr2 = srrr.Substring(srrr.Length - 2);

                string[] row = new string[] {
                    hr + "." + min,
                    (string) arlist1[1],
                    (string) arlist1[2],
                    (string) arlist1[3],
                    (string) arlist1[4],
                    (string) arlist1[5],
                    (string) arlist1[6],
                    (string) arlist1[7]
                };

                try
                {
                    timeCalc(int.Parse(srrr2.Trim()), 0, 0);
                }
                catch (Exception ex)
                {
                }

                dataGridView2.Rows.Add(row);
            }
        }
    }
    
}
