using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_Cs_2.NewFolder.exercise1
{
    internal class Trombon : MusicInstrument
    {
        public Trombon() : base("Тромбон", "Мідний духовий інструмент") { }

        public override void Sound()
        {
            Console.WriteLine("уууааа");
        }

        public override void History()
        {
            Console.WriteLine("Тромбон з'явився у 15 столітті");
        }
    }
}
