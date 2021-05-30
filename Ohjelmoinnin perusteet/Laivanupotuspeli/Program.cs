using System;
using System.Globalization;

using System.Collections.Generic;
using System.Linq;

namespace Laivanupotus
{
    // 0 = Tyhja, 1 = Laiva, 2 = Ohi, 3 = Osuma , 4 = Upposi
    public enum RuudunStatus
    {
        Tyhja,
        Laiva,
        Ohi,
        Osuma,
        Upposi
    }
    public class Ruudukko
    {
        public string ruutuKirjain { get; set; }
        public int ruutuNumero { get; set; }
        public RuudunStatus Status { get; set; } = RuudunStatus.Tyhja;
    }
    public class Pelaaja
    {
        public bool simuloituPelaaja = false;
        public string käyttäjä { get; set; }
        public List<Ruudukko> LaivanPaikat { get; set; } = new List<Ruudukko>();
        public List<Ruudukko> AmmututPaikat { get; set; } = new List<Ruudukko>();
    }
    public static class Peli
    {
        public static void AlustaPeliAlue(Pelaaja pelaaja)
        {
            List<string> kirjaimet = new List<string>
            {
                "A",
                "B",
                "C",
                "D",
                "E"
            };

            List<int> numerot = new List<int>
            {
                1,
                2,
                3,
                4,
                5
            };
            foreach (string kirjain in kirjaimet)
            {
                foreach (int numero in numerot)
                {
                    LisääRuutu(pelaaja, kirjain, numero);
                }
            }
        }
        private static void LisääRuutu(Pelaaja pelaaja, string kirjain, int numero)
        {
            Ruudukko ruutu = new Ruudukko
            {
                ruutuKirjain = kirjain,
                ruutuNumero = numero,
                Status = RuudunStatus.Tyhja
            };
            pelaaja.AmmututPaikat.Add(ruutu);
        }
        public static bool OnkoPelaajaAktiivinen(Pelaaja pelaaja)
        {
            bool onkoAktiivinen = false;

            foreach (var laiva in pelaaja.LaivanPaikat)
            {
                if (laiva.Status != RuudunStatus.Upposi)
                {
                    onkoAktiivinen = true;
                }
            }
            return onkoAktiivinen;
        }

        public static bool AsetaLaiva(Pelaaja pelaaja, string paikka)
        {
            bool output = false;
            (string rivi, int sarake) = ParsiRiviJaSarake(paikka);

            bool onSopivaPaikka = TarkastaRuudunPaikka(pelaaja, rivi, sarake);
            bool onkoPaikkaVapana = TarkistaLaivanPaikka(pelaaja, rivi, sarake);

            if (onSopivaPaikka && onkoPaikkaVapana)
            {

                Ruudukko r = new Ruudukko();
                r.ruutuKirjain = rivi.ToUpper();
                r.ruutuNumero = sarake;
                r.Status = RuudunStatus.Laiva;

                pelaaja.LaivanPaikat.Add(r);


                output = true;
            }
            return output;
        }
        private static bool TarkistaLaivanPaikka(Pelaaja pelaaja, string rivi, int sarake)
        {
            bool onSopivaPaikka = true;

            foreach (var laiva in pelaaja.LaivanPaikat)
            {
                if (laiva.ruutuKirjain == rivi.ToUpper() && laiva.ruutuNumero == sarake)
                {
                    onSopivaPaikka = false;
                }
            }
            return onSopivaPaikka;
        }
        private static bool TarkastaRuudunPaikka(Pelaaja pelaaja, string rivi, int sarake)
        {
            bool onkoSopivaPaikka = false;

            foreach (var laiva in pelaaja.AmmututPaikat)
            {
                if (laiva.ruutuKirjain == rivi.ToUpper() && laiva.ruutuNumero == sarake)
                {
                    onkoSopivaPaikka = true;
                }
            }
            return onkoSopivaPaikka;
        }
        public static int AmmuttuLukumäärä(Pelaaja pelaaja)
        {
            int laukausLukumäärä = 0;

            foreach (var laukaus in pelaaja.AmmututPaikat)
            {
                if (laukaus.Status != RuudunStatus.Tyhja)
                {
                    laukausLukumäärä += 1;
                }
            }
            return laukausLukumäärä;
        }
        public static (string rivi, int sarake) ParsiRiviJaSarake(string laukaus)
        {
            string rivi = "";
            int sarake = 0;

            if (laukaus.Length != 2)
            {
                throw new ArgumentException("Tätä laukausta ei hyväksytä:" + laukaus);
            }
            char[] laukausTaulukko = laukaus.ToArray();

            rivi = laukausTaulukko[0].ToString();
            sarake = int.Parse(laukausTaulukko[1].ToString());

            return (rivi, sarake);
        }
        public static bool Tarkastalaukaus(Pelaaja pelaaja, string rivi, int sarake)
        {
            bool kelpaakoLaukaus = false;

            foreach (var ruutu in pelaaja.AmmututPaikat)
            {
                if (ruutu.ruutuKirjain == rivi.ToUpper() && ruutu.ruutuNumero == sarake)
                {
                    if (ruutu.Status == RuudunStatus.Tyhja)
                    {
                        kelpaakoLaukaus = true;
                    }
                }
            }
            return kelpaakoLaukaus;
        }
        public static bool TutkiLaukauksenSeuraus(Pelaaja opponent, string rivi, int sarake)
        {
            bool onkoOsuma = false;

            foreach (var laiva in opponent.LaivanPaikat)
            {
                if (laiva.ruutuKirjain == rivi.ToUpper() && laiva.ruutuNumero == sarake)
                {
                    onkoOsuma = true;
                    laiva.Status = RuudunStatus.Upposi;
                }
            }
            return onkoOsuma;
        }
        public static void TalletaAmmuksenTulos(Pelaaja pelaaja, string rivi, int sarake, bool onkoOsuma)
        {
            foreach (var ruutu in pelaaja.AmmututPaikat)
            {
                if (ruutu.ruutuKirjain == rivi.ToUpper() && ruutu.ruutuNumero == sarake)
                {
                    if (onkoOsuma)
                    {
                        ruutu.Status = RuudunStatus.Osuma;
                    }
                    else
                    {
                        ruutu.Status = RuudunStatus.Ohi;
                    }
                }
            }

        }
    }
    public static class TulostaKonsoliin
    {

