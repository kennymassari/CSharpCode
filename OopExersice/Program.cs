using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopExersice1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("1 argument is expected.");
                return;
            }
            if (!File.Exists(args[0]))
            {
                Console.WriteLine($"File '{args[0]}' not found.");
                return;
            }
            string document = File.ReadAllText(args[0]);

            do
            {
                string input = PromptForSearchWord();
                if (string.IsNullOrWhiteSpace(input)) return;
                int nOccur = FindWordCount(document, input);
                Console.WriteLine($"The text '{input}' occurs {nOccur}' times.");
            } while (true);
        }
        private static string PromptForSearchWord()
        {
            Console.WriteLine("Please enter text to search for: ");
            return Console.ReadLine();
        }
        private static int FindWordCount(string document, string searchText)
        {
            int count = 0;
            int ndx = document.IndexOf(searchText);
            while (ndx >= 0)
            {
                count++;
                ndx = document.IndexOf(searchText, ndx + searchText.Length);
            }
            return count;
        }

    }
}
}
