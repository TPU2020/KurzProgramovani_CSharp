using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurzProgramovani_CSharp
{
    //Program se zeptá, jak je venku, nabídne vám: úmorné vedro, zima, déšť, mlha, tma, chumelenice atd.
    //Podle toho vám navrhne, co máte dělat, např. dobře se obléci, jít na plovárnu atd.Nepoužívejte příkaz IF.
    internal class B15
    {
        public static void Run(string[] args)
        {
            Console.WriteLine("Jaké je venku počasí? vedro/zima/déšť/mlha/tma/chumelenice");
            string pocasi = Console.ReadLine();

            switch (pocasi)
            {
                case "vedro":
                    Console.WriteLine("Vypadá to na plavky");
                    break;
                case "zima":
                    Console.WriteLine("Dobře se obleč, je kosa");
                    break;
                case "déšť":
                    Console.WriteLine("Nezapomeň na deštník");
                    break;
                case "mlha":
                    Console.WriteLine("Radši zůstaň doma - stejně nic neuvidíš");
                    break;
                case "tma":
                    Console.WriteLine("Nezapomeň na čelovku");
                    break;
                case "chumelenice":
                    Console.WriteLine("Tak to se dobře zabal");
                    break;
                default:
                    Console.WriteLine("Toto počasí neznám - obleč si co chceš");
                    break;
            }
        }
    }
}
