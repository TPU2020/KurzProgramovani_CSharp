using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurzProgramovani_CSharp
{
    //ještě zbývá procvičit funkci, která má na vstupu pole stringů.
    //Takže naprogramujte variantu na f2-11, ale funkci se bude předávat několik stringů(tedy několik slov).
    //Funkce slova vrátí zašifrovaná.
    internal class F2_12
    {
        public static void Run(string[] args)
        {
            Console.WriteLine("\nZadejte text, který chcete zašifrovat");
            string textInput = Console.ReadLine();
            string[] text = textInput.Split(' ');
            Console.Write("\nZadejte číslo šifry (1-10) ");
            byte n = byte.Parse(Console.ReadLine());

            Console.WriteLine('\n' + string.Join(" ", Sifra(text, n)));
        }

        static string[] Sifra(string[] text, byte n)
        {
            string[] cipher = new string[text.Count()];
            for (int i = 0; i < cipher.Count(); i++)
                for (int j = 0; j < text[i].Length; j++)
                    cipher[i] += text[i][j] + n > 'z' ? (char)(text[i][j] + n - 26) : (char)(text[i][j] + n);
            return cipher;
        }
    }
}
