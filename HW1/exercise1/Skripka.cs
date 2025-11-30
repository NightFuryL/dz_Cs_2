using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_Cs_2.NewFolder.exercise1
{
    internal class Skripka : MusicInstrument
    {
        public Skripka() : base("Скрипка", "Струнний інструмент з високим звучанням") { }

        public override void Sound()
        {
            Console.WriteLine("пііііу");
        }

        public override void History()
        {
            Console.WriteLine("Скрипка з'явилась у 16 столітті в Італії");
        }
    }
}
