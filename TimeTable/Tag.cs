using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable
{
    class Tag
    {
        public int Tag_ID { get; set; }
        public string Tag_Name { get; set; }//Tag Name = Subject Name
        public string Tag_Code { get; set; }//Tag code = Subject Code
        public string Related_Tag { get; set; }
    }
}
