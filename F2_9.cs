using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurzProgramovani_CSharp
{
    //Sestavte program, který nejprve čte řadu čísel ukončených nulou, která už do řady nepatří.
    //Pole se předá funkci, která sdělí (boolean), zda čísla tvoří lineární aritmetickou (tj.lineární) posloupnost (rozdíl dvou sousedních je vždy tentýž). 
    internal class F2_9
    {
        public static void Run(string[] args)
        {
            int ednInput;
            byte i = 0;
            int[] numbersTemp = new int[50];

            Console.WriteLine("\nZadejte čísla řady (max 50 čísel) - pro ukončení zadejte 0");

            do
            {
                ednInput = int.Parse(Console.ReadLine());
                numbersTemp[i] = ednInput;
                i++;
            } while (ednInput != 0 || i == 50);
            int[] numbers = new int[i - 1];
            Array.Copy(numbersTemp, 0, numbers, 0, i - 1);
            bool linAritm = LinArtmPosloupnost(numbers);
            if (linAritm)
                Console.WriteLine("\nŘada tvoří lineární aritmetickou posloupnost\n");
            else
                Console.WriteLine("\nŘada netvoří lineární aritmetickou posloupnost\n");
        }

        static bool LinArtmPosloupnost(int[] numbers)
        {
            for (int i = 1; i < numbers.Length-1; i++)
            {
                if (numbers[i - 1] != numbers[i] - 1 || numbers[i + 1] != numbers[i] + 1)
                    return false;
            }
            return true;
        }
    }
}
