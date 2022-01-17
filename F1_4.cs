using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurzProgramovani_CSharp
{
    //Napište funkci, které se předá rok(čtyřciferný) a která vrací logickou hodnotu "True", pokud je rok přestupný(přepracujte z Juliánského kalendáře z BasicCv.doc na Gregoriánský).
    //Řešte dvěma způsoby: dvěma podmínkami(či if-else) i jednou složenou podmínkou.
    //Potřebná teorie: Podle gregoriánského kalendáře jsou přestupné roky ty, které jsou dělitelné čtyřmi.
    //Ale roky dělitelné stem jsou přestupné jenom tehdy, jsou-li dělitelné také 400.
    //Přestupnými roky jsou proto například roky 1600, 2000, 2400 apod., zatímco roky 1700, 1800, 1900, 2100 atd.přestupné nejsou. (zdroj: wikipedia)

    internal class F1_4
    {
        public static void Run(string[] args)
        {
            Console.Write("Zadejte rok: ");
            int year = int.Parse(Console.ReadLine());
            bool leapYear = LeapYear(year);
            Console.Write('\n');
            if (leapYear)
                Console.WriteLine("Rok {0} je přestupný", year.ToString(), leapYear);
            else
                Console.WriteLine("Rok {0} je nepřestupný", year.ToString(), leapYear);
        }

        static bool LeapYear(int year)
        {
            bool leapYear = false;

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                leapYear = true;
            return leapYear;
        }
    }
}
