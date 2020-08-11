using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
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
            Console.ReadLine();
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
            Console.ReadLine();
            MainMenu.mainMenu();
        }

        public void RotateArray()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Array A rotated 2 positions left: ");
            RotateArrayFunction(jaggedArray[0], 2, 'l');
            Console.WriteLine("Array B rotated 2 positions right: ");
            RotateArrayFunction(jaggedArray[1], 2, 'r');
            Console.WriteLine("Array C rotated 4 positions left: ");
            RotateArrayFunction(jaggedArray[2], 4, 'l');
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.ReadLine();
            MainMenu.mainMenu();
        }

        public void RotateArrayFunction(int[] nums, int k, char d)
        {
            if (d == 'l')
            {   
                for (int i = 0; i < k; i++)
                {
                    int temp = nums[0];

                    for (int j = 1; j < nums.Length; j++)
                    {
                        nums[j - 1] = nums[j];
                    }
                    nums[nums.Length - 1] = temp;
                }
                
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.Write($"{nums[i]}, ");
                }
                Console.WriteLine();   
            }
            else
            {
                for (int i = 0; i < k; i++)
                {
                    int temp = nums[nums.Length - 1];

                    for (int j = nums.Length -1; j > 0; j--)
                    {
                        nums[j] = nums[j - 1];
                    }
                    nums[0] = temp;
                }

                for (int i = 0; i < nums.Length; i++)
                {
                    Console.Write($"{nums[i]}, ");
                }
                Console.WriteLine();
            }
        }

        public void SortArray()
        {
            int[] c = jaggedArray[2];
            for (int i = 0; i <= c.Length - 2; i++)
            {
                for (int j = 0; j <= c.Length - 2; j++)
                {
                    if(c[j] > c[j + 1])
                    {
                        int t = c[j + 1];
                        c[j + 1] = c[j];
                        c[j] = t;
                    }
                }
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sorted Array C:");
            foreach (int a in c)
            {
                Console.Write($"{a}, ");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.ReadLine();
            MainMenu.mainMenu();
        }
    }
}
