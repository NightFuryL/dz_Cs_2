using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_Cs_2.NewFolder.exercise2
{
    internal class OnlineCourse : Course
    {
        public string Platform;

        public OnlineCourse(string name, int duration, string platform) : base(name, duration)
        {
            Platform = platform;
        }

        public override string ToString()
        {
            return Name + " тривалість " + Duration + " годин платформа " + Platform;
        }
    }
}
