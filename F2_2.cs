using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace KurzProgramovani_CSharp
{
    //Stroj na losování Sazky se porouchal.
    //Tahal sice z osudí čísla 1 až 49, ale některá opakovaně.
    //Vytvořte funkci, které se předá pole takovýchto čísel, funkce pole vrátí očištěné od druhých a dalších výskytů opakujících se čísel.
    //Nevadí, že tedy může být ve výsledku méně čísel než požadovaných pět.
    internal class F2_2
    {
        public static void Run(string[] args)
        {
            int[] numbers = new int[49];
            numbers = Enumerable.Range(1, numbers.Length).ToArray();

            Console.WriteLine("\n....Vítejte v losování Sportky....");
            Console.WriteLine("\n\nTažená čísla jsou");
            int[] numbersLotery = Losovani(numbers);

            for (int i = 0; i < numbersLotery.Length; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine(numbersLotery[i]);
            }
            Console.WriteLine("\n_____Gratulujeme všem výhercům!!!_____\n");

        }

        static int[] Losovani(int[] numbers)
        {
            Random random = new Random();
            int[] numbersLot = new int[5];
            numbers = numbers.OrderBy(x => random.Next()).ToArray();
            Array.Copy(numbers, numbersLot, numbersLot.Length);
            return numbersLot;
        }
    }
}
