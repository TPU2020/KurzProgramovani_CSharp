using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurzProgramovani_CSharp
{
    //Vypište tabulku malé násobilky.Bude 10 sloupců (+záhlaví) a 10 řádků(+záhlaví). Tedy první sloupec a první řádek jsou záhlaví:
    //    1   2   3   4   5   6   7   8   9  10      toto je záhlaví
    //1   1   2   3   4   5   6   7   8   9  10
    //2   2   4   6   8  10  12  14  16  18  20
    //3   3   6   9  12  15  18  21  24  27  30
    //4   atd.

    internal class C13
    {
        public static void Run(string[] args)
        {
            Console.WriteLine("Vypsání malé násobilky (1-10)\n");

            for (int i = 1; i < 11; i++)
                Console.Write('\t' + i.ToString());
            Console.Write('\n');

            for (int i = 1; i < 11; i++)
            {
                Console.Write(i.ToString());
                for (int j = 1; j < 11; j++)
                    Console.Write('\t' + Convert.ToString(j * i));
                Console.Write('\n');
            }
        }
    }
}
