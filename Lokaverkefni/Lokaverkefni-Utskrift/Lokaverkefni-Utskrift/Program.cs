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

                        //Hjarta_6_king
                        Hrutspilið Sokki = new Hrutspilið("Sokki", 41,108,7.0,0,17.3,108,144,8.5);
                        Hrutspilið Freydir = new Hrutspilið("Freydir", 46.4, 105, 7.9, 135, 17.4, 103, 118, 8.6);
                        Hrutspilið Vodvi = new Hrutspilið("Vodvi", 47, 100, 8.0, 0, 17.5, 106, 112, 9.0);
                        Hrutspilið Kjoi = new Hrutspilið("Kjói", 48.8, 116, 8.4, 160, 17.0, 94, 111, 8.3);
                        Hrutspilið Bogi = new Hrutspilið("Bogi", 49.9, 110, 8.3, 310, 17.3, 102, 116, 8.5);
                        Hrutspilið Falur = new Hrutspilið("Falur", 48.3, 106, 8.2, 26, 16.9, 95, 114, 8.3);
                        Hrutspilið Bordi = new Hrutspilið("Bordi", 42, 110, 8.0, 0, 18.0, 104, 0, 9.0);
                        Hrutspilið Bramli = new Hrutspilið("Bramli", 47.5, 104, 7.8, 347, 17.2, 106, 102, 8.4);

                        //Hjarta_as_5_tigul_10-king
                        Hrutspilið Kaldi = new Hrutspilið("Kaldi", 47.8, 100, 7.8, 218, 17.1, 135, 93, 8.4);
                        Hrutspilið Vrom = new Hrutspilið("Vrom", 47.6, 95, 7.8, 158, 17.3, 111, 122, 8.5);
                        Hrutspilið Smyrill = new Hrutspilið("Smyrill", 47.8, 101, 7.9, 97, 17.2, 95, 114, 8.4);
                        Hrutspilið Prjonn = new Hrutspilið("Prjonn", 47.5, 110, 7.8, 370, 17.5, 105, 122, 8.6);
                        Hrutspilið Grabotni = new Hrutspilið("Grabotni", 45, 102, 7.5, 0, 17.5, 106, 139, 8.5);
                        Hrutspilið Kongur = new Hrutspilið("Kongur", 59, 108, 8.0, 0, 17.5, 105, 114, 8.5);

                        //Spadi_as_5_lauf_10_king
                        Hrutspilið Grani = new Hrutspilið("Grani", 48.3, 111, 7.9, 381, 17.4, 105, 122, 8.6);
                        Hrutspilið Ylur= new Hrutspilið("Ylur", 47.4, 111, 8.0, 184, 17.2, 96, 117, 8.4);
                        Hrutspilið Neisti = new Hrutspilið("Neisti", 47, 106, 8.5, 0, 18.5, 105, 116,9.0);
                        Hrutspilið Logi = new Hrutspilið("Logi", 53, 109, 8.5, 0, 18.0, 101, 114, 9.0);                       
                        Hrutspilið Kvikur= new Hrutspilið("Kvikur", 49.0, 113, 7.8, 1085, 17.4, 106, 118, 8.6);
                        Hrutspilið Shrek = new Hrutspilið("Shrek", 49.5, 117, 8.1, 82, 17.3, 103, 118, 8.5);
                        Hrutspilið Cat = new Hrutspilið("Cat", 47.7, 98, 7.6, 193, 17.5, 100, 128, 8.6);
                        Hrutspilið Fannar = new Hrutspilið("Fannar", 46.4, 105, 7.9, 222, 17.4, 101, 125, 8.6);
                        Hrutspilið Hvellur = new Hrutspilið("Hvellur", 48.8, 112, 8.0, 552, 17.3, 96, 113, 8.6);


                        //Tigul_as_9
                        Hrutspilið Raftur = new Hrutspilið("Raftur", 47.1, 106, 7.8, 1406, 17.6, 112, 122, 8.6);
                        Hrutspilið Blossi = new Hrutspilið("Blossi", 54, 108, 8.5, 0, 18.0, 111, 113, 9.0);
                        Hrutspilið Blettur = new Hrutspilið("Blettur", 44.9, 100, 7.9, 332, 17.2, 999, 109, 8.3);
                        Hrutspilið Mundi = new Hrutspilið("Mundi", 49, 104, 7.5, 0, 16.5, 110, 126, 8.5);
                        Hrutspilið Hriflon = new Hrutspilið("Hriflon", 49, 112, 8.0, 0, 18.0, 110, 124, 8.5);
                        Hrutspilið Skrauti = new Hrutspilið("Skrauti", 45, 111, 7.0, 0, 17.3, 98, 112, 8.5);
                        Hrutspilið Krokur = new Hrutspilið("Krokur", 47.5, 101, 8.0, 218, 17.5, 95, 157, 8.7);
                        Hrutspilið Undri = new Hrutspilið("Undri", 49.1, 108, 8.4, 76, 17.2, 100, 109, 8.4);
                        Hrutspilið As = new Hrutspilið("As", 48.8, 121, 8.1, 82, 17.2, 108, 110, 8.3);



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
