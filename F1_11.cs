using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurzProgramovani_CSharp
{
    //Sestavte funkci Vyskyty se dvěma parametry - textovými řetězci.Druhý parametr je subřetězec, případně jen jednoznakový řetězec.
    //Výsledkem volání funkce je počet opakování druhého parametru v parametru prvním.
    //Funkci ověřte na zadání: sestavte program, který načte textový řetězec a zobrazí například počet písmen "A" v tomto řetězci.
    internal class F1_11
    {
        public static void Run(string[] args)
        {
            Console.WriteLine("\nZadejte text:");
            string text = Console.ReadLine();
            Console.Write("\nZadejte hledaný znak: ");
            char sign = char.Parse(Console.ReadLine());
            byte occur = Vyskyt(text, sign);

            Console.WriteLine("Výskyt znaku {0} je v textu {1} krát", sign, occur.ToString());
        }

        static byte Vyskyt(string text, char sign)
        {
            byte occur = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (sign == (char)text[i])
                    occur++;
            }
            return occur;
        }
    }
}