        public static string KysyPelaajanNimi()
        {
            Console.Write("Mikä on nimesi?: ");
            string outputRaw = Console.ReadLine().Trim();
            string output = new CultureInfo("fi-FI").TextInfo.ToTitleCase(outputRaw);

            return output;
        }
        public static Pelaaja LuoPelaaja()
        {
            Pelaaja output = new Pelaaja();

            Console.WriteLine("Anna pelaajan tiedot: \n");

            // Kysyy pelaajan nimen.
            output.käyttäjä = KysyPelaajanNimi();

            // Alustetaan pelialue.
            Peli.AlustaPeliAlue(output);

            // Kysyy pelaajalta mihin laiva sijoitetaan?

            SijoitaLaivat(output);

            // Tyhjennetään konsoli
            Console.Clear();

            return output;
        }
        public static Pelaaja LuoSimuloituPelaaja()
        {
            Pelaaja output = new Pelaaja();
            output.simuloituPelaaja = true;

            output.käyttäjä = "Tietokone";

            // Alustetaan pelialue.
            Peli.AlustaPeliAlue(output);

            // Sijoitetaan laivat.
            SijoitaLaivatSatunnaisesti(output);

            // Tyhjennetään konsoli
            Console.Clear();
            return output;
        }
        public static string NumeroKirjaimeksi(int i)
        {
            if (i == 1) return "a";
            if (i == 2) return "b";
            if (i == 3) return "c";
            if (i == 4) return "d";
            if (i == 5) return "e";
            return "x";
        }
        private static void SijoitaLaivatSatunnaisesti(Pelaaja pelaaja)
        {
            do
            {
                Random rnd = new Random();

                int x = rnd.Next(1, 6);
                int y = rnd.Next(1, 6);
                string ys = NumeroKirjaimeksi(y);
                string paikka = ys + Convert.ToString(x);

                bool OnkoOikeaPaikanFormaatti = false;

                try
                {
                    OnkoOikeaPaikanFormaatti = Peli.AsetaLaiva(pelaaja, paikka);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("  Virhe: " + ex.Message);
                }

                if (OnkoOikeaPaikanFormaatti == false)
                {
                    Console.WriteLine("Paikka ei ollut oikeassa formaattissa. Ole hyvä ja yrita uudestaan.");
                }
            } while (pelaaja.LaivanPaikat.Count < 1);
        }
        private static void SijoitaLaivat(Pelaaja pelaaja)
        {
            do
            {
                Console.Write($"  Mihin sijoitetaan laiva {pelaaja.LaivanPaikat.Count + 1}: ");
                string paikka = Console.ReadLine().Trim();

                bool OnkoOikeanPaikanFormaatti = false;

                try
                {
                    OnkoOikeanPaikanFormaatti = Peli.AsetaLaiva(pelaaja, paikka);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Virhe: " + ex.Message);
                }
                if (OnkoOikeanPaikanFormaatti == false)
                {
                    Console.WriteLine("Paikka ei ollut oikeassa formaattissa. Ole hyvä ja yrita uudestaan.");
                }
            } while (pelaaja.LaivanPaikat.Count < 1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Tervetuloa laivanupotukseen!");
            Console.WriteLine("");


            Pelaaja aktiivinenPelaja = TulostaKonsoliin.LuoPelaaja();
            Pelaaja vastustaja = TulostaKonsoliin.LuoSimuloituPelaaja();
            Pelaaja voittaja = null;

            do
            {
                NäytäPelialue(aktiivinenPelaja);

                TallennaPelaajanAmmunta(aktiivinenPelaja, vastustaja);

                bool jatketaankoPelia = Peli.OnkoPelaajaAktiivinen(vastustaja);

                if (jatketaankoPelia == true)
                {
                    (aktiivinenPelaja, vastustaja) = (vastustaja, aktiivinenPelaja);
                }
                else
                {
                    voittaja = aktiivinenPelaja;
                }

            } while (voittaja == null);

            Console.WriteLine($"  Onnittelut {voittaja.käyttäjä} voiton johdosta!");
            Console.WriteLine($" Voitton kului {Peli.AmmuttuLukumäärä(voittaja)} ammusta.");
            Console.WriteLine();

            NäytäPelialue(voittaja);

            Console.WriteLine("Paina enter lopettaaksesi...");
            Console.ReadKey();
            Console.Clear();
        }
        private static void TallennaPelaajanAmmunta(Pelaaja aktiivinenPelaaja, Pelaaja opponent)
        {
            bool onkkelvollinenLaukaus = false;
            string rivi = "";
            int sarake = 0;

            do
            {
                string laukaus;
                if (aktiivinenPelaaja.simuloituPelaaja)
                    laukaus = KysyAmmunnanKohdeRuutuTietokoneelta(aktiivinenPelaaja);
                else
                    laukaus = KysyAmmunnanKohdeRuutuPelaajalta(aktiivinenPelaaja);
                try
                {
                    (rivi, sarake) = Peli.ParsiRiviJaSarake(laukaus);
                    onkkelvollinenLaukaus = Peli.Tarkastalaukaus(aktiivinenPelaaja, rivi, sarake);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Virhe: " + ex.Message);
                    onkkelvollinenLaukaus = false;
                }

                if (onkkelvollinenLaukaus == false && !aktiivinenPelaaja.simuloituPelaaja)
                {
                    Console.WriteLine("Paikka ei kelpaa.  Ole hyvä ja yritä uudelleen.");
                }
            } while (onkkelvollinenLaukaus == false);

            bool onkoOsuma = Peli.TutkiLaukauksenSeuraus(opponent, rivi, sarake);

            Peli.TalletaAmmuksenTulos(aktiivinenPelaaja, rivi, sarake, onkoOsuma);

            TulostaLaukauksenSeuraus(rivi, sarake, onkoOsuma);
        }
        private static void TulostaLaukauksenSeuraus(string rivi, int sarake, bool onkoOsuma)
        {
            if (onkoOsuma)
            {
                Console.WriteLine($"  {rivi}{sarake} osuma!");
            }
            else
            {
                Console.WriteLine($"  {rivi}{sarake} ohi meni.");

            }
            Console.WriteLine();
        }
        private static string KysyAmmunnanKohdeRuutuPelaajalta(Pelaaja pelaaja)
        {
            Console.Write($"  {pelaaja.käyttäjä}, kerro mihin ammut: ");
            string laukaus = Console.ReadLine().Trim();

            return laukaus;
        }
        private static string KysyAmmunnanKohdeRuutuTietokoneelta(Pelaaja pelaaja)
        {
            Random rnd = new Random();

            int x = rnd.Next(1, 6);
            int y = rnd.Next(1, 6);
            string ys = TulostaKonsoliin.NumeroKirjaimeksi(y);
            string laukaus = ys + Convert.ToString(x);
            Console.WriteLine($"  {pelaaja.käyttäjä}: ammun: " + laukaus);
            return laukaus;
        }
        private static void NäytäPelialue(Pelaaja aktiivinenPelaaja)
        {
            string käsiteltäväRivi = aktiivinenPelaaja.AmmututPaikat[0].ruutuKirjain;

            foreach (var ruutu in aktiivinenPelaaja.AmmututPaikat)
            {
                if (ruutu.ruutuKirjain != käsiteltäväRivi)
                {
                    Console.WriteLine();
                    käsiteltäväRivi = ruutu.ruutuKirjain;
                }

                if (ruutu.Status == RuudunStatus.Tyhja)
                {
                    Console.Write($" {ruutu.ruutuKirjain}{ruutu.ruutuNumero} ");

                }
                else if (ruutu.Status == RuudunStatus.Osuma)
                {
                    Console.Write(" X  ");
                }
                else if (ruutu.Status == RuudunStatus.Ohi)
                {
                    Console.Write(" O  ");
                }
                else
                {
                    Console.Write(" ?  ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

