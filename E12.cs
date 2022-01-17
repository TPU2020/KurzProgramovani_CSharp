using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurzProgramovani_CSharp
{
    //Program zjistí indexy všech lokálních maxim(tedy prvků pole, které sousedí s nižšími hodnotami, čili které mají vlevo i vpravo nižší hodnotu).
    //Např.mějme pole:
    //1 2 3 1 5 6 7 4 3 2 6 5
    //Lokální maxima jsou 3, 7, 6

    internal class E12
    {
        public static void Run(string[] args)
        {
            Random random = new Random();
            int[] numbers = new int[20];
            int prevNum, nextNum;
            string idxLocMax = "";

            Console.Write('\n');
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 11);
                Console.Write("{0} ", numbers[i].ToString());
            }
            Console.Write("\n\n");

            for (int i = 1; i < numbers.Length - 1; i++)
            {
                prevNum = numbers[i - 1];
                nextNum = numbers[i + 1];
                if (prevNum < numbers[i] && nextNum < numbers[i])
                    idxLocMax += numbers[i].ToString() + ' ';
            }
            Console.WriteLine("Lokální maxima jsou " + idxLocMax);
        }
    }
}
