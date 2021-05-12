using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTable
{
    public partial class Statistics : Form
    {
        PlaceRepo PlaceRepo = new PlaceRepo();

        public Statistics()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String str = @"Data Source=(localdb)\MadushaDB;Initial Catalog=TimeTable;Integrated Security=True";
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
                    this.chart2.Series["Total"].Points.AddXY("Lecture Halls",rows_count);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            string query2 = "SELECT COUNT(Location_ID) FROM Location WHERE Room_type = 'Laboratory' GROUP BY Room_type";
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

            string query3 = "SELECT COUNT(Module_ID) FROM Module";
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

            string query4 = "SELECT COUNT(Lecture_ID) FROM Lecturer";
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


            this.chart2.Series["Total"].Points.AddXY("Laboratories", 4);
            this.chart2.Series["Total"].Points.AddXY("Lecture Halls", 4);
            this.chart2.Series["Total"].Points.AddXY("Lecturers", 7);
            this.chart2.Series["Total"].Points.AddXY("Modules", 10);

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String str = @"Data Source=(localdb)\MadushaDB;Initial Catalog=TimeTable;Integrated Security=True";
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd;

            //No of Lecture Halls
            //create a command
            string query = "SELECT COUNT(Location_ID) FROM Location WHERE Room_type = 'Lecture Hall' GROUP BY Room_type";


            try
            {
                con.Open();
                label9.ForeColor = Color.White;
                label9.Text = "Database successfully connected!!!";


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
                label9.ForeColor = Color.White;
                label9.Text = "Database successfully connected!!!";


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
            string query2 = "SELECT COUNT(Module_ID) FROM Module";


            try
            {
                con.Open();
                label9.ForeColor = Color.White;
                label9.Text = "Database successfully connected!!!";


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
            string query3 = "SELECT COUNT(Lecture_ID) FROM Lecturer";


            try
            {
                con.Open();
                label9.ForeColor = Color.White;
                label9.Text = "Database successfully connected!!!";


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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
