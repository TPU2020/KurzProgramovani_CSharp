using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurzProgramovani_CSharp
{
    //Sestavte funkci ObratText s jedním parametrem - textovým řetězcem.
    //Výsledkem volání funkce je tentýž textový řetězec, ale má znaky v obráceném pořadí.
    //Funkci ověřte na zadání: sestavte program, který načte textový řetězec a zobrazí ho v obráceném pořadí znaků.
    internal class F1_9
    {
        public static void Run(string[] args)
        {
            Console.WriteLine("\nZadejte text:");
            string text = Console.ReadLine();
            string textRev = ObratText(text);
            Console.WriteLine("\nText pozpátku:");
            Console.WriteLine(textRev);
        }

        static string ObratText(string text)
        {
            string textRev = "";
            for (int i = text.Length - 1; i >= 0; i--)
                textRev += text[i];
            return textRev;
        }
    }
}
