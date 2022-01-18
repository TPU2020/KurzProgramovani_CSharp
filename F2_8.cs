using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurzProgramovani_CSharp
{
    //Sestavte program, který nejprve čte řadu čísel ukončených nulou, která už do řady nepatří.
    //Pole se předá funkci, která sdělí, kolikátý prvek v řadě porušuje vzestupné řazení čísel.
    //Pokud je pole celé vzestupné, pak vrátí -1
    internal class F2_8
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
            short index = RisingIndex(numbers);
            if (index>0)
                Console.WriteLine("\nŘada není vzestupná, chyba se nachází na {0}. pozici\n", index);
            else
                Console.WriteLine("\nŘada je vzestupná\n");
        }

        static short RisingIndex(int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] > numbers[i])
                    return (short)(i+1);
            }
            return -1;
        }
    }
}
