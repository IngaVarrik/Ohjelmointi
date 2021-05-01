using System;

namespace Tehtävä_7._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vaihe 1. Kirjoita C#-kielellä ohjelma, jossa määrittelet muuttujan arvonta ja alustat sen kokonaisluvulla 45.
            //Ohjelman pitää pyytää ja lukea luku näppäimistöltä ja verrata sitä muuttujan arvonta arvoon.
            //Jos käyttäjän syöttämä luku on yhtäsuuri kuin arvonta, ohjelman pitää tulostaa "Onneksi olkoon, sama luku!" ja lopettaa.
            //Muussa tapauksessa ohjelman pitää jatkaa luvun pyytämistä kunnes kierrosten määrä on 5, jolloin tulostetaan "Kierroksia 5, lopetetaan ohjelma." 

            int arvonta = 45;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("\nAnna luku näppäimistöltä ");
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