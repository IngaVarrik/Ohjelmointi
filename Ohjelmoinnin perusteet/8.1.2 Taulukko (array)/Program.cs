using System;

namespace Tehtävä_8._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vaihe 1. Tee ohjelma johon tallennat kolme hedelmää taulukkoon. Tulosta lopuksi taulukon sisältö.
            //Vaihe 2. Lisää ohjelmaan toiminto, missä kysyt käyttäjältä montako hedelmää hän haluaa nähdä.

            int luku;
            Console.WriteLine("Montako hedelmää haluat nähdä? 1 = yksi hedelmää, 2 =  kaksi hedelmää 3 = kolme hedelmää");
            luku = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            string[] hedelmät = { "kiivi", "banaani", "ananas" };

           for (int i=0; i <= luku-1; i++)
            {
                Console.WriteLine(hedelmät[i]);
            }
            Console.ReadKey();
        }
    }
}
