using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_OOP_1
{
    public abstract class Isik
    {
        public string nimi;
        public int synniAasta;
        public enum sugu { isane, emane }
        public sugu Inimsugu;
        public double palk;
        public double maksuvaba;
        public double tulumaks;

        public Isik(string nimi)
        {
            
        }

        public Isik(string nimi, int synniAasta, sugu Inimsugu)
        {
            this.nimi = nimi;
            this.synniAasta = synniAasta;
            this.Inimsugu = Inimsugu;
        }

        public abstract void printInfo();

        public int arvutaVanus()
        {
            int praeguneAasta = DateTime.Now.Year;
            int vanus = praeguneAasta - synniAasta;
            Console.WriteLine("Sa oled {0} aastat vana.",vanus);
            return vanus;
        }

        public void muuda_Nimi(string uusNimi)
        {
            nimi = uusNimi;
        }

        public abstract double arvutaSissetulek();







    }
}
