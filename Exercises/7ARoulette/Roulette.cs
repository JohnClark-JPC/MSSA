using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Runtime.CompilerServices;
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

                int c = Columns(number, spin);

                int v = Street(number, spin);

                SixLine(v);

                Split(number, spin, c, v);

                Console.ReadLine();
            }
            else
            {
                //this is where 0 & 00 stuff goes
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
        private static int Columns(int[] number, int spin)
        {
            int column = 0;
            if (number[spin] % 3 == 0)
            {
                Console.WriteLine($"Column: 3");
                return column = 3;
            }
            else if ((number[spin] + 1) % 3 == 0)
            {
                Console.WriteLine($"Column: 2");
                return column = 2;
            }
            else
            {
                Console.WriteLine($"Column: 1");
                return column = 1;
            }
        }
        private static int Street(int[] number, int spin)
        {
            if(number[spin] % 3 == 0)
            {
                int street = number[spin] / 3;
                Console.WriteLine($"Street: {street}");
                return street;
            }
            else if((number[spin] + 1) % 3 == 0)
            {
                int street = number[spin] / 3 + 1;
                Console.WriteLine($"Street: {street}");
                return street;
            }
            else
            {
                int street = number[spin] / 3 + 1;
                Console.WriteLine($"Street: {street}");
                return street;
            }
        }
        private static void SixLine(int v)
        {
            if (v == 1)
            {
                Console.WriteLine($"Sixline: {v}");
            }
            else if (v == 12)
            {
                Console.WriteLine($"Sixline: {v - 1}");
            }
            else
            {
                Console.WriteLine($"Sixline: {v - 1} & {v}");
            }
        }
        private static void Split(int[] number, int spin, int c, int v)
        {
            int s = number[spin];
            if (v == 1)
            {
                if(s == 1)
                {
                    Console.WriteLine($"Splits: 1/2, 1/4");
                }
                else if(s == 2)
                {
                    Console.WriteLine("Splits: 1/2, 2/3, 3/5");
                }
                else
                {
                    Console.WriteLine("Splits: 2/3, 3/6");
                }
                
            }
            else if (v == 12)
            {
                if (s == 34)
                {
                    Console.WriteLine($"Splits: 34/31, 34/35");
                }
                else if (s == 35)
                {
                    Console.WriteLine("Splits: 32/35, 34/35, 35/36");
                }
                else
                {
                    Console.WriteLine("Splits: 33/36, 35/36");
                }
            }
            else if (c == 1)
            {
                Console.WriteLine($"Splits: {s}/{s - 3}, {s}/{s + 1}, {s}/{s + 3}");
            }
            else if (c == 2)
            {
                Console.WriteLine($"Splits: {s}/{s - 3}, {s}/{s - 1}, {s}/{s + 3}, {s}/{s + 1}");
            }
            else
            {
                Console.WriteLine($"Splits: {s}/{s - 3}, {s}/{s - 1}, {s}/{s + 3}");
            }
        }
    }
}
