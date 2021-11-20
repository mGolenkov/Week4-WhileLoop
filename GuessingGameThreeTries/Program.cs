using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvamta, siis ta on mängu võitnud;
            //kasutajal on kolm katset, kui kasutaja ei ole suutnud kolme kastega numbrit ära arvata
            //siis mängu võidab arvuti.
            //programm genereerib juhuslikku numbrit ühthe korda.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            int i = 0;

            while(i < 3)
            {
                Console.WriteLine("Arva ära number 1 kuni 10");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber == cpuNumber)
                {
                    Console.WriteLine($"Arvasid õige number! Genereeritud number on: {cpuNumber} ");
                    break;
                }
                else
                {
                    i = i + 1;
                    Console.WriteLine($"Vale, proovi uuesti. {3 - i} katsed jäänud.");
                }

            }



        }

    }
}
