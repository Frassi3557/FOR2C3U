using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopTrumps_Library
{
   public class Hrutspilið : Spil
    {


       public Hrutspilið(string nafn, string flokkur1, string flokkur2, string flokkur3, string flokkur4, string flokkur5, string flokkur6, string flokkur7)
            :base( nafn,  flokkur1,  flokkur2, flokkur3, flokkur4,  flokkur5,  flokkur6,  flokkur7)
        {
           
        }
        public override string ToString()
        {
            return string.Format("Upplysingar:\n Nafn: {0}\n Flokkur1: {1}\n Flokkur2: {2}\n Flokkur3: {3}\n Flokkur4: {4}\n Flokkur5: {5}\n Flokkur6: {6}\n Flokkur7: {7}\n ", Nafn, Flokkur1, Flokkur2, Flokkur3, Flokkur4, Flokkur5, Flokkur6, Flokkur7);
        }
        
    }
}
