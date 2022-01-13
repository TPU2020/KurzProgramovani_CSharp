using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurzProgramovani_CSharp
{
    //Sestavte program, který se zeptá na průměr vašeho kruhového bazénu a poté na jeho výšku(obojí v metrech).
    //Poté zobrazí, kolik tun vody se do něj vejde(1 m3 vody = 1 tuna). (program Doc. Homoly)
    internal class A12
    {
        public static void Run(string[] args)
        {
            double diameter, height, volume;

            Console.Write("Zadejte průměr Vašeho bazénu (m): ");
            diameter = Convert.ToDouble(Console.ReadLine());
            diameter /= 2;
            Console.Write("Zadejte výšku Vašeho bazénu (m): ");
            height = Convert.ToDouble(Console.ReadLine());

            volume = Math.PI * diameter * diameter * height;

            Console.WriteLine("\nDo bazénu se vejde " + volume + " tun vody\n");
        }
    }
}