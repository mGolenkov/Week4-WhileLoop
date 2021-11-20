using System;

namespace LoopsAndRandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada PIN-koodi;
            //programm võrdleb sisestatud PIN-koodi arvuga 1234;
            //kui sisestatud PIN-kood 1234,  siis kuvab "Tere tulemast";
            //kui sisestatud PIN-kood on midagi muud, siis kuvab "Vale PIN. Proovi uuesti";
            //kasutajal on kolm katset.

            int i = 0;

            while (i < 3) //While - Loop
            {
                Console.WriteLine("Sisesta PIN");
                int userPin = Convert.ToInt32(Console.ReadLine());

                if (userPin == 1234)
                {
                    Console.WriteLine("Tere tulemast");
                    break;
                }
                else
                {
                    //i = i + 1;
                    i = i++; //ei toimi kolm katset
                    Console.WriteLine($"Vale PIN. {3 - i} katset jäänud.");
                }
            }


            Console.WriteLine("Kena päeva");
        }
    }
}
