using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_Cs_2.HW2
{
    internal class BankruptException : ApplicationException
    {
        public BankruptException(string msg) : base(msg) { }
    }
}
