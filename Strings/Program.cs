using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            ////different ways to print the string
            //double v = Math.Pow(Math.E, -5);
            //Console.WriteLine($"e to the -5th power is {v:e4}.");
            //Console.WriteLine("e to the -5th power is {0:e4}.", v);
            //v = Math.Sqrt(10);
            //Console.WriteLine($"The square root of 10 is {v:F3}.");
            //Console.WriteLine("The square root of 100 is {0:F3}.", v);
            //long l = (long)(1e9 * v);
            //Console.WriteLine($"Multiply this by a billion and you get {l:NO}.");
            //Console.WriteLine("Multiply this by a billion and you get {0:NO}.", l);

            ////counts the amount of letters from the input
            //Console.Write("Enter a string please: ");
            //string str = Console.ReadLine();
            //Console.Write("Enter the character you want to count: ");
            //char c = Convert.ToChar(Console.Read());
            //int count = CountChar1(str, c);
            //Console.WriteLine($"the total number of {c} in you string is: {count}");

            ////counts specified string
            string MainString = "Welcome to ASM03. We will study C# & ASP.Net to develop you skills.";
            Console.WriteLine("MainString: " + MainString);
            string SubString = "to";
            Console.WriteLine("SubString: " + SubString);
            containSubString(MainString, SubString);

        }
        ////counts the amount of letters from the input
        //static int CountChar1(string a, char c)
        //{
        //    int count = 0;
        //    foreach (char i in a)
        //    {
        //        if (i == c)
        //            count++;
        //    }
        //    return count;
        //}

        ////counts specified string
        static void containSubString(string MainString, string SubString)
        {
            string[] splitMainString = MainString.Split(' ');
            int count = 0;
            for (int i = 0; i < splitMainString.Length; i++)
            {
                if (splitMainString[i] == SubString)
                {
                    count++;
                    Console.WriteLine("Word Index: " + (i));
                }
            }
            Console.WriteLine("SubString exists in MainString: " + count + " times.");
            return;
        }
    }
}