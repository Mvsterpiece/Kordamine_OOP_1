using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_OOP_1
{
    class Opilane : Isik
    {
        public string koolinimi;
        public string klass;
        public string spetsialiseerumine;

        public Opilane(string koolinimi, string klass, string spetsialiseerumine, string nimi, int synniaasta, sugu InimSugu, double maksuvaba, double palk) :base(nimi, synniaasta, InimSugu)
        {
            this.koolinimi = koolinimi;
            this.klass = klass;
            this.spetsialiseerumine = spetsialiseerumine;
        }
        public override double arvutaSissetulek()
        {
            double netopalk = ((palk - maksuvaba) * (1 - (tulumaks / 100))) + maksuvaba;
            return netopalk;
        }

        public override void printInfo()
        {
            Console.WriteLine("Tema koolinimi on {0} ja klass {1} ja eriala {2}",koolinimi ,klass, spetsialiseerumine);
        }


    }
}   
