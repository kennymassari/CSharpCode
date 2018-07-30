using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENum_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = SwitchOnEnum(ConsoleColor.Red);
            Console.WriteLine(x);
            Console.Read();
        }
        static int SwitchOnEnum(ConsoleColor color)
        {
            int hexcolor = 0;
            switch (color)
            {
                case ConsoleColor.Red:
                    hexcolor = 0xff0000;
                    break;
                case ConsoleColor.Green:
                    hexcolor = 0x00ff00;
                    break;
                case ConsoleColor.Blue:
                    hexcolor = 0x0000ff;
                    break;
                default:
                    throw new ArgumentException("Only red, green or blue is alowed.");
            }
            return hexcolor;
        }
    }
}
