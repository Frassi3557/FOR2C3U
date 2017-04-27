using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopTrumps_Library;
namespace Lokaverkefni_Utskrift
{
    class Program
    {
        static void Main(string[] args)
        {
            int val = 0;

            do
            {
                Console.Clear();

                Console.WriteLine("1. Hrutspil");
                Console.WriteLine("2. Hesta");
                Console.WriteLine("0. Hætta");

                val = Convert.ToInt32(Console.ReadLine());

                switch (val)
                {
                    case 1:

                        Random randomspil = new Random();

                        
                        List<Hrutspilið> stokkur = new List<Hrutspilið>();
                        List<Hrutspilið> spilNot = new List<Hrutspilið>();
                        List<Hrutspilið> spilTolvu = new List<Hrutspilið>();
                        //Hrutspilið[] hrutastokkur = new Hrutspilið[52];


                        
                          int teljariSpil = 0;
                          
                         
                        

                        //Hjarta_6_king
                        stokkur.Add(new Hrutspilið("Sokki", 41, 108, 7.0, 0, 17.3, 108, 144, 8.5));
                        stokkur.Add(new Hrutspilið("Freydir", 46.4, 105, 7.9, 135, 17.4, 103, 118, 8.6));
                        stokkur.Add(new Hrutspilið("Vodvi", 47, 100, 8.0, 0, 17.5, 106, 112, 9.0));
                        stokkur.Add(new Hrutspilið("Kjói", 48.8, 116, 8.4, 160, 17.0, 94, 111, 8.3));
                        stokkur.Add(new Hrutspilið("Bogi", 49.9, 110, 8.3, 310, 17.3, 102, 116, 8.5));
                        stokkur.Add(new Hrutspilið("Falur", 48.3, 106, 8.2, 26, 16.9, 95, 114, 8.3));
                        stokkur.Add(new Hrutspilið("Bordi", 42, 110, 8.0, 0, 18.0, 104, 0, 9.0));
                        stokkur.Add(new Hrutspilið("Bramli", 47.5, 104, 7.8, 347, 17.2, 106, 102, 8.4));

                        //Hjarta_as_5_tigul_10-king
                        stokkur.Add(new Hrutspilið("Kaldi", 47.8, 100, 7.8, 218, 17.1, 135, 93, 8.4));
                        stokkur.Add(new Hrutspilið("Vrom", 47.6, 95, 7.8, 158, 17.3, 111, 122, 8.5));
                        stokkur.Add(new Hrutspilið("Smyrill", 47.8, 101, 7.9, 97, 17.2, 95, 114, 8.4));
                        stokkur.Add(new Hrutspilið("Prjonn", 47.5, 110, 7.8, 370, 17.5, 105, 122, 8.6));
                        stokkur.Add(new Hrutspilið("Grabotni", 45, 102, 7.5, 0, 17.5, 106, 139, 8.5));
                        stokkur.Add(new Hrutspilið("Kongur", 59, 108, 8.0, 0, 17.5, 105, 114, 8.5));

                        //Spadi_as_5_lauf_10_king
                        stokkur.Add(new Hrutspilið("Grani", 48.3, 111, 7.9, 381, 17.4, 105, 122, 8.6));
                        stokkur.Add(new Hrutspilið("Ylur", 47.4, 111, 8.0, 184, 17.2, 96, 117, 8.4));
                        stokkur.Add(new Hrutspilið("Neisti", 47, 106, 8.5, 0, 18.5, 105, 116, 9.0));
                        stokkur.Add(new Hrutspilið("Logi", 53, 109, 8.5, 0, 18.0, 101, 114, 9.0));
                        stokkur.Add(new Hrutspilið("Kvikur", 49.0, 113, 7.8, 1085, 17.4, 106, 118, 8.6));
                        stokkur.Add(new Hrutspilið("Shrek", 49.5, 117, 8.1, 82, 17.3, 103, 118, 8.5));
                        stokkur.Add(new Hrutspilið("Cat", 47.7, 98, 7.6, 193, 17.5, 100, 128, 8.6));
                        stokkur.Add(new Hrutspilið("Fannar", 46.4, 105, 7.9, 222, 17.4, 101, 125, 8.6));
                        stokkur.Add(new Hrutspilið("Hvellur", 48.8, 112, 8.0, 552, 17.3, 96, 113, 8.6));


                        //Tigul_as_9
                        stokkur.Add(new Hrutspilið("Raftur", 47.1, 106, 7.8, 1406, 17.6, 112, 122, 8.6));
                        stokkur.Add(new Hrutspilið("Blossi", 54, 108, 8.5, 0, 18.0, 111, 113, 9.0));
                        stokkur.Add(new Hrutspilið("Blettur", 44.9, 100, 7.9, 332, 17.2, 999, 109, 8.3));
                        stokkur.Add(new Hrutspilið("Mundi", 49, 104, 7.5, 0, 16.5, 110, 126, 8.5));
                        stokkur.Add(new Hrutspilið("Hriflon", 49, 112, 8.0, 0, 18.0, 110, 124, 8.5));
                        stokkur.Add(new Hrutspilið("Skrauti", 45, 111, 7.0, 0, 17.3, 98, 112, 8.5));
                        stokkur.Add(new Hrutspilið("Krokur", 47.5, 101, 8.0, 218, 17.5, 95, 157, 8.7));
                        stokkur.Add(new Hrutspilið("Undri", 49.1, 108, 8.4, 76, 17.2, 100, 109, 8.4));
                        stokkur.Add(new Hrutspilið("As", 48.8, 121, 8.1, 82, 17.2, 108, 110, 8.3));

                        //lauf as 9
                        stokkur.Add(new Hrutspilið("Þróttur", 48, 106, 7.8, 222, 17.4, 105, 121, 8.5));
                        stokkur.Add(new Hrutspilið("Bifur", 45.5, 96, 7.7, 407, 17.5, 110, 115, 8.7));
                        stokkur.Add(new Hrutspilið("Stáli", 85, 102, 8, 0, 17.5, 100, 130, 9));
                        stokkur.Add(new Hrutspilið("Fálki", 51, 103, 7.5, 0, 17.5, 102, 142, 9));
                        stokkur.Add(new Hrutspilið("Kjarkur", 48, 108, 7.5, 0, 17, 108, 0, 8.5));
                        stokkur.Add(new Hrutspilið("Hólmi", 45, 104, 7.5, 0, 18, 95, 0, 9));
                        stokkur.Add(new Hrutspilið("Púki", 49, 111, 7.7, 403, 17.3, 114, 119, 8.5));
                        stokkur.Add(new Hrutspilið("Mjöður", 46.4, 102, 8, 210, 17.5, 103, 127, 8.6));
                        stokkur.Add(new Hrutspilið("Mókollur", 49.6, 111, 7.9, 135, 16.9, 122, 102, 8.2));

                        //spadi 6 king
                        stokkur.Add(new Hrutspilið("Gotti", 47.2, 100, 8, 182, 17.5, 102, 119, 8.6));
                        stokkur.Add(new Hrutspilið("Hrói", 63, 107, 8, 0, 17.3, 108, 108, 8.5));
                        stokkur.Add(new Hrutspilið("Dökkvi", 45.5, 102, 7.8, 157, 17.2, 105, 120, 8.5));
                        stokkur.Add(new Hrutspilið("Bolli", 51, 109, 9, 0, 17.5, 111, 109, 9));
                        stokkur.Add(new Hrutspilið("Týr", 38, 96, 8, 0, 17.5, 105, 131, 8.5));
                        stokkur.Add(new Hrutspilið("Papi", 45.6, 82, 8, 428, 17.6, 106, 140, 8.7));
                        stokkur.Add(new Hrutspilið("Tengill", 45, 94, 8, 0, 17.5, 97, 145, 9));
                        stokkur.Add(new Hrutspilið("At", 45.6, 110, 7.9, 244, 17.5, 110, 139, 8.5));
                        stokkur.Add(new Hrutspilið("Mjolnir", 49, 105, 8.3, 78, 17.3, 105, 113, 8.6));
                        stokkur.Add(new Hrutspilið("Sigfus", 49.6, 108, 8.4, 76, 17.5, 102, 108, 8.5));
                        stokkur.Add(new Hrutspilið("Tyr", 49, 105, 8.3, 76, 17.3, 103, 110, 8.4));

                        while (stokkur.Count() > 0)
                            {
                                int randtala = randomspil.Next(0, stokkur.Count());
                                if (teljariSpil % 2 == 0)
                                {
                                    //spilNot er Listi
                                    spilNot.Add(stokkur[randtala]);
                               
                                }

                                else
                                {
                                    //spilTolvu er Listi
                                spilTolvu.Add(stokkur[randtala]);
                                }

                                teljariSpil++;
                                stokkur.Remove(stokkur[randtala]);
                            }


                        /*
                         * Console.WriteLine(spilNot.Count());
                        Console.WriteLine(spilTolvu.Count());
                        foreach (Hrutspilið spil in spilTolvu)
                        {
                            if (spilNot.Contains(spil))
                            {
                                Console.WriteLine("obbosí");
                            }
                        }*/

                        break;

                    case 2:
                        break;


                    case 0:
                        Console.WriteLine("takk fyrir að nota forritið");
                        break;

                    default:
                        Console.WriteLine("val er ekki til");
                        break;
                }//end switch
                Console.ReadKey();
            } while (val != 0);//end
        }
    }
}
