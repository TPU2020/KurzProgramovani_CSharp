using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurzProgramovani_CSharp
{
    //Sestavte program, který se nejprve zeptá na počet hodů kostkou.
    //Pak tolikrát "hodí kostkou" a zobrazí, kolikrát padla jednotlivá čísla celkem a percentuelně. (omylem stejné jako e3, tedy nevypracovávat)
    internal class E9
    {
        public static void Run(string[] args)
        {
            Random random = new Random();
            int[] cntNumbers = new int[6];
            int rndNumber;

            Console.Write("Zadejte počet hodů kostkou ");
            byte noThrows = Convert.ToByte(Console.ReadLine());
            Console.Write("Hody\t");

            for (int i = 0; i < noThrows; i++)
            {
                rndNumber = random.Next(1, 7);
                Console.Write(rndNumber.ToString() + ' ');

                switch (rndNumber)
                {
                    case 1:
                        cntNumbers[0]++;
                        break;
                    case 2:
                        cntNumbers[1]++;
                        break;
                    case 3:
                        cntNumbers[2]++;
                        break;
                    case 4:
                        cntNumbers[3]++;
                        break;
                    case 5:
                        cntNumbers[4]++;
                        break;
                    case 6:
                        cntNumbers[5]++;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine('\n');
            Console.WriteLine("Čísla\t1\t2\t3\t4\t5\t6");
            Console.WriteLine("Četnost\t" + string.Join("\t", cntNumbers));
            Console.WriteLine("(%)\t{0:P}\t{1:P}\t{2:P}\t{3:P}\t{4:P}\t{5:P}", (float)cntNumbers[0]/noThrows, (float)cntNumbers[1] / noThrows, (float)cntNumbers[2] / noThrows, (float)cntNumbers[3] / noThrows, (float)cntNumbers[4] / noThrows, (float)cntNumbers[5] / noThrows);


        }
    }
}
