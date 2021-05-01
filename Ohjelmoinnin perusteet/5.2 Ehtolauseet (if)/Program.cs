using System;

namespace Tehtävä_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 13;

            Console.WriteLine("Oletko mien tai nainen? ");
            String sukupuoli = Console.ReadLine();

            if(sukupuoli != "mies" && sukupuoli != "nainen")
            {
                Console.WriteLine("Sinun pitää kirjoittaa mies tai nainen");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Kuinka vanha sinä olet?");

            age = Convert.ToInt32(Console.ReadLine());

            if (age <= 13)
            {
                if(sukupuoli=="mies")
                    Console.WriteLine("Mita poitsu");

                if (sukupuoli == "nainen")
                    Console.WriteLine("Mitä tyttö");
            }

            else if (age > 13 && age <= 25)
            {
                if (sukupuoli == "mies")
                    Console.WriteLine("Mitä nuorimies");

                if (sukupuoli == "nainen")
                    Console.WriteLine("Mitä nuori neitonen");
            }

            else if (age >= 26 && age <= 56)
            {
                if (sukupuoli == "mies")
                    Console.WriteLine("Olet mies parhaassa iässä");

                if (sukupuoli == "nainen")
                    Console.WriteLine("Olet nainen parhaassa iässä");
            }

            else if (age > 56)
            {
                Console.WriteLine("Tervehdys kaikille yli 56 vuotiaille "); 
            }
            Console.ReadLine();
        }
    }
}
