using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] iarrs2 =
    {
                 new int[] {1, 2, 3, 4},
                 new int[] {5, 6, 7, 8, 9},
                 new int[] {10, 11, 12, 13, 14, 15}
                };
            Console.WriteLine(iarrs2.Length); //counts the rows
            int grandTotal = 0;
            //1st way
            for (int i = 0; i < iarrs2.Length; ++i)
            {
                for (int j = 0; j < iarrs2[i].Length; ++j)
                {
                    grandTotal += iarrs2[i][j];
                }
            }
            Console.WriteLine(grandTotal);  //120
            //2nd way
            /*grandTotal = 0;
            foreach(int[] arr in iarrs2)
            {
                foreach (int i in arr) grandTotal += i;
            }*/
            foreach (int[] arr in iarrs2) //to print out the array
            {
                foreach (int i in arr)
                {
                    Console.Write("[{0}]", string.Join(", ", i));
                }
                Console.WriteLine("\n");
            }

        }
    }
}
