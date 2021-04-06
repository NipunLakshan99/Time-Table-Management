using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable
{
    class Lecs
    {
        public int Lecturer_ID { get; set; }
        public string Lecturer_name { get; set; }
        public string Faculty { get; set; }
        public string Department { get; set; }
        public string Building { get; set; }
        public string Level { get; set; }

        public string Rank
        {
            get
            {
                return $"{Lecturer_ID}{"."}{Lecturer_name}{"."}{Level}";
            }
        }

    }
}
