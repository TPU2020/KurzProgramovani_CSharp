using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurzProgramovani_CSharp
{
    //Zadejte ve smyčce do pole úspory několika osob.
    //Poté se program zeptá, jaká je roční úroková míra.
    //Pole předejte funkci, která vrátí pole po započítání úroků.
    //Původní pole nesmí být voláním funkce ovlivněno (to platí i pro všechny další příklady).
    internal class F2_1
    {
        public static void Run(string[] args)
        {
            Random random = new Random();
            double[] money = new double[6];
            for (int i = 0; i < money.Length; i++)
                money[i] = random.Next(10000, 1000000);
            Console.WriteLine("\nHodnoty osob\n" + string.Join(" CZK\t", money));
            Console.Write("\nJaká je roční úroková sazba(%)? ");
            float interest = float.Parse(Console.ReadLine());
            double[] moneyInt = MoneyInterest(money, interest);

            Console.WriteLine("Hodnoty po započtení úroku {0:P2}:\n{1}", interest/100, string.Join(" CZK\t",moneyInt) + " CZK");
        }

        static double[] MoneyInterest(double[] money, float interest)
        {
            double[] MoneyInt = new double[money.Length];

            for (int i = 0; i < money.Length; i++)
                MoneyInt[i] = money[i] + ((money[i] * interest) / 100);

            return MoneyInt;
        }
    }
}
