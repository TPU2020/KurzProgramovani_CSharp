using System;

namespace KurzProgramovani_CSharp
{
    internal class _MainProgram
    {
        static void Main(string[] args)
        {
            string programSelected;

            Console.WriteLine("Vítám tě ve svém programu Kurz Programování v C#...\n");
            Console.WriteLine("             Ing. Tomáš Puda");
            Console.WriteLine("                   2022 \n");

            do
            {
                Console.WriteLine("\nZvol si program, kterých chceš spustit");

                programSelected = Console.ReadLine();
                programSelected = programSelected.ToUpper();
                Console.WriteLine("Zvoleno: " + programSelected);

                switch (programSelected)
                {
                    case "A12":
                        A12.Run(args);
                        break;
                    case "A13":
                        A13.Run(args);
                        break;
                    case "B14":
                        B14.Run(args);
                        break;
                    default:
                        Console.WriteLine("\nNeznámý program...Prosím zvolte znovu...");
                        break;
                }
                Console.WriteLine("\nPro ukončení programu stiskni (n), opakování stikni jinou libovolnou klávesu");
            } while (Console.ReadKey().KeyChar != 'n');

        }
    }
}
