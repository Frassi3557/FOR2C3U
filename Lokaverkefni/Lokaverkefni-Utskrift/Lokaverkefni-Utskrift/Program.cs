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
                        break;

                    case 2:
                        Stodhestaspilid stodspil1 = new Stodhestaspilid("Þristur frá Feti", 2510, 9, 8.14, 8.35, 8.27, 275, 141, 117));
                        Stodhestaspilid stodspil2 = new Stodhestaspilid("Þokki frá Kýrholti",2200,9.5,8.28, 9.04,8.73,175,143,123));
                        Stodhestaspilid stodspil3 = new Stodhestaspilid("Sveinn-Hervar frá Þúfu",2500,9.0,8.06,8.38,8.25,261,139,119));
                        Stodhestaspilid stodspil4 = new Stodhestaspilid("Andvari frá Ey 1",1600,9.0,8.33,8.40,8.36,500,136,120));
                        Stodhestaspilid stodspil5 = new Stodhestaspilid("Borði frá Fellskoti",1510,9.5,7.89,8.48,8.24,83,141,119));
                        Stodhestaspilid stodspil6 = new Stodhestaspilid("Rökkvi frá Harlaugsstöðum",2500,9.0,8.13,8.48,8.34,261,141,109));
                        Stodhestaspilid stodspil7 = new Stodhestaspilid("Kraftur frá Efri-Þverá",3400,9.0,8.20,8.48,8.37,24,143,115));
                        Stodhestaspilid stodspil8 = new Stodhestaspilid("Oddur frá Selfossi",4521,9.5,8.10,8.86,8.48,391,136,118));
                        Stodhestaspilid stodspil9 = new Stodhestaspilid("Fursti frá Stóra-Hofi",3500,9.0,8.09,8.78,8.51,36,143,121));
                        Stodhestaspilid stodspil10 = new Stodhestaspilid("Glymur frá Innri-Skeljabrekku",8600,9.0,7.98,8.65,8.38,87,142,115));
                        Stodhestaspilid stodspil11 = new Stodhestaspilid("Klettur frá Hvammi",0210,9.5,8.43,8.54,8.49,211,140,112));
                        Stodhestaspilid stodspil12 = new Stodhestaspilid("Aðall frá Nýjabæ",3500,9.5,8.13,8.97,8.64,82,143,118));
                        Stodhestaspilid stodspil13 = new Stodhestaspilid("Gígjar frá Auðsholtshjáleigu",2520,9.5,7.98,8.78,8.46,168,136,123));
                        Stodhestaspilid stodspil14 = new Stodhestaspilid("Hruni frá Breiðumörk 2",7510,9.0,7.61,8.41,8.09,34,133,108));
                        Stodhestaspilid stodspil15 = new Stodhestaspilid("Kjarkur frá Egilsstaðabæ",2700,9.5,7.85,8.71,8.28,354,133,106));
                        Stodhestaspilid stodspil16 = new Stodhestaspilid("Hróður frá Refssöðum",1590,9.5,7.94,8.69,8.39,344,135,125));
                        Stodhestaspilid stodspil17 = new Stodhestaspilid("Illingur frá Tóftum",1510,9.0,8.45,8.81,8.67,195,137,124));
                        Stodhestaspilid stodspil18 = new Stodhestaspilid("Sigur frá Hólabaki",1620,9.0,8.24,7.85,8.01,5,141,112));
                        Stodhestaspilid stodspil19 = new Stodhestaspilid("Stáli frá kjarri",7500,9.5,8.26,9.09,8.76,70,140,121));
                        Stodhestaspilid stodspil20 = new Stodhestaspilid("Gári frá Auðsholtshjáleigu",1600,9.5,8.87,8.47,8.63,162,143,125));
                        Stodhestaspilid stodspil21 = new Stodhestaspilid("Hugi frá Hafsteinsstöðum",1551,9.5,8.13,8.49,8.31,370,137,119));
                        Stodhestaspilid stodspil22 = new Stodhestaspilid("Funi frá Vindási",1600,9.0,8.08,8.65,8.42,29,144,122));
                        Stodhestaspilid stodspil23 = new Stodhestaspilid("Orri frá Þúfu",2500,9.5,8.08,8.61,8.34,1049,136,127));
                        Stodhestaspilid stodspil24 = new Stodhestaspilid("Þóroddur frá Þóroddsstöðum",1521,9.0,8.28,9.04,8.74,218,142,126));
                        Stodhestaspilid stodspil25 = new Stodhestaspilid("Klerkur frá Bjarnanesi 1",2500,9.0,7.52,7.55,7.54,11,145,104));
                        Stodhestaspilid stodspil26 = new Stodhestaspilid("Álfur frá Selfossi",1510,9.5,7.98,8.44,8.26,82,140,124));
                        Stodhestaspilid stodspil27 = new Stodhestaspilid("Keilir frá Miðsitju",6600,9.5,8.42,8.77,8.63,446,138,119));
                        Stodhestaspilid stodspil28 = new Stodhestaspilid("Krummi frá Blessastöðum 1a",0230,9.0,8.13,8.55,8.38,86,141,120));
                        Stodhestaspilid stodspil29 = new Stodhestaspilid("Akkur frá Brautarholti",1520,9.5,8.23,8.80,8.57,72,140,122));
                        Stodhestaspilid stodspil30 = new Stodhestaspilid("Roði frá Múla",1500,8.5,8.30,7.84,8.07,294,138,119));
                        Stodhestaspilid stodspil31 = new Stodhestaspilid("Örn frá Efri-Gegnishólum",1510,9.0,7.89,8.45,8.23,18,135,120));
                        Stodhestaspilid stodspil32 = new Stodhestaspilid("Blær frá Torfunesi",2500,9.5,8.17,8.80,8.55,87,141,126));
                        Stodhestaspilid stodspil33 = new Stodhestaspilid("Gustur frá Hóli",0100,10.0,8.13,9.01,8.57,644,136,124));
                        Stodhestaspilid stodspil34 = new Stodhestaspilid("Moli frá Skriðu",2700,9.5,7.98,8.36,8.21,80,141,110));
                        Stodhestaspilid stodspil35 = new Stodhestaspilid("Þorsti frá Garði",1722,9.0,8.11,8.60,8.40,57,140,116));
                        Stodhestaspilid stodspil36 = new Stodhestaspilid("Sær frá Bakkakoti",7200,9.5,7.96,9.05,8.62,344,143,129));
                        Stodhestaspilid stodspil37 = new Stodhestaspilid("Eldjárn frá Tjaldhólum",1500,10.0,8.09,8.85,8.55,132,140,119));
                        Stodhestaspilid stodspil38 = new Stodhestaspilid("Aron frá Strandarhöfði",2200,9.5,8.22,8.75,8.54,276,144,122));
                        Stodhestaspilid stodspil39 = new Stodhestaspilid("Aris frá Akureyri",2500,9.0,8.26,8.62,8.47,19,142,117));
                        Stodhestaspilid stodspil40 = new Stodhestaspilid("Kormákur frá Flugumýri 2",3700,9.0,8.23,8.37,8.30,327,141,119));
                        Stodhestaspilid stodspil41 = new Stodhestaspilid("Huginn frá Haga 1",0200,10.0,7.84,9.05,8.57,218,140,119));
                        Stodhestaspilid stodspil42 = new Stodhestaspilid("Ás frá Ármóti",2510,9.5,8.00,8.75,8.45,64,142,121));
                        Stodhestaspilid stodspil43 = new Stodhestaspilid("Baugur frá Víðisnesi 2",1514,9.0,8.33,8.58,8.48,68,142,121));
                        Stodhestaspilid stodspil44 = new Stodhestaspilid("Dagur frá Strandarhöfði",4500,8.5,7.96,8.26,8.14,56,138,113));
                        Stodhestaspilid stodspil45 = new Stodhestaspilid("Leiknir frá Vakurstöðum",2520,9.5,8.04,8.44,8.28,153,137,109));
                        Stodhestaspilid stodspil46 = new Stodhestaspilid("Grunur frá Oddhóli",2520,9.0,8.02,8.38,8.23,84,137,117));
                        Stodhestaspilid stodspil47 = new Stodhestaspilid("Natan frá Ketilsstöðum",3500,9.0,8.23,8.51,8.40,22,142,119));
                        Stodhestaspilid stodspil48 = new Stodhestaspilid("Glymur frá Árgerði",1500,9.0,8.18,8.53,8.39,35,140,113));
                        Stodhestaspilid stodspil49 = new Stodhestaspilid("Adam frá Ásmundarsstöðum",2700,9.0,8.17,8.49,8.36,345,137,124));
                        Stodhestaspilid stodspil50 = new Stodhestaspilid("Glampi frá vatnsleysu",2790,9.0,7.85,8.68,8.35,401,138,113));
                        Stodhestaspilid stodspil51 = new Stodhestaspilid("Galsi frá Sauðárkróki",7500,9.8,7.87,9.01,8.44,485,137,116));
                        Stodhestaspilid stodspil52 = new Stodhestaspilid("Markús frá Langholtsparti",2700,9.5,7.99,8.61,8.36,293,140,127));
                        Stodhestaspilid stodspil53 = new Stodhestaspilid("Vilmundur frá Feti",2700,9.5,7.96,8.95,8.56,59,138,130));
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
