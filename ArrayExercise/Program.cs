using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1D Array. Shows numbers being entered into an array
            //int[] arr1 = new int[10];
            //string str;
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    Console.WriteLine("Enter number into element #{0} for the array of length {1}", i, arr1.Length);
            //    str = Console.ReadLine();
            //    arr1[i] = Convert.ToInt32(str);
            //    Console.WriteLine(string.Join(",", arr1));
            //}


            ////Jagged Array Exercise
            //int[][] iarrs2 =
            //{
            //     new int[] {1, 2, 3, 4},
            //     new int[] {5, 6, 7, 8, 9},
            //     new int[] {10, 11, 12, 13, 14, 15}
            //};
            //Console.WriteLine(iarrs2.Length); //counts the rows
            //int grandTotal = 0;
            ////1st way
            //for (int i = 0; i < iarrs2.Length; ++i)
            //{
            //    for (int j = 0; j < iarrs2[i].Length; ++j)
            //    {
            //        grandTotal += iarrs2[i][j];
            //    }
            //}
            //Console.WriteLine(grandTotal);  //120
            ////2nd way
            ///*grandTotal = 0;
            //foreach(int[] arr in iarrs2)
            //{
            //    foreach (int i in arr) grandTotal += i;
            //}*/
            //foreach (int[] arr in iarrs2) //to print out the array
            //{
            //    foreach (int i in arr)
            //    {
            //        Console.Write("[{0}]", string.Join(", ", i));
            //    }
            //    Console.WriteLine("\n");
            //}


            ////1D Array
            int count = 0, numToCount = 9;      //change numToCount to # you want to count
            int[] arr2 = new int[] 
            {
                1, 2, 3, 4, 5, 9, 8, 9, 9, 1, 2, 3, 4
            };
            for (int i = 0; i < arr2.Length; i++)
            {
                if (arr2[i] == numToCount)      //[i] = index of the array
                    count++;
            }
            Console.WriteLine(count);

            ////MultiD Array
            int[,] arr3 = new int[,]
            {
                {0,1,2,3,4,3,4,5,9},
                {6,7,8,9,10,11,12,13,14}
            };
            int numOfRows = arr3.GetLength(0);
            int numOfClmns = arr3.GetLength(1);
            for (int i = 0; i < arr3.GetLength(0); i++)
            {
                for (int j = 0; j < arr3.GetLength(1); j++)
                {
                    if (arr3[i, j] == numToCount)
                        count++;
                }
            }
            Console.WriteLine(count);

            ////Jagged Array
            int[][] arr4 =
            {
               new int[] {0,1,2,3,4,3,4,5,9},
               new int[] {6,7,8,9,10,11,12,13,14},
               new int[] {10,5,6,2,8,9,1,8,9}
            };
            for (int i = 0; i < arr4.Length; i++)
            {
                for (int j = 0; j < arr4[i].Length; j++)
                {
                    if (arr4[i][j] == numToCount)
                        count++;
                }
            }
            Console.WriteLine(count);       //if exe with 1D and MultiD this will print out wrong. Need to comment out 1D and MultiD
        }
    }
}
