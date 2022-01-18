using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurzProgramovani_CSharp
{
    //Sestavte funkci SudaCislaZpole, která má jediný parametr: pole celých čísel.
    //Výsledkem funkce je jednorozměrné celočíselné pole, ve kterém jsou jen sudá čísla obsažená v poli parametru.
    //Funkci ověřte na zadání: sestavte program, který načte pole celých čísel ukončených nulou, která už k číslům nepatří,
    //a pak zobrazí všechna ze zadaných čísel, která jsou sudá.
    internal class F2_6
    {
        public static void Run(string[] args)
        {
            byte[] numbers = new byte[30];
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = (byte)random.Next(1, 255);
            Console.WriteLine("\nNáhodná čísla řady:\n" + string.Join(" ", numbers));
            byte[] even = SudaCislaZPole(numbers);
            Console.WriteLine("\nSudá čísla řady:\n");
            foreach (byte a in even)
                if (a > 0)
                    Console.Write("{0} ", a);
        }

        static byte[] SudaCislaZPole(byte[] numbers)
        {
            byte[] even = new byte[numbers.Length];
            byte j = 0;
            for (int i = 0; i < numbers.Length; i++)
                if (numbers[i] % 2 == 0)
                {
                    even[j] = numbers[i];
                    j++;
                }
            return even;
        }

    }
}
