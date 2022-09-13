using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontrolltooMang
{
    abstract class Ese : IUksus //наследует от IUksus
    {
        int punktideArv;
        string nimetus;

        public Ese(string nimetus, int punktideArv) //Klassis peab olema kahe parameetriga konstruktor, mille abil saab määrata nimetuse ja punktide
        {
            this.nimetus = nimetus;
            this.punktideArv = punktideArv;
        }

        public int PunktideArv() //Meetod punktideArv tagastab punktide arvu.
        {
            return punktideArv;
        }

        public string info() //Meetod info tagastab selle eseme nimetuse.
        {
            return nimetus;
        }


    }
}
