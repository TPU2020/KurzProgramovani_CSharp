using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurzProgramovani_CSharp
{
    //Zadejte částku v Kč a pak si z nabídky vyberte měnu, na kterou chcete směnit(např.DEM, USD, FRF atd.).
    //Počítač přepočítá částku na tuto měnu.
    internal class B17
    {
        public static void Run(string[] args)
        {
            double result = 0;
            Console.Write("Zadejte částku (CZK), kterou chcete směnit: ");
            double money = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Zvolte měnu, ne kterou chcete směnit EUR/USD/GBP");
            string curency = Console.ReadLine();
            curency = curency.ToUpper();

            switch (curency)
            {
                case "EUR":
                    result = money / 24.5;
                    break;
                case "USD":
                    result = money / 22;
                    break;
                case "GBP":
                    result = money / 29.37;
                    break;
                default:
                    Console.WriteLine("Neznámá měna, konec programu");
                    return;
                    break;
            }
            Console.WriteLine("Směnou {0} CZK získáte {1} {2}", money, result, curency);
        }
    }
}
