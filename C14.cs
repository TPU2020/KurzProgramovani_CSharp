using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurzProgramovani_CSharp
{
 //Vytisknete na prvním řádku jednu hvězdu, na druhém dvě až do desátého.
 //Potom se začnou hvězdy ubírat.
 //Varianta: Totéž, ale na prvním řádku se vytisknou dvě hvězdy, na druhém
 //čtyři atd.
 //Varianta 2: Totéž, ale na prvnim i druhem řádku se vytiskne hvězda, na
 //třetím a čtvrtém dvě hvězdy atd.

    internal class C14
    {
        public static void Run(string[] args)
        {
            Console.WriteLine();
            Var1();
            Var2();
            Var3();
        }

        private static void Var1()
        {
            for (int i = 1; i <= 10; i++)
            {
                StarPrint(i);
            }
            for (int i = 10; i >= 1; i--)
            {
                StarPrint(i - 1);
            }
        }

        private static void Var2()
        {
            for (int i = 1; i <= 10; i++)
            {
                StarPrint(i*2);
            }
            for (int i = 10; i >= 1; i--)
            {
                StarPrint((i - 1)*2);
            }
        }
        private static void Var3()
        {
            for (int i = 1; i <= 10; i++)
            {
                StarPrint(i/2);
            }
            for (int i = 10; i >= 1; i--)
            {
                StarPrint((i - 1)/2);
            }
        }

        static void StarPrint(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }
    }
}
