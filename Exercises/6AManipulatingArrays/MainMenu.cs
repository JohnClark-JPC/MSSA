using System;
using System.Collections.Generic;
using System.Text;



namespace _6AManipulatingArrays
{
    class MainMenu
    {
        public static bool mainMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Array A: 0, 2, 4, 6, 8, 10");
            Console.WriteLine("Array B: 1, 3, 5, 7, 9");
            Console.WriteLine("Array C: 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\r\n1) Return array lengths, sums, and means.");
            Console.WriteLine("2) Reverse all three arrays.");
            Console.WriteLine("3) Rotate an array.");
            Console.WriteLine("4) Sort array C.");
            Console.WriteLine("5) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    ManipulateArray m = new ManipulateArray();
                    m.ArrayCountSumMean();
                    return true;
                case "2":
                    ManipulateArray r = new ManipulateArray();
                    r.ReverseArray();
                    return true;
                case "3":
                    ManipulateArray ro = new ManipulateArray();
                    ro.RotateArray();
                    return true;
                case "4":
                    ManipulateArray s = new ManipulateArray();
                    s.SortArray();
                    return true;
                case "5":
                    return false;
                default:
                    return true;
            }
        }
    }
}
