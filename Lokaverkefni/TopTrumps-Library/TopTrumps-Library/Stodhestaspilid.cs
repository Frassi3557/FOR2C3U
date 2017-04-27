using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopTrumps_Library
{
    public class Stodhestaspilid: Spil
    {
        public Stodhestaspilid(string nafn, double flokkur1, double flokkur2, double flokkur3, double flokkur4, double flokkur5, double flokkur6, double flokkur7, double flokkur8)
            : base(nafn, flokkur1, flokkur2, flokkur3, flokkur4, flokkur5, flokkur6, flokkur7, flokkur8)
        {
           
        }
        public override string ToString()
        {
            return string.Format("Upplysingar:\n Nafn: {0}\n Flokkur1: {1}\n Flokkur2: {2}\n Flokkur3: {3}\n Flokkur4: {4}\n Flokkur5: {5}\n Flokkur6: {6}\n Flokkur7: {7}\n Flokkur7: {8}\n ", Nafn, Flokkur1, Flokkur2, Flokkur3, Flokkur4, Flokkur5, Flokkur6, Flokkur7, Flokkur8);
        }
    }
}
