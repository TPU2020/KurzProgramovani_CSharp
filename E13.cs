using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurzProgramovani_CSharp
{
    //Je dána posloupnost kladných celých čísel(ne lineární, tedy čísla budou nějak na přeskáčku).
    //Zjistěte, zda se v dané posloupnosti nějaké číslo opakuje. 13 b) zjistěte, která čísla se opakují. 13c) přidejte ještě informaci, kolikrát se opakují.
    internal class E13
    {
        public static void Run(string[] args)
        {
            Random random = new Random();
            int[] numbers = new int[20];
            int[,] repeats = new int[20, 2];
            byte index = 0;
            byte count = 0;
            bool repeatNum = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 21);
            }
            Console.WriteLine("\nVygenerované čísla\t" + string.Join(" ", numbers));

            Array.Sort(numbers);
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    if (repeats[index,1] == 0)
                        repeats[index,1] = 1;
                    repeats[index, 0] = numbers[i];
                    repeats[index, 1]++;
                    repeatNum = true;
                }

                if (numbers[i] != numbers[i - 1] && repeatNum == true)
                {
                    index++;
                    repeatNum = false;
                }
            }

            Console.WriteLine("Seřazení čísel\t\t" + string.Join(" ", numbers) + '\n');
            Console.Write("Opakovaná čísla\t\t");
            for (int i = 0; i < 20 - 1; i++)
                if (repeats[i,0] != 0)
                    Console.Write("{0}\t", repeats[i, 0].ToString());
            Console.Write("\nPočet opakování\t\t");
            for (int i = 0; i < 20 - 1; i++)
                if (repeats[i, 1] != 0)
                    Console.Write("{0}\t", repeats[i, 1].ToString());
        }
    }
}
