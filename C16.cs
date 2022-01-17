using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurzProgramovani_CSharp
{
    //Vypište 10 řádků.Na prvním řádku číslo 1, na druhém řádku 12, na třetím 123 atd. (použijte vnořenou smyčku)
    internal class C16
    {
        public static void Run(string[] args)
        {
            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(j.ToString());
                Console.WriteLine();
            }
        }
    }
}
