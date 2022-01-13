using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurzProgramovani_CSharp
{
    //Zadejte délku odvěsen pravoúhlého trojúhelníka.
    //Program pomocí Pythagorovy věty vypočte délku přepony.
    //Pro kontrolu: zadáte-li odvěsny o délce 3 a 4, pak výsledek je 5 (přesněji 5,0, protože výsledek odmocniny se musí ukládat do desetinného typu )
    internal class A13
    {
        public static void Run(string[] args)
        {
            Console.Write("Zadejte délku první odvěsny: ");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Zadejte délku druhé odvěsny: ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            double hypotenuse = Math.Sqrt(Math.Pow(side1, 2) + Math.Pow(side2, 2));
            Console.WriteLine("\nDélka přepony pravoúhlého trojúhelníku je " + hypotenuse);

        }
    }
}
