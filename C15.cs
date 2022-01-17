using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurzProgramovani_CSharp
{
    //Vygenerujte 100 náhodných celých čísel od 1 do 5.
    //Zjistěte, zda jsou někdy dvě stejná vedle sebe, která to jsou a jaké je jejich pořadové číslo.
    internal class C15
    {
        public static void Run(string[] args)
        {
            Random random = new Random();
            byte[] rndNums = new byte[100];
            byte prevNum = 0, currNum;
            string sameNums = "", iOfNums = "";

            for (int i = 0; i < 100; i++)
            {
                rndNums[i] = (byte)random.Next(1, 6);
                if (i >= 1)
                    prevNum = rndNums[i - 1];
                currNum = rndNums[i];

                if(prevNum == currNum)
                {
                    sameNums += currNum.ToString() + ' ';
                    iOfNums += i.ToString() + ' ';
                }
            }
            Console.WriteLine("\nVygenerovaná náhodná čísla\n");
            Console.WriteLine(String.Join(' ', rndNums));
            Console.WriteLine("\nDvě stejná čísla vedle sebe: " + sameNums);
            Console.WriteLine("\nS indexy: " + iOfNums);
        }
    }
}
