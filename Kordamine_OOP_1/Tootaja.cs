using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_OOP_1
{
    internal class Tootaja
    {
        public string asutus;
        public string amet;
        public string tootasu;

        public Tootaja(string asutus, string amet, string tootasu)
        {
            this.asutus = asutus;
            this.amet = amet;
            this.tootasu = tootasu;
        }




        public override double arvutaSissetulek(double maksuvaba, double tulumaks)
        {
            double clearPalk = ((tootasu - maksuvaba) * (1 - (tulumaks / 100))) + maksuvaba;
            return clearPalk;
        }

    }
}
