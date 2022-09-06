using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_OOP_1
{
    internal class Kutsekooliopilane : Isik
    {
        public string oppeasutus;
        public enum eriala { Welder, WebProgrammer, Architector }
        public eriala Inimeriala;
        public string kursus;
        public int toetus;

        public Kutsekooliopilane(string oppeasutus, eriala Inimeriala, string kursus, int toetus, string nimi, int synniaasta, eriala Inimsugu, double maksuvaba, double palk) : base(nimi, synniaasta, Inimsugu, maksuvaba, palk)
        {
            this.oppeasutus = oppeasutus;
            this.Inimeriala = Inimeriala;
            this.kursus = kursus;
            this.toetus = toetus;
        }





        public override double arvutaSissetulek(double maksuvaba, double tulumaks, double palk)
        {
            double netopalk = ((palk - maksuvaba) * (1 - (tulumaks / 100))) + maksuvaba;
            return netopalk;
        }








        public override void printInfo()
        {
            Console.WriteLine("Sinu õppeasutus on {0}, eriala {1}, kursus {2} ja toetus {3}", oppeasutus, Inimeriala, kursus, toetus);
        }


    }
}
