using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurzProgramovani_CSharp
{
    //Cvičení na subrutinu: Napište subrutinu, která vytiskne řádek obsahující N znaků Z.
    //Údaje N a Z jsou vstupními parametry subrutiny.Pozn.: toto nelze provést jako funkci!
    //Pozn.: použití MsgBox v subrutině či funkci je výjimečné, nepoužívejte tento postup v jiných programech.
    internal class F2_3
    {
        public static void Run(string[] args)
        {
            Console.Write("\nZadejte znak: ");
            char z = char.Parse(Console.ReadLine());
            Console.Write("\nZadejte počet opakování: ");
            byte n = byte.Parse(Console.ReadLine());
            Console.WriteLine("\nTisk znaku {0} s počtem opakování {1}\n\n", z, n.ToString());
            Tisk(z, n);
        }

        static void Tisk(char z, byte n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(z.ToString() + ' ');
            Console.Write('\n');
        }
    }
}
