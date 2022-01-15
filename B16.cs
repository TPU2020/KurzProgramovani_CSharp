using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurzProgramovani_CSharp
{
    //Uživatel zadá dvě čísla.
    //Poté se objeví nabídka, zda chce sčítat, odčítat, násobit, dělit nebo končit.
    //Poté se objeví výsledek vybrané operace se zadanými čísly nebo program skončí.
    internal class B16
    {
        public static void Run(string[] args)
        {
            double result = 0;
            Console.Write("Zadejte první číslo ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Zadejte druhé číslo ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Zadejte operaci: * / + -");
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "*":
                    result = x + y;
                    break;
                case "/":
                    result = x / y;
                    break;
                case "+":
                    result = x + y;
                    break;
                case "-":
                    result = x - y;
                    break;
                default:
                    Console.WriteLine("Neznámá operace, konec programu");
                    return;
            }
            Console.WriteLine("Výsledek operace {0} je {1}", operation, result);
        }
    }
}
