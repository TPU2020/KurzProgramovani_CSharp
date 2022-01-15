using System;

namespace KurzProgramovani_CSharp
{
    internal class MainProgram
    {
        static void Main(string[] args)
        {
            string programSelected;
            do
            {
                Console.Clear();
                Console.WriteLine("Vítám tě ve svém programu Kurz Programování v C#...\n");
                Console.WriteLine("             Ing. Tomáš Puda");
                Console.WriteLine("                   2022 \n");


                Console.WriteLine("\nZvol si program, kterých chceš spustit");
                Console.WriteLine("A12 A13");
                Console.WriteLine("B14 B15 B16 B17 B18");

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
                    case "B15":
                        B15.Run(args);
                        break;
                    case "B16":
                        B16.Run(args);
                        break;
                    case "B17":
                        B17.Run(args);
                        break;
                    case "B18":
                        B18.Run(args);
                        break;
                    case "C12":
                        C12.Run(args);
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
