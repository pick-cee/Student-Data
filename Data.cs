using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentData
{
    class Data

    {
        public Data(String name, String matric, int level, String course)
        {
            Name = name;
            Matric = matric;
            Level = level;
            Course = course;
        }
        public string Name { get; set; }
        public string Matric { get; set; }
        public int Level { get; set; }
        public string Course { get; set; }
    }
}
