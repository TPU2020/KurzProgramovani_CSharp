using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurzProgramovani_CSharp
{
    //Sestavte funkci BezMezer s jedním parametrem - textovým řetězcem.
    //Výsledkem volání funkce je tentýž textový řetězec, ve kterém však jsou vypuštěny všechny mezery.
    //Funkci ověřte na zadání: sestavte program, který načte textový řetězec a zobrazí ho tak, že v něm jsou vypuštěny všechny mezery.
    internal class F1_10
    {
        public static void Run(string[] args)
        {
            Console.WriteLine("\nZadejte text:");
            string text = Console.ReadLine();
            string textSpaceLess = BezMezer(text);
            Console.WriteLine("\nText bez mezer:");
            Console.WriteLine(textSpaceLess);
        }

        static string BezMezer(string text)
        {
            string textSpaceLess = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                    textSpaceLess += text[i];
            }
            return textSpaceLess;
        }
    }
}
