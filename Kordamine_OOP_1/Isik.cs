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
        public int vanus;
        public int uusnimi;
        public enum Sugu { isane, emane }
        public Sugu sugu;


        public Isik()
        {
            
        }

        public Isik(string nimi, int synniAasta, string inimsugu, Sugu sugu)
        {
            this.nimi = nimi;
            this.synniAasta = synniAasta;
            this.sugu = sugu;
        }

        public void printInfo()
        {
            Console.WriteLine("Sinu nimi on {0}, sa oled sundinud {1} ja sinu sugo on {2}",nimi, synniAasta, sugu);
        }

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

        public abstract double arvutaSissetulek(double palk, double tulumaks, double maksuvaba);


    }
}
