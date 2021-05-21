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
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String str = @"Server=tcp:time-table.database.windows.net,1433;Initial Catalog=time-table-management;Persist Security Info=False;User ID=nipun;Password=lakshan123@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd;
            SqlDataReader Myreader;

            string query = "SELECT COUNT(Location_ID) FROM Location WHERE Room_type = 'Lecture Hall' GROUP BY Room_type";
            try
            {
                con.Open();
                cmd = new SqlCommand(query, con);
                Myreader = cmd.ExecuteReader();
                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());

                cmd.Dispose();
                con.Close();

                while (Myreader.Read())
                {
                    this.chart2.Series["Total"].Points.AddXY("Lecture Halls", rows_count);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            string query2 = "SELECT COUNT(Location_ID) FROM Location WHERE Room_type = 'Lab' GROUP BY Room_type";
            try
            {
                con.Open();
                cmd = new SqlCommand(query2, con);
                Myreader = cmd.ExecuteReader();
                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());

                cmd.Dispose();
                con.Close();

                while (Myreader.Read())
                {
                    this.chart2.Series["Total"].Points.AddXY("Laboratory", rows_count);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            string query3 = "SELECT COUNT(Subject_ID) FROM Subject";
            try
            {
                con.Open();
                cmd = new SqlCommand(query3, con);
                Myreader = cmd.ExecuteReader();
                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());

                cmd.Dispose();
                con.Close();

                while (Myreader.Read())
                {
                    this.chart2.Series["Total"].Points.AddXY("Module", rows_count);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            string query4 = "SELECT COUNT(Lecturer_ID) FROM Teacher";
            try
            {
                con.Open();
                cmd = new SqlCommand(query4, con);
                Myreader = cmd.ExecuteReader();
                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());

                cmd.Dispose();
                con.Close();

                while (Myreader.Read())
                {
                    this.chart2.Series["Total"].Points.AddXY("L", rows_count);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            this.chart2.Series["Total"].Points.AddXY("Laboratories", 30);
            this.chart2.Series["Total"].Points.AddXY("Lecture Halls", 15);
            this.chart2.Series["Total"].Points.AddXY("Lecturers", 59);
            this.chart2.Series["Total"].Points.AddXY("Modules", 31);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            String str = @"Server=tcp:time-table.database.windows.net,1433;Initial Catalog=time-table-management;Persist Security Info=False;User ID=nipun;Password=lakshan123@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd;

            //No of Lecture Halls
            //create a command
            string query = "SELECT COUNT(Location_ID) FROM Location WHERE Room_type = 'Lecture Hall' GROUP BY Room_type";


            try
            {
                con.Open();
                label5.ForeColor = Color.White;
                label5.Text = "Database successfully connected!!!";


                cmd = new SqlCommand(query, con);

                //Read from db

                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                con.Close();


                //Display data on the page
                label4.ForeColor = Color.White;

                label4.Text = "No of Lectute Halls =  " + rows_count.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();

                }
            }

            //No of Laborataries
            //create a command
            string query1 = "SELECT COUNT(Location_ID) FROM Location WHERE Room_type = 'Laboratory' GROUP BY Room_type";


            try
            {
                con.Open();
                label5.ForeColor = Color.White;
                label5.Text = "Database successfully connected!!!";


                cmd = new SqlCommand(query1, con);

                //Read from db

                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                con.Close();


                //Display data on the page
                label1.ForeColor = Color.White;

                label1.Text = "No of Laboratories =  " + rows_count.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();

                }
            }

            //No of Modules
            //create a command
            string query2 = "SELECT COUNT(Subject_ID) FROM Subject";


            try
            {
                con.Open();
                label5.ForeColor = Color.White;
                label5.Text = "Database successfully connected!!!";


                cmd = new SqlCommand(query2, con);

                //Read from db

                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                con.Close();


                //Display data on the page
                label2.ForeColor = Color.White;

                label2.Text = "No of Modules =  " + rows_count.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();

                }
            }

            //No of Lecturers
            //create a command
            string query3 = "SELECT COUNT(Lecturer_ID) FROM Teacher";


            try
            {
                con.Open();
                label5.ForeColor = Color.White;
                label5.Text = "Database successfully connected!!!";


                cmd = new SqlCommand(query3, con);

                //Read from db

                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                con.Close();


                //Display data on the page
                label3.ForeColor = Color.White;

                label3.Text = "No of Lecturers =  " + rows_count.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();

                }
            }
        }
    }
}

