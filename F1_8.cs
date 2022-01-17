using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurzProgramovani_CSharp
{
    //Sestavte funkci PocetDniMesice, která má jako jediný parametr číslo měsíce.
    //Výsledkem volání funkce je počet dní tohoto měsíce(nebo -1, není-li hodnota měsíce správná).
    //Přestupné roky pro únor neuvažujte.
    //Funkci ověřte na zadání: sestavte program, který načte číslo měsíce a poté zobrazí, kolik dní má tento měsíc.
    //Vyzkoušejte i pro měsíc = 13.
    //Návod: řešte pomocí složené podmínky nebo konstrukcí Select Case. (program Doc. Homoly)
    //Pozor: Vstupy a výstupy budou v hlavním programu, předávat se budou přes parametry funkce či subrutiny.
    //V hlavním programu musí být použity jiné názvy proměnných než v subrutině či funkci.

    internal class F1_8
    {
        public static void Run(string[] args)
        {
            Console.Write("\nZadejte číslo měsíce(1-12): ");
            short month = short.Parse(Console.ReadLine());
            short days = PocetDniMesice(month);
            Console.WriteLine("\nPočet v měsící {0} je {1}", month.ToString(), days.ToString());
        }

        static short PocetDniMesice(short monthF)
        {
            short daysF;

            switch (monthF)
            {
                case 1:
                    daysF = 31;
                    break;
                case 2:
                    daysF = 29;
                    break;
                case 3:
                    daysF = 31;
                    break;
                case 4:
                    daysF = 30;
                    break;
                case 5:
                    daysF = 31;
                    break;
                case 6:
                    daysF = 30;
                    break;
                case 7:
                    daysF = 31;
                    break;
                case 8:
                    daysF = 31;
                    break;
                case 9:
                    daysF = 30;
                    break;
                case 10:
                    daysF = 31;
                    break;
                case 11:
                    daysF = 30;
                    break;
                case 12:
                    daysF = 31;
                    break;
                default:
                    daysF = -1;
                    break;
            }
            return daysF;
        }
    }
}
