using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurzProgramovani_CSharp
{
    //Sestavte funkci PocetVyskytu, která má dva parametry:
    //Prvním je jednorozměrné pole čísel A, druhým je číslo C.
    //Výsledkem funkce je celé číslo udávající, kolikrát se číslo C vyskytuje v poli A.
    //Funkci ověřte na zadání: sestavte program, který postupně načte pole A a hodnotu C, a poté zobrazí počet výskytů hodnoty C v poli A.
    internal class F2_4
    {
        public static void Run(string[] args)
        {
            byte[] a = new byte[40];
            Random random = new Random();
            for (int i = 0; i < a.Length; i++)
                a[i] = (byte)(random.Next(1, 10));
            Console.WriteLine("\nČísla v poli:\n" + string.Join(" ", a));
            Console.Write("Zadejte číslo pro nalezení počtu opakování: ");
            byte c = byte.Parse(Console.ReadLine());
            byte cnt = PocetVyskytu(a, c);
            Console.WriteLine("\nVýskyt čísla {0} v poli je {1}", c.ToString(), cnt.ToString());
        }

        static byte PocetVyskytu(byte[] A, byte C)
        {
            byte cnt = 0;
            for (int i = 0; i < A.Length; i++)
                if (A[i] == C)
                    cnt++;
            return cnt;
        }
    }
}
