using System;
using System.Collections.Generic;

namespace Толковый_словарь
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandToSearch = "1";
            const string CommandExit = "2";

            bool isWork = true;

            while (isWork)
            {
                Console.WriteLine($"{CommandToSearch} - узнать значение слова.\n{CommandExit} - выход.");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandToSearch:
                        SearchWord();
                        break;

                    case CommandExit:
                        isWork = false;
                        break;

                    default:
                        Console.WriteLine("неверный ввод");
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }

        static Dictionary<string, string> KeepData()
        {
            Dictionary<string, string> explanatoryDictionary = new Dictionary<string, string>();

            explanatoryDictionary.Add("абсурд", "бессмыслица, нелепость.");
            explanatoryDictionary.Add("бабочка", "насекомое с двумя парами крыльев разнообразной окраски, покрытых мельчайшими чешуйками.");
            explanatoryDictionary.Add("валкий", "легко накреняющийся и опрокидывающийся; неустойчивый.");

            return explanatoryDictionary;
        }

        static void SearchWord()
        {
            Dictionary<string, string> dictionary = KeepData();

            Console.WriteLine("список слов внесенных в словарь: ");

            foreach (string word in dictionary.Keys)
            {
                Console.WriteLine(word);
            }

            Console.Write("введите слово, значение которого хотите узнать: ");
            string userInput = Console.ReadLine();

            if (dictionary.ContainsKey(userInput))
            {
                Console.Write($"значение слова '{userInput}' - {dictionary[userInput]}");
            }
            else
            {
                Console.WriteLine($"'{userInput}' - такого слова в словаре нет");
            }
        }
    }
}
