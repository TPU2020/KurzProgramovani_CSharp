using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurzProgramovani_CSharp
{
    //Obdoba f1-3 ale pro pole znaků.
    //  Napište šifrovací funkci, které se předá znak a která vrátí následující znak v anglické abecedě.
    //  Tedy znak, jehož pozice v ASCII tabulce je o jedno vyšší (pro „z“ vrátí „a“).
    //  Poté program zdokonalte tak, aby se funkci předalo i číslo n a funkce pak v ASCII tabulce posouvá o n.
    //Tedy funkce má na vstupu pole znaků, které vrátí zašifrované
    internal class F2_11
    {
        public static void Run(string[] args)
        {
            Console.WriteLine("\nZadejte text, který chcete zašifrovat");
            string text = Console.ReadLine();
            Console.Write("\nZadejte číslo šifry (1-10) ");
            byte n = byte.Parse(Console.ReadLine());

            Console.WriteLine('\n' + Sifra(text, n));
        }

        static string Sifra(string text, byte n)
        {
            string cipher = "";
            for (int i = 0; i < text.Length; i++)
                cipher += text[i] + n > 'z' ? (char)(text[i] + n - 26) : (char)(text[i] + n);
            return cipher;
        }
    }
}
