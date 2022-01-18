using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurzProgramovani_CSharp
{
    //Sestavte funkci PocetPadlych, která kromě předaného pole má i parametr, kolikrát se kostkou hodilo.
    //Výsledkem funkce je jednorozměrné celočíselné pole udávající, kolikrát padla ta která hodnota na kostce.
    //Funkci ověřte na zadání: sestavte program, který se zeptá na počet hodů, vygeneruje pole a pak zobrazí, kolikrát každé číslo padlo.
    //Povšimněte si, že čím více hodů, tím více se počty vyrovnají   (podobné e9, ale zde je to s použitím funkce)
    internal class F2_5
    {
        public static void Run(string[] args)
        {
            Console.Write("\nKolikrát chcete hodit kostkou? ");
            ushort throwsNo = ushort.Parse(Console.ReadLine());

            byte[] throws = new byte[throwsNo];
            Random random = new Random();
            for (int i = 0; i < throws.Length; i++)
                throws[i] = (byte)random.Next(1, 7);
            byte[] throwsCnt = PocetPadlych(throws, throwsNo);
            Console.WriteLine("\nPočet opakování čísel kostky z/ze {0} hodů kostkou", throwsNo.ToString());
            Console.WriteLine("1\t2\t3\t4\t5\t6");
            for (int i = 0; i < throwsCnt.Length; i++)
                Console.Write("{0}\t", throwsCnt[i]);
            Console.Write('\n');
        }

        static byte[] PocetPadlych(byte[] throws, ushort throwsNo)
        {
            byte[] throwsCnt = new byte[6];
            for (int i = 0; i < throwsNo; i++)
                throwsCnt[throws[i]-1]++;
            return throwsCnt;
        }
    }
}
