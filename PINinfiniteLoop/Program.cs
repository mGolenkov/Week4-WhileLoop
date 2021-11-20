using System;

namespace PINinfiniteLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada PIN-koodi;
            //programm võrdleb sisestatud PIN-koodi arvuga 1234;
            //kui sisestatud PIN-kood 1234,  siis kuvab "Tere tulemast";
            //kui sisestatud PIN-kood on midagi muud, siis kuvab "Vale PIN. Proovi uuesti";
            //katsete arv on piiramatu.

            bool loopActive = true; //boolean --> true/false
            int i = 0;

            while (loopActive)
            {
                Console.WriteLine("Sisesta PIN:");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if (userPIN == 1234)
                {
                    Console.WriteLine("Tere Tulemast!");
                    loopActive = false;
                }
                else
                {
                    i++; // i = i + 1;
                    Console.WriteLine("Vale PIN. Proovi uuesti");
                    Console.WriteLine($"Oled vale PIN-kood {i} korda sisestatud.");
                }

            }
            Console.WriteLine("Kena päeva");
            


        }
    }
}
