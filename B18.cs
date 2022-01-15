using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurzProgramovani_CSharp
{
    //Zadejte číslo měsíce(1 až 12).
    //Program vypíše, kolik má měsíc dní(únor má zjednodušeně 28 dní).
    //Proveďte pomocí if i case.
    internal class B18
    {
        public static void Run(string[] args)
        {
            byte days = 0;
            Console.Write("Zadejte číslo měsíce (1-12): ");
            string month = Console.ReadLine();

            switch (month)
            {
                case "1":
                    days = 31;
                    break;
                case "2":
                    days = 28;
                    break;
                case "3":
                    days = 31;
                    break;
                case "4":
                    days = 30;
                    break;
                case "5":
                    days = 31;
                    break;
                case "6":
                    days = 30;
                    break;
                case "7":
                    days = 31;
                    break;
                case "8":
                    days = 31;
                    break;
                case "9":
                    days = 30;
                    break;
                case "10":
                    days = 31;
                    break;
                case "11":
                    days = 30;
                    break;
                case "12":
                    days = 31;
                    break;
                default:
                    Console.WriteLine("Číslo {0} není číslo měsíce, konec programu", month);
                    return;
            }
            Console.WriteLine("Počet dnů ve zvoleném měsící {0} je {1}", month,  days);

        }
    }
}
