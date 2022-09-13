using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_OOP_1
{
    class Kutsekooliopilane : Isik
    {
        public string oppeasutus;
        public enum eriala { Welder, WebProgrammer }
        public eriala Inimeriala;
        public string kursus;
        public int toetus;
        public string elamiskoht;
        public int lastearv;
        public double perepalk;
        public double keskhinne;
        public double toetussumma;

        double soidetoetus = 0;
        double pohitoetus = 0;
        double eritoetus = 0;
        double tulek;

        public Kutsekooliopilane(double toetussumma, string elamiskoht, double perepalk, int lastearv, double keskhinne, string oppeasutus, string eriala, string kursus, string nimi, int synniaasta, sugu Inimsugu, double maksuvaba, double palk, double tulumaks, eriala Inimeriala) : base(nimi, synniaasta, Inimsugu)
        {
            this.oppeasutus = oppeasutus;
            this.Inimeriala = Inimeriala;
            this.kursus = kursus;
            this.toetus = toetus;
            this.lastearv = lastearv;
            this.perepalk = perepalk;
            this.keskhinne = keskhinne;
            this.toetussumma = toetussumma;

        }

        public string Toetus()
        {
            if (elamiskoht != "Tallinn")
            {
                soidetoetus = 50;
            }
            if (perepalk <= 300 || lastearv > 2)
            {
                eritoetus = 90;
            }
            if (keskhinne >= 3.3)
            {
                pohitoetus = 60;
            }
            string toetus = $"sõidetoetus {soidetoetus}, eritoetus {eritoetus}, põhitoetus {pohitoetus}";
            return toetus;
        }
        public override double arvutaSissetulek()
        {
            tulek = toetussumma + soidetoetus + eritoetus + pohitoetus;
            return tulek;
        }


        public override void printInfo()
        {
            Console.WriteLine("Sinu toetus on {0} õppeasutus on {1}, eriala {2}, kursus {3} ja tootasu {4}.", toetus, oppeasutus, Inimeriala, kursus);
        }

    }
}
