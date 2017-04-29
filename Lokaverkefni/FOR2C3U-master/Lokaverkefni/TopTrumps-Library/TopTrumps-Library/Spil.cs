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
        public double Flokkur1 { get; set; }
        public double Flokkur2 { get; set; }
        public double Flokkur3 { get; set; }
        public double Flokkur4 { get; set; }
        public double Flokkur5 { get; set; }
        public double Flokkur6 { get; set; }
        public double Flokkur7 { get; set; }
        public double Flokkur8 { get; set; }

        public Spil(string nafn, double flokkur1, double flokkur2, double flokkur3, double flokkur4, double flokkur5, double flokkur6, double flokkur7, double flokkur8)
        {
           Nafn = nafn;
           Flokkur1 = flokkur1;
           Flokkur2 = flokkur2;
           Flokkur3 = flokkur3;
           Flokkur4 = flokkur4;
           Flokkur5 = flokkur5;
           Flokkur6 = flokkur6;
           Flokkur7 = flokkur7;
           Flokkur8 = flokkur8;
        }

       
    }
}
