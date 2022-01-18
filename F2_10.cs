using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurzProgramovani_CSharp
{
    //Obtížné, třídění: Sestavte funkci SerazenePole, která má jediný parametr: pole celých čísel.
    //Výsledkem funkce je jednorozměrné celočíselné pole, ve kterém jsou stejná čísla jako v poli parametru, ale jsou seřazena vzestupně.
    //Funkci ověřte na zadání: sestavte program, který načte pole celých čísel ukončených nulou, která už k číslům nepatří,
    //a pak zobrazí všechna zadaná čísla ve vzestupném pořadí. (obdoba E14, ale třídění proběhne ve funkci)
    internal class F2_10
    {
        public static void Run(string[] args)
        {
            int[] numbers = new int[50];
            Random random = new Random();
            numbers = Enumerable.Range(0, numbers.Length).ToArray();
            numbers = numbers.OrderBy(x => random.Next()).ToArray();

            Console.WriteLine("\nGenerovaná řada:\n" + String.Join(" ", numbers));
            int[] numbersSorted = BubbleSort(numbers);
            Console.WriteLine("\nSeřazená řada (Bubble Sort):\n" + String.Join(" ", numbersSorted) + '\n');
        }

        static int[] BubbleSort(int[] numbers)
        {
            int temp;
            for (int j = 0; j <= numbers.Length - 2; j++)
            {
                for (int i = 0; i <= numbers.Length - 2; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        temp = numbers[i + 1];
                        numbers[i + 1] = numbers[i];
                        numbers[i] = temp;
                    }
                }
            }
            return numbers;
        }
    }
}
