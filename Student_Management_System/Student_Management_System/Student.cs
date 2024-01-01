using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    internal class Student
    {
        public string Name { get; set; }
        public int Enrollment_no { get; set; }
        public string Branch { get; set; }
        public string[][] courses {  get; set; } 
    }
}
