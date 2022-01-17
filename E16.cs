using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurzProgramovani_CSharp
{
    //Simulace karetní hry Vojna pro dva hráče a 32 karet(čtyři barvy s hodnotami 7 až 14, tedy 7,8,9,10, spodek, svršek, král, eso).
    //Na začátku oba hráči dostanou náhodně šestnáct karet.
    //Na monitoru se zobrazí šestnáct vyložení obou hráčů s informací, kdo dané vyložení vyhrál.
    //Na konci vyhrává ten, který vyhrál nejvíce vyložení.
    //V jednodušší variantě se neřeší vyložení stejných hodnot.
    //V dokonalejší variantě se vykládá ještě jednou, vítěz si pak připíše dvě vítězství.
    //(Dost náročný, řešit až jako poslední program tohoto souboru.)
    internal class E16
    {
        public static void Run(string[] args)
        {
            Random rnd = new Random();
            byte[] cards = { 7, 8, 9, 10, 11, 12, 13, 14, 7, 8, 9, 10, 11, 12, 13, 14, 7, 8, 9, 10, 11, 12, 13, 14, 7, 8, 9, 10, 11, 12, 13, 14 };
            byte[] shuffleCards = cards.OrderBy(x => rnd.Next()).ToArray();
            byte[] player1 = new byte[17], player2 = new byte[17];
            byte spare = 0;
            Array.Copy(shuffleCards, 0, player1, 0, 16);
            Array.Copy(shuffleCards, 16, player2, 0, 16);
            Console.WriteLine("\nKarty " + string.Join(' ', cards));
            Console.WriteLine("Zamíchané karty " + string.Join(' ', shuffleCards));
            Console.WriteLine("\nKarty hráče 1 " + string.Join(' ', player1));
            Console.WriteLine("\nKarty hráče 2 " + string.Join(' ', player2));

            for (int i = 0; i < cards.Length / 2; i++)
            {
                if (player1[i] != player2[i])
                {
                    if (player1[i] > player2[i])
                    {
                        player1[16]++;
                        if (spare > 0)
                        {
                            player1[16] += spare;
                            spare = 0;
                        }
                    }
                    else
                    {
                        player2[16]++;
                        if (spare > 0)
                        {
                            player2[16] += spare;
                            spare = 0;
                        }
                    }
                }
                else
                {
                    spare++;
                }
            }
            Console.Write('\n');
            if (player1[16] > player2[16])
                Console.WriteLine("V tomto kole vítězí hráč 1 s počtem bodů {0}", player1[16].ToString());
            else if (player1[16] < player2[16])
                Console.WriteLine("V tomto kole vítězí hráč 2 s počtem bodů {0}", player2[16].ToString());
            else
                Console.WriteLine("Plichta - oba hráčí mají stejně bodů");


        }
    }
}
