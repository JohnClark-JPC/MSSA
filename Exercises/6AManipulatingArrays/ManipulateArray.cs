using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace _6AManipulatingArrays
{
    public class ManipulateArray
    {
        int[][] jaggedArray = new int[][]
        {
            new int[] { 0, 2, 4, 6, 8, 10 },
            new int[] { 1, 3, 5, 7, 9 },
            new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 }
        };
        char[] arrNames = new char[3] { 'A', 'B', 'C' };

        public void ArrayCountSumMean()
        {
            int arrSum = 0;
            double arrMean = 0.0;
            Console.WriteLine();

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    arrSum += jaggedArray[i][j];
                }
                arrMean = arrSum / jaggedArray[i].Length;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Array {arrNames[i]}: Count: {jaggedArray[i].Length}, Sum: {arrSum}, Mean: {arrMean}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            MainMenu.mainMenu();
        }

        public void ReverseArray()
        {
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"Reversed Array {arrNames[i]}: ");
                for (int j = jaggedArray[i].Length - 1; j >= 0; j--)
                {
                    int reversed = jaggedArray[i][j];
                    Console.Write($"{reversed}, ");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
            MainMenu.mainMenu();
        }


        public void RotateArray()
        {

        }

        public void SortArray()
        {

        }
    }
}
