using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace funktiot
{
    class Program
    {
        private static string Ikatestaus(int age)
        {
            if (age <= 13)
            {
                return "Olet vielä lapsi!";
            }
            else if (age > 13 && age <= 25)
            {
                return "Olet vielä teini!";
            }
            else if (age >= 26 && age <= 56)
            {
                return "Olet parhaassa iässä!";
            }
            else if (age > 56)
            {
                return "Tervehdys kaikille yli 56 vuotiaille!";
            }
            return "Näin ei pitäisi tapahtua.";
        }

        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Kuinka vanha sinä olet?");

            age = Convert.ToInt32(Console.ReadLine());
            string ikaryhma = Ikatestaus(age);

            Console.WriteLine(ikaryhma);
            Console.ReadKey();
        }
    }
}