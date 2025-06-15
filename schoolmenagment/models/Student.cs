using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolmenagment.models
{
    internal class Student
    {
        public int Id { get; set; }             // Primary Key
        public string Name { get; set; }        // Student's name
        public int Age { get; set; }            // Student's age
        public string Gender { get; set; }      // Male / Female / Other
        public int CourseId { get; set; }
        public string Address { get; set; }
    }
}
