using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_Cs_2.NewFolder.exercise1
{
    internal class Ukulele : MusicInstrument
    {
        public Ukulele() : base("Укулеле", "Невелика гавайська гітара") { }

        public override void Sound()
        {
            Console.WriteLine("тіньтіньтінь");
        }

        public override void History()
        {
            Console.WriteLine("Укулеле виникло у 19 столітті на Гаваях");
        }
    }
}
