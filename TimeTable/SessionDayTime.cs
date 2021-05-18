using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable
{
    class SessionDayTime
    {
        public int ID { get; set; }

        public string Lecturer_1 { get; set; }

        public string Lecturer_2 { get; set; }

        public string Subject_Code { get; set; }

        public string Subject_Name { get; set; }

        public string Group_ID { get; set; }

        public string Tag { get; set; }

        public string Room { get; set; }

        public string Day { get; set; }

        public string Start_Time { get; set; }

        public string End_Time { get; set; }
    }
}
