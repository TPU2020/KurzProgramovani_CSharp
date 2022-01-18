using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurzProgramovani_CSharp
{
    //Sestavte program, který nejprve čte řadu čísel ukončených nulou, která už do řady nepatří.
    //Pole se předá funkci, která sdělí (boolean), zda jsou čísla seřazena vzestupně.Tedy každé další číslo je větší než předchozí.
    //Čili stačí jeden jediný pokles a už to není pravda.
    internal class F2_7
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
            int[] numbers = new int[i-1];
            Array.Copy(numbersTemp, 0, numbers, 0, i-1);
            bool rising = Vzestup(numbers);
            if (rising)
                Console.WriteLine("\nSeřazení čísel je vzestupně\n");
            else
                Console.WriteLine("\nSeřazení čísel není vzestupně\n");
        }

        static bool Vzestup(int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] > numbers[i])
                    return false;
            }
            return true;
        }
    }
}
