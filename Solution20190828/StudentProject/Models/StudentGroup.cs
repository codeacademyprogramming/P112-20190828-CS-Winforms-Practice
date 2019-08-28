using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProject.Models
{
    class StudentGroup
    {
        public string Name { get; set; }
        public int Capacity { get; set; }

        public string Teacher { get; set; }

        public string GetInfo()
        {
            return $"{Name} - {Capacity}";
        }

    }
}
