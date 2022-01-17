using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurzProgramovani_CSharp
{
    //Program vypíše všechna prvočísla do čísla 1000. Prvočísla jsou čísla dělitelná jen jedničkou a sama sebou. (použij modulo)
    internal class C18
    {
        public static void Run(string[] args)
        {
            Console.WriteLine();
            bool prime = false;

            for (int i = 1; i <= 1000; i++)
            {
                prime = true;
                for (int j = 2; j <= i/2; j++)
                {
                    if (i % j == 0)
                    {
                        prime = false;
                        break;
                    }   
                }
                if (prime == true && i!=1)
                    Console.Write(i.ToString() + ' ');
            }
            Console.WriteLine();
        }
    }
}
