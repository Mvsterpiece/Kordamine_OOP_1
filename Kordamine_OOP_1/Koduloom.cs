﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_OOP_1
{
    abstract class Koduloom
    {
        public string nimi;
        public string varv;
        //public char sugu;
        public enum sugu { isane,emane}
        public sugu loomaSugu;
        public double kaal;
        public int vanus;
        public bool elav; //kui true, siis elav, kui fasle, siis on surnud.

        public Koduloom()
        {

        }

        public Koduloom(string nimi = "---", string varv = "---", char sugu = '-', double kaal = 0.0, int vanus = 0, bool elav = false)
        {
            this.nimi = nimi;
            this.varv = varv;
            //this.sugu = sugu;
            this.loomaSugu = loomaSugu;
            this.kaal = kaal;
            this.vanus = vanus;
            this.elav = elav;
        }
        public Koduloom(Koduloom loom) // kloonimiseks
        {
            this.nimi = loom.nimi;
            this.varv = loom.varv;
            //this.sugu = loom.sugu;
            this.loomaSugu=loom.loomaSugu;
            this.kaal = loom.kaal;
            this.vanus = loom.vanus;
            this.elav = loom.elav;
        }
        public abstract void print_Info();
        //public void print_Info()
        //{
        //    string sugu_text = "";
        //    if (sugu == 'I')
        //    {
        //        sugu_text = "Isane";
        //    }
        //    else if (sugu == 'E')
        //    {
        //        sugu_text = "Emane";
        //    }

        //    string elav_text = "";
        //    if (elav == true)
        //    {
        //        elav_text = "Elav";
        //    }
        //    else if (elav == false)
        //    {
        //        elav_text = "Surnud";
        //    }
        //    Console.WriteLine("{0} {1} {2} ta on {3} ja tema kaal on {4} ja ta on {5} aastat vana", elav_text, varv, nimi, sugu_text, kaal, vanus);
        //}
        public void muuda_Nimi(string uusNimi)
        {
            nimi = uusNimi;
        }
    }

}