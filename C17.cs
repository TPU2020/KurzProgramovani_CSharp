using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurzProgramovani_CSharp
{
    //Počítač popíše 20 řádků náhodným počtem hvězdiček.(použijte vnořenou smyčku)
    internal class C17
    {
        public static void Run(string[] args)
        {
            Random random = new Random();
            Console.WriteLine();

            for (int i = 1; i <= 20; i++)
            {
                for (int j = 0; j <= random.Next(0,10); j++)
                    Console.Write('*');
                Console.WriteLine();
            }
        }
    }
}
