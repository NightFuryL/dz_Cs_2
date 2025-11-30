using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_Cs_2.NewFolder.exercise1
{
    internal class Violonchel : MusicInstrument
    {
        public Violonchel() : base("Віолончель", "Струнний інструмент з глибоким звуком") { }

        public override void Sound()
        {
            Console.WriteLine("уууммм");
        }

        public override void History()
        {
            Console.WriteLine("Віолончель створена у 16 столітті в Італії");
        }
    }
}
