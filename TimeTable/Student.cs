using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable
{
    class Student
    {
       public int Student_ID { get; set; }
       public string Academic_Year_Semester { get; set; }
       public string Programme { get; set; }
       public string Group_Number { get; set; }
       public string Sub_Group_Number { get; set; }
       public string Group_ID {
            get {
                return $"{Academic_Year_Semester}{"."}{Group_Number}{"("}{Programme}{")"}";
            }
        }
        public string Sub_Group_ID
        {
            get
            {
                return $"{Academic_Year_Semester}{"."}{Group_Number}{"."}{Sub_Group_Number}{"("}{Programme}{")"}";
            }
        }




    }
}
