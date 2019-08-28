using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProject.Models
{
    class Student
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public string Email { get; set; }

        public StudentGroup StudentGroup { get; set; }

        public string GetFullname()
        {
            return $"{Firstname} {Lastname}";
        }
    }
}
