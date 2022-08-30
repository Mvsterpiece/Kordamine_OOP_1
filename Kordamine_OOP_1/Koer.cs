using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_OOP_1
{
    class Koer : Koduloom
    {
        public string toug;

        public Koer(string toug,string nimi,string varv,char sugu,double kaal,int vanus,bool elav) : base(nimi, varv, sugu, kaal, vanus, elav)
        {
            this.toug = toug;
        }

        public override void print_Info()
        {
            string sugu_text = "";
                if (sugu == 'I')
                {
                    sugu_text = "Isane";
                }
                else if (sugu == 'E')
                {
                    sugu_text = "Emane";
                }

                string elav_text = "";
                if (elav == true)
                {
                    elav_text = "Elav";
                }
                else if (elav == false)
                {
                    elav_text = "Surnud";
                }
            Console.WriteLine("{0} {1} {2} ta on {3} ja tema kaal on {4} ja ta on {5} aastat vana",toug, elav_text, varv, nimi, sugu_text, kaal, vanus);
        }
    }
}
