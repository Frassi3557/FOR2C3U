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
                        List<Hrutspilið> TempStokkur = new List<Hrutspilið>();

                        
                          int teljariSpil = 0;
                         // int flokkur = 0;
                         // var NotFirstCard = spilNot.First();

                          //int NotFirstCard = spilNot[1];
                          
                         
                        

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
                        Console.Clear();

                        Console.WriteLine("Thú ert med " + spilNot.Count + " spil á hendi");
                        Console.WriteLine("Thitt spil notanda");
                        Console.WriteLine(spilNot[0]);
                        //spilNot.ForEach(Console.WriteLine);

                        int val2 = 0;

                        Console.WriteLine();
                        Console.WriteLine("Veldu nr hvad tu vilt bera saman.");
                        val2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine();
                        Console.WriteLine("Tölva er med " + spilTolvu.Count + " spil á hendi");
                        Console.WriteLine("Spil Tölvu");
                        Console.WriteLine(spilTolvu[0]);

                        Console.WriteLine();
                        if (val2 == 1)
                        {
                            Console.WriteLine("Þú valdir: " + spilNot[0].Flokkur1);
                            Console.WriteLine("Tölvan er med: " + spilTolvu[0].Flokkur1);
                            Console.WriteLine("");
                            if (spilNot[0].Flokkur1 > spilTolvu[0].Flokkur1)
                            {
                                Console.WriteLine("Þú vannst");
                            }
                            else if (spilNot[0].Flokkur1 < spilTolvu[0].Flokkur1)
                            {
                                Console.WriteLine("Tölvan vann");
                            }
                            else
                            {
                                Console.WriteLine("Jafntefli");
                            }

                        }
                        if (val2 == 2)
                        {
                            Console.WriteLine("Þú valdir: " + spilNot[0].Flokkur2);
                            Console.WriteLine("Tölvan er med: " + spilTolvu[0].Flokkur2);
                            Console.WriteLine("");
                            if (spilNot[0].Flokkur2 > spilTolvu[0].Flokkur2)
                            {
                                Console.WriteLine("Þú vannst");
                            }
                            else if (spilNot[0].Flokkur2 < spilTolvu[0].Flokkur2)
                            {
                                Console.WriteLine("Tölvan vann");
                            }
                            else
                            {
                                Console.WriteLine("Jafntefli");
                            }

                        }
                        if (val2 == 3)
                        {
                            Console.WriteLine("Þú valdir: " + spilNot[0].Flokkur3);
                            Console.WriteLine("Tölvan er med: " + spilTolvu[0].Flokkur3);
                            Console.WriteLine("");
                            if (spilNot[0].Flokkur3 > spilTolvu[0].Flokkur3)
                            {
                                Console.WriteLine("Þú vannst");
                            }
                            else if (spilNot[0].Flokkur3 < spilTolvu[0].Flokkur3)
                            {
                                Console.WriteLine("Tölvan vann");
                            }
                            else
                            {
                                Console.WriteLine("Jafntefli");
                            }

                        }
                        if (val2 == 4)
                        {
                            Console.WriteLine("Þú valdir: " + spilNot[0].Flokkur4);
                            Console.WriteLine("Tölvan er med: " + spilTolvu[0].Flokkur4);
                            Console.WriteLine("");
                            if (spilNot[0].Flokkur4 > spilTolvu[0].Flokkur4)
                            {
                                Console.WriteLine("Þú vannst");
                            }
                            else if (spilNot[0].Flokkur4 < spilTolvu[0].Flokkur4)
                            {
                                Console.WriteLine("Tölvan vann");
                            }
                            else
                            {
                                Console.WriteLine("Jafntefli");
                            }

                        }
                        if (val2 == 5)
                        {
                            Console.WriteLine("Þú valdir: " + spilNot[0].Flokkur5);
                            Console.WriteLine("Tölvan er med: " + spilTolvu[0].Flokkur5);
                            Console.WriteLine("");
                            if (spilNot[0].Flokkur5 > spilTolvu[0].Flokkur5)
                            {
                                Console.WriteLine("Þú vannst");
                            }
                            else if (spilNot[0].Flokkur5 < spilTolvu[0].Flokkur5)
                            {
                                Console.WriteLine("Tölvan vann");
                            }
                            else
                            {
                                Console.WriteLine("Jafntefli");
                            }

                        }
                        if (val2 == 6)
                        {
                            Console.WriteLine("Þú valdir: " + spilNot[0].Flokkur6);
                            Console.WriteLine("Tölvan er med: " + spilTolvu[0].Flokkur6);
                            Console.WriteLine("");
                            if (spilNot[0].Flokkur6 > spilTolvu[0].Flokkur6)
                            {
                                Console.WriteLine("Þú vannst");
                            }
                            else if (spilNot[0].Flokkur6 < spilTolvu[0].Flokkur6)
                            {
                                Console.WriteLine("Tölvan vann");
                            }
                            else
                            {
                                Console.WriteLine("Jafntefli");
                            }

                        }
                        if (val2 == 7)
                        {
                            Console.WriteLine("Þú valdir: " + spilNot[0].Flokkur7);
                            Console.WriteLine("Tölvan er med: " + spilTolvu[0].Flokkur7);
                            Console.WriteLine("");
                            if (spilNot[0].Flokkur7 > spilTolvu[0].Flokkur7)
                            {
                                Console.WriteLine("Þú vannst");
                            }
                            else if (spilNot[0].Flokkur7 < spilTolvu[0].Flokkur7)
                            {
                                Console.WriteLine("Tölvan vann");
                            }
                            else
                            {
                                Console.WriteLine("Jafntefli");
                            }

                        }

                       // TempStokkur.Add()

                        break;

                    case 2:

                        Random randomspil2 = new Random();


                        List<Stodhestaspilid> spilNot2 = new List<Stodhestaspilid>();
                        List<Stodhestaspilid> spilTolvu2 = new List<Stodhestaspilid>();
                        List<Stodhestaspilid> stokkur2 = new List<Stodhestaspilid>();

                        int teljariSpil2 = 0;

                        stokkur2.Add(new Stodhestaspilid("Þristur frá Feti", 2510, 9, 8.14, 8.35, 8.27, 275, 141, 117));
                        stokkur2.Add(new Stodhestaspilid("Þokki frá Kýrholti",2200,9.5,8.28, 9.04,8.73,175,143,123));
                        stokkur2.Add(new Stodhestaspilid("Sveinn-Hervar frá Þúfu",2500,9.0,8.06,8.38,8.25,261,139,119));
                        stokkur2.Add(new Stodhestaspilid("Andvari frá Ey 1",1600,9.0,8.33,8.40,8.36,500,136,120));
                        stokkur2.Add(new Stodhestaspilid("Borði frá Fellskoti",1510,9.5,7.89,8.48,8.24,83,141,119));
                        stokkur2.Add(new Stodhestaspilid("Rökkvi frá Harlaugsstöðum",2500,9.0,8.13,8.48,8.34,261,141,109));
                        stokkur2.Add(new Stodhestaspilid("Kraftur frá Efri-Þverá",3400,9.0,8.20,8.48,8.37,24,143,115));
                        stokkur2.Add(new Stodhestaspilid("Oddur frá Selfossi",4521,9.5,8.10,8.86,8.48,391,136,118));
                        stokkur2.Add(new Stodhestaspilid("Fursti frá Stóra-Hofi",3500,9.0,8.09,8.78,8.51,36,143,121));
                        stokkur2.Add(new Stodhestaspilid("Glymur frá Innri-Skeljabrekku",8600,9.0,7.98,8.65,8.38,87,142,115));
                        stokkur2.Add(new Stodhestaspilid("Klettur frá Hvammi",0210,9.5,8.43,8.54,8.49,211,140,112));
                        stokkur2.Add(new Stodhestaspilid("Aðall frá Nýjabæ",3500,9.5,8.13,8.97,8.64,82,143,118));
                        stokkur2.Add(new Stodhestaspilid("Gígjar frá Auðsholtshjáleigu",2520,9.5,7.98,8.78,8.46,168,136,123));
                        stokkur2.Add(new Stodhestaspilid("Hruni frá Breiðumörk 2",7510,9.0,7.61,8.41,8.09,34,133,108));
                        stokkur2.Add(new Stodhestaspilid("Kjarkur frá Egilsstaðabæ",2700,9.5,7.85,8.71,8.28,354,133,106));
                        stokkur2.Add(new Stodhestaspilid("Hróður frá Refssöðum",1590,9.5,7.94,8.69,8.39,344,135,125));
                        stokkur2.Add(new Stodhestaspilid("Illingur frá Tóftum",1510,9.0,8.45,8.81,8.67,195,137,124));
                        stokkur2.Add(new Stodhestaspilid("Sigur frá Hólabaki",1620,9.0,8.24,7.85,8.01,5,141,112));
                        stokkur2.Add(new Stodhestaspilid("Stáli frá kjarri",7500,9.5,8.26,9.09,8.76,70,140,121));
                        stokkur2.Add(new Stodhestaspilid("Gári frá Auðsholtshjáleigu",1600,9.5,8.87,8.47,8.63,162,143,125));
                        stokkur2.Add(new Stodhestaspilid("Hugi frá Hafsteinsstöðum",1551,9.5,8.13,8.49,8.31,370,137,119));
                        stokkur2.Add(new Stodhestaspilid("Funi frá Vindási",1600,9.0,8.08,8.65,8.42,29,144,122));
                        stokkur2.Add(new Stodhestaspilid("Orri frá Þúfu",2500,9.5,8.08,8.61,8.34,1049,136,127));
                        stokkur2.Add(new Stodhestaspilid("Þóroddur frá Þóroddsstöðum",1521,9.0,8.28,9.04,8.74,218,142,126));
                        stokkur2.Add(new Stodhestaspilid("Klerkur frá Bjarnanesi 1",2500,9.0,7.52,7.55,7.54,11,145,104));
                        stokkur2.Add(new Stodhestaspilid("Álfur frá Selfossi",1510,9.5,7.98,8.44,8.26,82,140,124));
                        stokkur2.Add(new Stodhestaspilid("Keilir frá Miðsitju",6600,9.5,8.42,8.77,8.63,446,138,119));
                        stokkur2.Add(new Stodhestaspilid("Krummi frá Blessastöðum 1a",0230,9.0,8.13,8.55,8.38,86,141,120));
                        stokkur2.Add(new Stodhestaspilid("Akkur frá Brautarholti",1520,9.5,8.23,8.80,8.57,72,140,122));
                        stokkur2.Add(new Stodhestaspilid("Roði frá Múla",1500,8.5,8.30,7.84,8.07,294,138,119));
                        stokkur2.Add(new Stodhestaspilid("Örn frá Efri-Gegnishólum",1510,9.0,7.89,8.45,8.23,18,135,120));
                        stokkur2.Add(new Stodhestaspilid("Blær frá Torfunesi",2500,9.5,8.17,8.80,8.55,87,141,126));
                        stokkur2.Add(new Stodhestaspilid("Gustur frá Hóli",0100,10.0,8.13,9.01,8.57,644,136,124));
                        stokkur2.Add(new Stodhestaspilid("Moli frá Skriðu",2700,9.5,7.98,8.36,8.21,80,141,110));
                        stokkur2.Add(new Stodhestaspilid("Þorsti frá Garði",1722,9.0,8.11,8.60,8.40,57,140,116));
                        stokkur2.Add(new Stodhestaspilid("Sær frá Bakkakoti",7200,9.5,7.96,9.05,8.62,344,143,129));
                        stokkur2.Add(new Stodhestaspilid("Eldjárn frá Tjaldhólum",1500,10.0,8.09,8.85,8.55,132,140,119));
                        stokkur2.Add(new Stodhestaspilid("Aron frá Strandarhöfði",2200,9.5,8.22,8.75,8.54,276,144,122));
                        stokkur2.Add(new Stodhestaspilid("Aris frá Akureyri",2500,9.0,8.26,8.62,8.47,19,142,117));
                        stokkur2.Add(new Stodhestaspilid("Kormákur frá Flugumýri 2",3700,9.0,8.23,8.37,8.30,327,141,119));
                        stokkur2.Add(new Stodhestaspilid("Huginn frá Haga 1",0200,10.0,7.84,9.05,8.57,218,140,119));
                        stokkur2.Add(new Stodhestaspilid("Ás frá Ármóti",2510,9.5,8.00,8.75,8.45,64,142,121));
                        stokkur2.Add(new Stodhestaspilid("Baugur frá Víðisnesi 2",1514,9.0,8.33,8.58,8.48,68,142,121));
                        stokkur2.Add(new Stodhestaspilid("Dagur frá Strandarhöfði",4500,8.5,7.96,8.26,8.14,56,138,113));
                        stokkur2.Add(new Stodhestaspilid("Leiknir frá Vakurstöðum",2520,9.5,8.04,8.44,8.28,153,137,109));
                        stokkur2.Add(new Stodhestaspilid("Grunur frá Oddhóli",2520,9.0,8.02,8.38,8.23,84,137,117));
                        stokkur2.Add(new Stodhestaspilid("Natan frá Ketilsstöðum",3500,9.0,8.23,8.51,8.40,22,142,119));
                        stokkur2.Add(new Stodhestaspilid("Glymur frá Árgerði",1500,9.0,8.18,8.53,8.39,35,140,113));
                        stokkur2.Add(new Stodhestaspilid("Adam frá Ásmundarsstöðum",2700,9.0,8.17,8.49,8.36,345,137,124));
                        stokkur2.Add(new Stodhestaspilid("Glampi frá vatnsleysu",2790,9.0,7.85,8.68,8.35,401,138,113));
                        stokkur2.Add(new Stodhestaspilid("Galsi frá Sauðárkróki",7500,9.8,7.87,9.01,8.44,485,137,116));
                        stokkur2.Add(new Stodhestaspilid("Markús frá Langholtsparti",2700,9.5,7.99,8.61,8.36,293,140,127));

                        while (stokkur2.Count() > 0)
                        {
                            int randtala2 = randomspil2.Next(0, stokkur2.Count());
                            if (teljariSpil2 % 2 == 0)
                            {
                                //spilNot er Listi
                                spilNot2.Add(stokkur2[randtala2]);

                            }

                            else
                            {
                                //spilTolvu er Listi
                                spilTolvu2.Add(stokkur2[randtala2]);
                            }

                            teljariSpil2++;
                            stokkur2.Remove(stokkur2[randtala2]);
                        }

                       Console.Clear();

                        Console.WriteLine("Thú ert med " + spilNot2.Count + " spil á hendi");
                        Console.WriteLine("Thitt spil notanda");
                        Console.WriteLine(spilNot2[0]);
                        //spilNot.ForEach(Console.WriteLine);

                        int val3 = 0;

                        Console.WriteLine();
                        Console.WriteLine("Veldu nr hvad tu vilt bera saman.");
                        val3 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine();
                        Console.WriteLine("Tölva er med " + spilTolvu2.Count + " spil á hendi");
                        Console.WriteLine("Spil Tölvu");
                        Console.WriteLine(spilTolvu2[0]);

                        Console.WriteLine();
                        if (val3 == 1)
                        {
                            Console.WriteLine("Þú valdir: " + spilNot2[0].Flokkur1);
                            Console.WriteLine("Tölvan er med: " + spilTolvu2[0].Flokkur1);
                            Console.WriteLine("");
                            if (spilNot2[0].Flokkur1 > spilTolvu2[0].Flokkur1)
                            {
                                Console.WriteLine("Þú vannst");
                            }
                            else if (spilNot2[0].Flokkur1 < spilTolvu2[0].Flokkur1)
                            {
                                Console.WriteLine("Tölvan vann");
                            }
                            else
                            {
                                Console.WriteLine("Jafntefli");
                            }

                        }
                        if (val3 == 2)
                        {
                            Console.WriteLine("Þú valdir: " + spilNot2[0].Flokkur2);
                            Console.WriteLine("Tölvan er med: " + spilTolvu2[0].Flokkur2);
                            Console.WriteLine("");
                            if (spilNot2[0].Flokkur2 > spilTolvu2[0].Flokkur2)
                            {
                                Console.WriteLine("Þú vannst");
                            }
                            else if (spilNot2[0].Flokkur2 < spilTolvu2[0].Flokkur2)
                            {
                                Console.WriteLine("Tölvan vann");
                            }
                            else
                            {
                                Console.WriteLine("Jafntefli");
                            }

                        }
                        if (val3 == 3)
                        {
                            Console.WriteLine("Þú valdir: " + spilNot2[0].Flokkur3);
                            Console.WriteLine("Tölvan er med: " + spilTolvu2[0].Flokkur3);
                            Console.WriteLine("");
                            if (spilNot2[0].Flokkur3 > spilTolvu2[0].Flokkur3)
                            {
                                Console.WriteLine("Þú vannst");
                            }
                            else if (spilNot2[0].Flokkur3 < spilTolvu2[0].Flokkur3)
                            {
                                Console.WriteLine("Tölvan vann");
                            }
                            else
                            {
                                Console.WriteLine("Jafntefli");
                            }

                        }
                        if (val3 == 4)
                        {
                            Console.WriteLine("Þú valdir: " + spilNot2[0].Flokkur4);
                            Console.WriteLine("Tölvan er med: " + spilTolvu2[0].Flokkur4);
                            Console.WriteLine("");
                            if (spilNot2[0].Flokkur4 > spilTolvu2[0].Flokkur4)
                            {
                                Console.WriteLine("Þú vannst");
                            }
                            else if (spilNot2[0].Flokkur4 < spilTolvu2[0].Flokkur4)
                            {
                                Console.WriteLine("Tölvan vann");
                            }
                            else
                            {
                                Console.WriteLine("Jafntefli");
                            }

                        }
                        if (val3 == 5)
                        {
                            Console.WriteLine("Þú valdir: " + spilNot2[0].Flokkur5);
                            Console.WriteLine("Tölvan er med: " + spilTolvu2[0].Flokkur5);
                            Console.WriteLine("");
                            if (spilNot2[0].Flokkur5 > spilTolvu2[0].Flokkur5)
                            {
                                Console.WriteLine("Þú vannst");
                            }
                            else if (spilNot2[0].Flokkur5 < spilTolvu2[0].Flokkur5)
                            {
                                Console.WriteLine("Tölvan vann");
                            }
                            else
                            {
                                Console.WriteLine("Jafntefli");
                            }

                        }
                        if (val3 == 6)
                        {
                            Console.WriteLine("Þú valdir: " + spilNot2[0].Flokkur6);
                            Console.WriteLine("Tölvan er med: " + spilTolvu2[0].Flokkur6);
                            Console.WriteLine("");
                            if (spilNot2[0].Flokkur6 > spilTolvu2[0].Flokkur6)
                            {
                                Console.WriteLine("Þú vannst");
                            }
                            else if (spilNot2[0].Flokkur6 < spilTolvu2[0].Flokkur6)
                            {
                                Console.WriteLine("Tölvan vann");
                            }
                            else
                            {
                                Console.WriteLine("Jafntefli");
                            }

                        }
                        if (val3 == 7)
                        {
                            Console.WriteLine("Þú valdir: " + spilNot2[0].Flokkur7);
                            Console.WriteLine("Tölvan er med: " + spilTolvu2[0].Flokkur7);
                            Console.WriteLine("");
                            if (spilNot2[0].Flokkur7 > spilTolvu2[0].Flokkur7)
                            {
                                Console.WriteLine("Þú vannst");
                            }
                            else if (spilNot2[0].Flokkur7 < spilTolvu2[0].Flokkur7)
                            {
                                Console.WriteLine("Tölvan vann");
                            }
                            else
                            {
                                Console.WriteLine("Jafntefli");
                            }

                        }

                       // TempStokkur.Add()
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
