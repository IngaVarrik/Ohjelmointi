/* 
 * Huutokaupan aikana myydään useita artikkeleita, joista jokaiselle voi huutojen perusteella määräytyä 
 * erilainen hinta.Kirjoita huutokauppameklarin käyttöön tuleva ohjelma, joka näyttää huutokaupan etenemisen 
 * meklarin antamien yksittäisten hintojen perusteella. Meklari haluaa nähdä jokaisen myydyn artikkelin jälkeen
 * kuinka monta artikkelia on tähän mennessä myyty, oliko viimeisin myyty artikkeli kalliimpi vai halvempi
 * kuin edellinen, mikä on ollut korkein yhdestä artikkelista saatu hinta ja kuinka paljon rahaa pitää vielä
 * saada, jotta huutokaupan tavoitteeksi asetettu summa täyttyy. Lopuksi ohjelman tulee ilmoittaa kalleimman
 * huutokaupassa myydyn artikkelin hinta sekä tieto siitä, täyttyikö meklarin antama tavoite. Tavoitesumman
 * meklari syöttää ennen huutokaupan alkua. 
 */

using System;

namespace Huutokauppa
{

    class Program
    {
        static bool AnnaSumma(string ohje, out double maara)
        {
            maara = 0;
            bool status = false;
            while (status == false)
            {
                Console.WriteLine(ohje);
                string input = Console.ReadLine();
                if (input == "x") return false;
                status = double.TryParse(input, out maara);
                if (status == false) Console.WriteLine("Antamaasi syötettä ei voida lukea summaksi.");
                if (maara < 0) { 
                    Console.WriteLine("Sinun pitää antaa positiivinen lukumäärä.");
                    status = false;
                }
            }
            return true;
        }
        static double korkeinmyyntihinta = 0;
        static double tavoitesumma = 0;
        static double kokonaismyynti = 0;

        static void TeeHuutokauppaa()
        {
            int montakoMyyty = 0;
            double viimeisinMyytyHinta = 0; 
            double paljonkopuuttuu = 0;

            Console.WriteLine("Tervetuloa huutokauppa sovellukseen!\n");
            bool status = AnnaSumma("Kerro huutokaupan tavoite summa.", out tavoitesumma);
            if (status == false) return;

            paljonkopuuttuu = tavoitesumma;
            while (true)
            {
                double myyntihinta = 0;
                status = AnnaSumma("Kerro tavaran myyntihinta. (Lopetus syöttämällä x)", out myyntihinta);
                if (status == false) return;
                montakoMyyty++;
                kokonaismyynti = kokonaismyynti + myyntihinta;
                korkeinmyyntihinta = Math.Max(korkeinmyyntihinta, myyntihinta);
                if (viimeisinMyytyHinta != 0)
                {
                    if (viimeisinMyytyHinta > myyntihinta) { Console.WriteLine("Myyty tuote oli halvempi kuin edellinen."); }
                    if (viimeisinMyytyHinta < myyntihinta) { Console.WriteLine("Myyty tuote oli kalliimpi kuin edellinen."); }
                    if (viimeisinMyytyHinta == myyntihinta) { Console.WriteLine("Myyty tuote oli saman hintainen kuin edellinen."); }
                }
                viimeisinMyytyHinta = myyntihinta;
                Console.WriteLine("Tavaroita on myyty " + montakoMyyty + " kappaletta.");
                paljonkopuuttuu = paljonkopuuttuu - viimeisinMyytyHinta;
                if (paljonkopuuttuu > 0) { 
                    Console.WriteLine("Tavoitesummasta puuttuu " + paljonkopuuttuu + " euroa."); 
                }
            }
        }
        static void Main(string[] args)
        {
            TeeHuutokauppaa();
            Console.WriteLine("Kalleiman tuotteen hinta oli " + korkeinmyyntihinta + " euroa.");
            if (kokonaismyynti >= tavoitesumma)
            {
                Console.WriteLine("Tavoitesumma " + tavoitesumma + " täyttyi. Kokonaismyynti oli " + kokonaismyynti); 
            }
            else
            {
                Console.WriteLine("Tavoitesumma " + tavoitesumma + " ei täyttynyt. Kokonaismyynti oli " + kokonaismyynti);
            }
        }
    }
}