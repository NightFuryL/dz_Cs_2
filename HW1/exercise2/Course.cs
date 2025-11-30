using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_Cs_2.NewFolder.exercise2
{
    internal class Course
    {
        public string Name;
        public int Duration;

        public Course(string name, int duration)
        {
            Name = name;
            Duration = duration;
        }

        public override string ToString()
        {
            return Name + " тривалість " + Duration + " годин";
        }
    }
}
