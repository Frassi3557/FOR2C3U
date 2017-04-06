using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopTrumps_Library
{
    public class Spil
    {

        public string Nafn { get; set; }
        public int Þyngd { get; set; }
        public int Mjolkurlagni { get; set; }
        public int EinkunnUllar { get; set; }
        public int EinkunnLæris { get; set; }
        public int Frjosemi { get; set; }
        public int Gerd { get; set; }
        public int EinkunFyrirMalir { get; set; }

        public Spil(string nafn, int þyngd, int mjolkurlagni, int einkunnUllar, int einkunnLæris, int frjosemi, int gerd, int einkunFyrirMalir)
        {
            Nafn = nafn;
            Þyngd =þyngd;
            Mjolkurlagni = mjolkurlagni;
            EinkunnUllar = einkunnUllar;
            EinkunnLæris = einkunnLæris;
            Frjosemi = frjosemi;
            Gerd = gerd;
            EinkunFyrirMalir = einkunFyrirMalir;
        }

       
    }
}
