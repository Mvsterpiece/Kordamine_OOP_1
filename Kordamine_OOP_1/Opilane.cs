using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_OOP_1
{
    internal class Opilane : Isik
    {
        public string koolinimi;
        public string klass;
        public string spetsialiseerumine;

        public Opilane(string koolinimi, string klass, string spetsialiseerumine, string nimi, int synniaasta, Sugu isikSugu, double maksuvaba, double palk) : base(nimi, synniaasta, isikSugu, maksuvaba, palk)
        {
            this.koolinimi = koolinimi;
            this.klass = klass;
            this.spetsialiseerumine = spetsialiseerumine;
        }
        public override double arvutaSissetulek(double maksuvaba, double tulumaks, double palk)
        {
            double netopalk = ((palk - maksuvaba) * (1 - (tulumaks / 100))) + maksuvaba;
            return netopalk;
        }

    }
}
