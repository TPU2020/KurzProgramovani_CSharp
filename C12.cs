using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurzProgramovani_CSharp
{
    //Sestavte program, který za vás zahraje poslední úder do golfového míčku.
    //Stojíte 3 metry od jamky o průměru 10cm (tedy vzdálenost 2,95 až 3,05)
    //a na ty 3 metry má vaše chvějící se ruka rozptyl ± 1m (tedy náhodná reálná čísla 2 až 4).
    //Kolikrát ze 100 úderů se strefíte? A na kolikátý pokus jste se poprvé strefili? (program Doc. Homoly)
    internal class C12
    {
        public static void Run(string[] args)
        {
            byte hits = 0, firstHit = 0;
            double shot;
            Random r = new Random();

            for (byte i = 0; i < 100; i++)
            {
                shot = r.NextDouble() * 2 + 2;
                Console.WriteLine(shot);
                if (shot >= 2.95 && shot <= 3.05)
                    ++hits;
                if (hits != 0 && firstHit == 0)
                    firstHit = i;
            }
            Console.WriteLine("Celkový počet trefených jamek je {0} a první jamka byla trefena při {1}. pokusu", hits, firstHit);
        }
    }
}
