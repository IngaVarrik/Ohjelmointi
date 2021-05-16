using System;

namespace Matikkapeli
{
    class Program
    {
        static int globalQuestionCount = 0;
        static int globalCorrectCount = 0;

        //asetukset
        static bool allowNegativeResults = true;
        static string RequestInput()
        {
            int playerAnswer;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "x") return input;
                if (int.TryParse(input, out playerAnswer)) return input;
                Console.WriteLine("Väärä syöte. Vastaa vyötämällä numero tai lopettamiseen x");
            }
        }
        static void Yhteenlasku()

        {
            var rand = new Random();

            Console.Write("Suorita annetut tehtävät. Lopeta vastamalla x\n ");
            int correctCount = 0;
            int questionCount = 0;
            for (questionCount = 0; ; questionCount++)
            {
                int num01 = rand.Next(11);
                int num02 = rand.Next(11);

                Console.Write($"Paljonko on {num01} plus {num02}? ");

                string input = RequestInput();
                if (input == "x") break;
                int playerAnswer = Convert.ToInt32(input);

                if (num01 + num02 == playerAnswer)
                {
                    Console.WriteLine($"{playerAnswer} on oikea vastaus!");
                    correctCount++;
                }
                else
                {
                    Console.WriteLine($"{playerAnswer} on väärä vastaus!");
                }
            }
            Console.WriteLine($"Sait {correctCount} oikein, tehtäviä oli {questionCount}");
            globalQuestionCount += questionCount;
            globalCorrectCount += correctCount;

            Console.WriteLine($"Kokonaistuloksesi on: {globalCorrectCount} oikein, suoritettuja tehtäviä {globalQuestionCount}!");
        }
        static void Kertalasku()
        {
            var rand = new Random();

            Console.Write("Suorita annetut tehtävät. Lopeta vastamalla x\n ");

            int correctCount = 0;
            int questionCount = 0;
            for (questionCount = 0; ; questionCount++)
            {
                int num01 = rand.Next(11);
                int num02 = rand.Next(11);

                Console.Write($"Paljonko on {num01} kertaa {num02}? ");

                string input = RequestInput();
                if (input == "x") break;
                int playerAnswer = Convert.ToInt32(input);


                if (num01 * num02 == playerAnswer)
                {
                    Console.WriteLine($"{playerAnswer} on oikea vastaus!");
                    correctCount++;
                }
                else
                {
                    Console.WriteLine($"{playerAnswer} on väärä vastaus!");
                }
            }
            Console.WriteLine($"Sait {correctCount} oikein, tehtäviä oli {questionCount}");
            globalQuestionCount += questionCount;
            globalCorrectCount += correctCount;

            Console.WriteLine($"Kokonaistuloksesi on: {globalCorrectCount} oikein, suoritettuja tehtäviä {globalQuestionCount}!");
        }
        static void Vähennyslasku()
        {
            var rand = new Random();

            Console.Write("Suorita annetut tehtävät. Lopeta vastamalla x\n ");

            int correctCount = 0;
            int questionCount = 0;
            for (questionCount = 0; ; questionCount++)
            {
                int num01 = rand.Next(11);
                int num02 = rand.Next(11);

                Console.Write($"Paljonko on {num01} minus {num02}? ");

                string input = RequestInput();
                if (input == "x") break;
                int playerAnswer = Convert.ToInt32(input);


                if (num01 - num02 == playerAnswer)
                {
                    Console.WriteLine($"{playerAnswer} on oikea vastaus!");
                    correctCount++;
                }
                else
                {
                    Console.WriteLine($"{playerAnswer} on väärä vastaus!");
                }
            }
            Console.WriteLine($"Sait {correctCount} oikein, tehtäviä oli {questionCount}");
            globalQuestionCount += questionCount;
            globalCorrectCount += correctCount;

            Console.WriteLine($"Kokonaistuloksesi on: {globalCorrectCount} oikein, suoritettuja tehtäviä {globalQuestionCount}!");
        }
        static void Jakolasku()
        {
            var rand = new Random();

            Console.Write("Suorita annetut tehtävät. Lopeta vastamalla x\n ");

            int correctCount = 0;
            int questionCount = 0;
            for (questionCount = 0; ; questionCount++)
            {
                double num01;
                double num02;

                do
                {
                    num01 = rand.Next(100);
                    num02 = rand.Next(100);
                } while (num01 % num02 != 0);
                Console.Write($"Paljonko on {num01} jaettu {num02}? ");

                string input = RequestInput();
                if (input == "x") break;
                int playerAnswer = Convert.ToInt32(input);


                if (num01 / num02 == playerAnswer)
                {
                    Console.WriteLine($"{playerAnswer} on oikea vastaus!");
                    correctCount++;
                }
                else
                {
                    Console.WriteLine($"{playerAnswer} on väärä vastaus!");
                }
            }
            Console.WriteLine($"Sait {correctCount} oikein, tehtäviä oli {questionCount}");
            globalQuestionCount += questionCount;
            globalCorrectCount += correctCount;

            Console.WriteLine($"Kokonaistuloksesi on: {globalCorrectCount} oikein, suoritettuja tehtäviä {globalQuestionCount}!");
        }
        static void Asetukset()
        {
            Console.WriteLine("Tervetuloa Asetuksiin.");

            while (true)
            {
                Console.WriteLine("\nValitse asetus:");
                Console.WriteLine("a: Sallitaanko negatiiviset tulokset (" + allowNegativeResults + ")");
                Console.WriteLine("x: lopetus\n");

                string valinta = Convert.ToString(Console.ReadLine());

                switch (valinta)
                {
                    case "a":
                        bool vast;
                        Console.Write("a: Sallitaanko negatiiviset tulokset (true/false) = ");
                        string input = Console.ReadLine();
                        if (bool.TryParse(input, out vast)) allowNegativeResults = vast;

                        break;
                    case "x":
                        return;
                    default:
                        break;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Tervetuloa peruslaskutoimitusten harjoitteluun! \nOhjelma kysyy toistuvasti kahden luvun summia, erotuksia, tuloja tai osamääriä.");
            while (true)
            {
                Console.WriteLine("\nValitse peli: \na: yhteenlaskeminen \nb: vähennyslaskeminen \nc: kertalaskeminen \nd: jakolaskeminen\ne: asetukset\nx: lopetus\n");
                string valinta = Convert.ToString(Console.ReadLine());

                switch (valinta)
                {
                    case "a":
                        Yhteenlasku();
                        break;
                    case "b":
                        Vähennyslasku();
                        break;
                    case "c":
                        Kertalasku();
                        break;
                    case "d":
                        Jakolasku();
                        break;
                    case "e":
                        Asetukset();
                        break;
                    case "x":
                        return;

                    default:
                        break;
                }

            }
        }
    }
}
