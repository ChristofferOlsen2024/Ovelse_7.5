using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovelse_7._5
{
    internal class Regnemaskine
    {
        private int Total;

        public void Plus(int tal)
        {
            Total = Total + tal;
        }

        public int Sum()
        {
            return Total;
        }
    }
}
