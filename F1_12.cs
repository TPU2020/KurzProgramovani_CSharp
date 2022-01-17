using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurzProgramovani_CSharp
{
    //Sestavte funkci CisloDneVRoce, která má tři parametry: prvním je číslo dne, druhým číslo měsíce, třetím číslo roku včetně století.
    //Výsledkem volání funkce je pořadové číslo zadaného dne v daném roce (nebo -1, jestliže takové datum neexistuje).
    //Uvažujte i přestupné roky.
    //Funkci ověřte na zadání: sestavte program, který postupně načte den, měsíc a rok, a poté zobrazí, kolikátý den v roce to je.
    //Vyzkoušejte i pro den = 32 nebo pro měsíc = 13.Dále vyzkoušejte pro [31/12/1900] a pro [31/12/2000]. 
    //Pozor, Excel považuje chybně rok 1900 za přestupný. 
    //Tento program je dost náročný, můžete si jej nechat na konec

    internal class F1_12
    {
        public static void Run(string[] args)
        {
            Console.Write("\nZadejte číslo dne (1-31): ");
            byte day = byte.Parse(Console.ReadLine());
            Console.Write("\nZadejte číslo měsíce (1-12): ");
            byte month = byte.Parse(Console.ReadLine());
            Console.Write("\nZadejte číslo roku (0->): ");
            ushort year = ushort.Parse(Console.ReadLine());
            short days = CisloDneVRoce(day, month, year);
            Console.WriteLine("\nPočet dnů v pro datum {0}/{1}/{2} je {3}",day.ToString(),month.ToString(),year.ToString(), days.ToString());
        }

        static short CisloDneVRoce(byte day, byte month, ushort year)
        {
            short dayNo = 0;
            byte[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (day > daysInMonth[month] && day <= 0)
                return -1;
            if (month < 1 || month > 12)
                return -1;

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                daysInMonth[1] = 29;

            for (int i = 1; i < month; i++)
                dayNo += daysInMonth[i];
            dayNo += day;
            return dayNo;
        }
    }
}
