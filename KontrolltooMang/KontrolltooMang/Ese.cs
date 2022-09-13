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

        public Ese(string nimetus, int punktideArv)
        {
            this.nimetus = nimetus;
            this.punktideArv = punktideArv;
        }

        public int PunktideArv()
        {
            return punktideArv;
        }

        public string info()
        {
            return nimetus;
        }


    }
}
