using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurzProgramovani_CSharp
{
    //Zadejte a, b, c. Program vypočte kořeny kvadratické rovnice a* x^2 + b* x + c = 0.
    //Pokud si už ze školy nepamatujete, tak hledejte na Wikipedii heslo Diskriminant.Pozn.: na videu 034.MTS od desáté minuty to doc.Homola vysvětluje.
    //Tento program je těžší, můžete jej nechat na později.
    //Teorie: Řešením jsou v závislosti na řešení diskriminantu D buď dvě různá čísla (při kladném D), nebo jeden dvojnásobný kořen(D = 0) nebo dvě komplexně sdružená čísla(při D<0).    D=b2-4ac.

    // Tedy pro D=0 bude řešením zdvojený kořen -b/2a
    // Otestujte na následujících vzorových datech:
    //Dvě reálná řešení budou pro(x-1)(x-2)=X2-3x+2, tedy parametry budou 1, -3, 2
    //Zdvojený kořen bude pro(x-2)(x-2)=X2-4x+4, tedy parametry budou 1, -4, 4
    //A komplexně sdružený kořen bude pro x2+2x+3, tedy parametry 1, 2, 3, řešení pak bude
    //Pokud někdo výše uvedenému nerozumí(ani s pomocí výše uvedeného videa), tak program přeskočte.V kurzu nehraje matematika hlavní roli.

    internal class B14
    {
        public static void Run(string[] args)
        {
            double D, x1, x1i, x2, x2i;
            Console.WriteLine();
            Console.Write("Zadejte a: ");
            double a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Zadejte b: ");
            double b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Zadejte c: ");
            double c = Convert.ToInt32(Console.ReadLine());

            D = Math.Pow(b, 2) - 4 * a * c;

            Console.WriteLine();
            Console.WriteLine("Diskriminant D je " + D);

            switch (D)
            {
                case > 0:
                    x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    Console.WriteLine();
                    Console.WriteLine("Kořeny x1 a x2 jsou");
                    Console.WriteLine("x1 = " + x1);
                    Console.WriteLine("x2 = " + x2);
                    break;

                case 0:
                    x1 = -(b / (2 * a));
                    Console.WriteLine();
                    Console.WriteLine("Kořen je zdvojený (x1 = x2)");
                    Console.WriteLine("x = " + x1);
                    break;

                case < 0:
                    x1 = -(b / (2 * a));
                    x2 = x1;
                    x1i = Math.Sqrt(Math.Abs(D)) / 2 * a;
                    x2i = -x1i;

                    Console.WriteLine();
                    Console.WriteLine("x1 = {0} +{1:F}i", x1, x1i);
                    Console.WriteLine("x2 = {0} {1:F}i", x2, x2i);
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("Chyba Diskrimininantu..." + D);
                    break;
            }

        }
    }
}
