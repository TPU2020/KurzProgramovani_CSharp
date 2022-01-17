using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurzProgramovani_CSharp
{
    //Vygenerujte deset celých čísel a setřiďte je.Použijte např.algoritmus Bublinkového třídění (Bubble sort)
    internal class E14
    {
        public static void Run(string[] args)
        {
            Random random = new Random();

            int[] numbers = new int[30];
            int temp;
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = random.Next(1, 50);
            Console.WriteLine("Generováno " + String.Join(" ", numbers));

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
            Console.WriteLine("Seřazeno " + String.Join(" ", numbers));
        }
    }
}
