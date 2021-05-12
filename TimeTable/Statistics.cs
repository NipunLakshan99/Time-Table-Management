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
            this.chart2.Series["Total"].Points.AddXY("Laboratories", 3);
            this.chart2.Series["Total"].Points.AddXY("Lecture Halls", 2);
            this.chart2.Series["Total"].Points.AddXY("Lecturers", 9);
            this.chart2.Series["Total"].Points.AddXY("Modules", 7);
        }
    }
}
