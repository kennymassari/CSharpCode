using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Exerciseb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a letter: ");
            string x = Console.ReadLine();
            Console.WriteLine(SwitchOnString(x));
            Console.ReadKey();
        }
        static int SwitchOnString(string input)
        {
            switch (input)
            {
                case "A": return 1;
                case "B": return 2;
                case "C": return 3;
                case "Q":
                case "R": return 27;
                case "S": goto case "Z";
                case "T": return 31;
                case "Z": return 42;
                default: return 4;
            }
        }
    }
}