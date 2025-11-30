using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_Cs_2.NewFolder.exercise1
{
    internal class MusicInstrument
    {
        public string Name;
        public string Characteristics;

        public MusicInstrument(string name, string characteristics)
        {
            Name = name;
            Characteristics = characteristics;
        }

        public virtual void Sound()
        {
            Console.WriteLine("Звук інструмента");
        }

        public void Show()
        {
            Console.WriteLine("Назва " + Name);
        }

        public void Desc()
        {
            Console.WriteLine("Опис " + Characteristics);
        }

        public virtual void History()
        {
            Console.WriteLine("Історія інструмента");
        }
    }
}
