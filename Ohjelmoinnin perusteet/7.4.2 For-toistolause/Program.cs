using System;

namespace Tehtävä_7._4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vaihe 2. Hyödynnä teoriaosiossa esitettyä Random -luokkaa ja luo satunnainen luku kiinteän 45:n sijaan.

            Random satluku = new Random();
            int arvonta = satluku.Next(1, 50);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("\nAnna luku näppäimistöltä väliltä 1-50");
                int numero = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nAnnettu luku: " + numero);
                Console.WriteLine();


                if (arvonta == numero)
                {
                    Console.WriteLine("Onneksi olkoon, sama luku!");
                    Console.ReadKey();
                    return;

                }
            }

            Console.WriteLine("Kierroksia 5, lopetetaan ohjelma.");
            Console.ReadKey();
            return;

        }
    }
}