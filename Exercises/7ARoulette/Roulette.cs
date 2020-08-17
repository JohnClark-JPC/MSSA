using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Text;
using System.Threading;

namespace _7ARoulette
{
    class Roulette
    {
        public static void Run()
        {
            Random rand = new Random();
            int[] number = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 245, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37 };
            int[] color = new int[] { 2, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 1, 0, 1, 0, 1, 0, 1, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 1, 0, 1, 0, 1, 0, 1, 0, 2 };
            string[] colors = new string[] { "Red", "Black", "Green" };
            int spin = rand.Next(0, 37);
            bool isGreen = false;

            if (number[spin] == 0 || number[spin] == 37) isGreen = true;

            Console.WriteLine($"Winning Number: {colors[color[spin]]} {number[spin]}");

            if (!isGreen)
            {
                EvenOrOdd(number, spin);

                LowOrHigh(number, spin);

                Dozens(number, spin);

                Columns(number, spin);

                Street(number, spin);

                Console.ReadLine();
            }
            else
            {

            }
        }

        private static void EvenOrOdd(int[] number, int spin)
        {
            var evenOrOdd = number[spin] % 2 == 0 ? "Even" : "Odd";
            Console.WriteLine($"Even/Odd: {evenOrOdd}");
        }
        private static void LowOrHigh(int[] number, int spin)
        {
            var lowOrHigh = number[spin] <= 18 ? "Low" : "High";
            Console.WriteLine($"Low/High: {lowOrHigh}");
        }
        private static void Dozens(int[] number, int spin)
        {
            if (number[spin] <= 12)
            {
                Console.WriteLine("Dozens: 1st");
            }
            else if (number[spin] >= 13 && number[spin] <= 24)
            {
                Console.WriteLine("Dozens: 2nd");
            }
            else
            {
                Console.WriteLine("Dozens: 3rd");
            }
        }
        private static void Columns(int[] number, int spin)
        {
            int column = 0;
            if (number[spin] % 3 == 0)
            {
                column = 3;
                Console.WriteLine($"Column: {column}");
            }
            else if ((number[spin] + 1) % 3 == 0)
            {
                column = 2;
                Console.WriteLine($"Column: {column}");
            }
            else
            {
                column = 1;
                Console.WriteLine($"Column: {column}");
            }
        }
        private static void Street(int[] number, int spin)
        {
            int street;

            if(number[spin] % 3 == 0)
            {
                street = number[spin] / 3;
                Console.WriteLine($"Street: {street}");
            }
            else if((number[spin] + 1) % 3 == 0)
            {
                street = number[spin] / 3 + 1;
                Console.WriteLine($"Street: {street}");
            }
            else if((number[spin] + 2) % 3 == 0)
            {
                street = number[spin] / 3 + 1;
                Console.WriteLine($"Street: {street}");
            }
        }
    }
}
