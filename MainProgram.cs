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


                Console.WriteLine("\nZvol si program, kterých chceš spustit\n");
                Console.WriteLine("A12\tA13");
                Console.WriteLine("B14\tB15\tB16\tB17\tB18");
                Console.WriteLine("C12\tC13\tC14\tC15\tC16\tC17");
                Console.WriteLine("E9\tE10\tE11\tE12\tE13\tE14\tE15");
                Console.WriteLine("F1_4\tF1_8");

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
                    case "C13":
                        C13.Run(args);
                        break;
                    case "C14":
                        C14.Run(args);
                        break;
                    case "C15":
                        C15.Run(args);
                        break;
                    case "C16":
                        C16.Run(args);
                        break;
                    case "C17":
                        C17.Run(args);
                        break;
                    case "C18":
                        C18.Run(args);
                        break;
                    case "E9":
                        E9.Run(args);
                        break;
                    case "E10":
                        E10.Run(args);
                        break;
                    case "E11":
                        E11.Run(args);
                        break;
                    case "E12":
                        E12.Run(args);
                        break;
                    case "E13":
                        E13.Run(args);
                        break;
                    case "E14":
                        E14.Run(args);
                        break;
                    case "E15":
                        E15.Run(args);
                        break;
                    case "E16":
                        E16.Run(args);
                        break;
                    case "F1_4":
                        F1_4.Run(args);
                        break;
                    case "F1_8":
                        F1_8.Run(args);
                        break;
                    case "F1_9":
                        F1_9.Run(args);
                        break;
                    case "F1_10":
                        F1_10.Run(args);
                        break;
                    case "F1_11":
                        F1_11.Run(args);
                        break;
                    case "F1_12":
                        F1_12.Run(args);
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
