using System;

namespace guessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {

            //programm genereerib juhusliku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvamta, siis ta on mängu võitnud;
            //katsete arv on piiramatu.
            //programm genereerib juhuslikku numbrit ühthe korda.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            

            bool loopActive = true;

            while (loopActive)
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
                    Console.WriteLine($"Vale, proovi uuesti");
                }
            }
            Console.WriteLine($"Kena päeva võitja");
        }

    }
}
