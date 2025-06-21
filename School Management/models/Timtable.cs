using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolmenagment.models
{
    internal class Timtable
    {
        public int TimtableId { get; set; }
        public int CourseId { get; set; }
        public string Timeslot { get; set; }
        public int Roomid { get; set; }
    }
}
