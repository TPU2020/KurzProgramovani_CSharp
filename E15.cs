using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurzProgramovani_CSharp
{
    //    Uživatel zadá několik slov(bez diakritiky).
    //    Program zapíše tento text v Morseově abecedě.
    //    Oddělovačem znaků bude lomítko.zadat všechna slova do jednoho inputboxu, oddělená normálně mezerami.
    //    A mezera se překládá taky jako lomítko.Tedy na hranicích slov budou vlastně dvě lomítka.- (Nutná znalost Morseovy abecedy). 
    //    Zdokonalení programu: text bude v souboru, Morseovka se zapíše do jiného souboru.
    //    Další program bude naopak načíst Morseovku a převádět na běžný text.
    //    (Práce se soubory - pokročilejší látka, bere se až v prezenčním kurzu.Tedy v přípravném kurzu nevypracovávat.)

    internal class E15
    {
        public static void Run(string[] args)
        {
            string inputText = "";
            string transText = "";
            char[] letters = { ' ', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            string[] morseLetters = { "/", "._", "_...", "_._.", "_..", ".", ".._.", "__.", "....", "..", ".___", "_._", "._..", "__", "_.", "___", ".__.", "__._", "._.", "...", "_", ".._", "..._", ".__", "_.._", "_.__", "__..", ".____", "..___", "...__", "...._", ".....", "_....", "__...", "___..", "____.", "_____" };

            inputText = FileText();
            //inputText = ConsoleText();
            inputText = inputText.ToLower();

            for (int i = 0; i < inputText.Length; i++)
            {
                for (int j = 0; j < letters.Length; j++)
                {
                    if (inputText[i] == letters[j])
                    {
                        transText += morseLetters[j];
                        transText += morseLetters[0];

                        break;
                    }
                }
                FileMorse(transText);
            }

            Console.WriteLine("\nVložený text \n" + inputText);
            Console.WriteLine("\nPřeložený text \n" + transText);

            string ConsoleText()
            {
                Console.WriteLine("Napište text");
                string text = Console.ReadLine();
                return text;
            }

            string FileText()
            {
                string currentDir = Directory.GetCurrentDirectory();
                string text = System.IO.File.ReadAllText(currentDir + @"\Text.txt");
                return text;
            }

            void FileMorse(string morseText)
            {
                string currentDir = Directory.GetCurrentDirectory();
                System.IO.File.WriteAllText(currentDir + @"\Morse.txt", morseText);
            }
        }
    }
}
