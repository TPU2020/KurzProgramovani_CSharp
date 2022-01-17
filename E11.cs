using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurzProgramovani_CSharp
{
    //Program Doc.Homoly: Dvojrozměrné pole: Naplňte zadáním pole 4x4.
    //Poté ji zobrazí překlopenou kolem hlavní diagonály (tedy prohodí indexy řádků a sloupců). Takže například místo pole:
    // 1  2  3  4 
    // 5  6  7  8 
    // 9 10 11 12
    //13 14 15 16 
    //bude pole:
    //1  5  9  13
    //2  6  10 14
    //3  7  11 15
    //4  8  12 16

    internal class E11
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
                    Console.Write("{0}\t", numbers[i, j]);
                Console.Write('\n');
            }
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                    Console.Write("{0}\t", numbers[j, i]);
                Console.Write('\n');
            }
        }
    }
}
