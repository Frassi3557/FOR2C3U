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
                        Hrutspilið hrutspil1 = new Hrutspilið("Nafn", 1,2,3,4,5,6,7,8);
                        Hrutspilið hrutspil2 = new Hrutspilið();
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
