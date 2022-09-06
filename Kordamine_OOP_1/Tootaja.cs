using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_OOP_1
{
    class Tootaja : Isik
    {
        public string asutus;
        public enum amet { Manager, Designer, Programmer }
        public amet Inimamet;
        public string tootasu;

        public Tootaja(string asutus, amet Inimamet, string tootasu, string nimi, int synniaasta, sugu Inimsugu, double maksuvaba, double palk) : base(nimi, synniaasta, Inimsugu)
        {
            this.asutus = asutus;
            this.Inimamet = Inimamet;
            this.tootasu = tootasu;
        }

        public override double arvutaSissetulek()
        {
            double netopalk = ((palk - maksuvaba) * (1 - (tulumaks / 100))) + maksuvaba;
            return netopalk;
        }

        public override void printInfo()
        {
            Console.WriteLine("Sinu asutus on {0} ja amet {1} ja töötasu {2}", asutus, Inimamet, tootasu);
        }




    }
}
