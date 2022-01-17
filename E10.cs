using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurzProgramovani_CSharp
{
    //Program Doc.Homoly: Dvojrozměrné pole: Naplňte zadáním po řádcích pole 4x4.
    //Potom zjistěte minimum a zobrazte řádkové a sloupcové indexy buněk, na kterých se minimum nachází.
    internal class E10
    {
        public static void Run(string[] args)
        {
            Random random = new Random();
            int[,] numbers = new int[4, 4];
            int[] min = new int[3];
            min[0] = int.MaxValue;

            Console.WriteLine("\nNaplňte pole 4x4\n");

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                    numbers[i, j] = random.Next(1,1000);
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (numbers[i, j] < min[0])
                    {
                        min[0] = numbers[i, j];
                        min[1] = i;
                        min[2] = j;
                    }
                    Console.Write("{0}\t", numbers[i, j]);
                }
                Console.Write('\n');
            }
            Console.WriteLine("\nNejmenší číslo matice je {0} na pozici(x,y) ({1},{2})", min[0], min[1] + 1, min[2] + 1);
        }
    }
}
