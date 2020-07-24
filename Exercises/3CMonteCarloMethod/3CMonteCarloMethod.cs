using System;
using System.Security.Cryptography.X509Certificates;

namespace MonteCarlo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of iterations to perform: ");
            double iterations = int.Parse(Console.ReadLine());

            Random rand = new Random();
            double overlapCounter = 0;

            for (int i = 0; i <= iterations; i++)
            {
                double overlapCircle = CalculateHypotenuse(rand);
                if (overlapCircle <= 1)
                {
                    overlapCounter++;
                }
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Total overlapping hits: {overlapCounter} out of {iterations} iterations. {(overlapCounter / iterations) * 100}%");
            double myPi = (overlapCounter / iterations) * 4.0;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"The value of your Pi: {myPi} ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Difference between your Pi and Pi: {Math.Abs(myPi - Math.PI)}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static (double, double) GetRandomNumbers(Random rand)
        {
            double a = rand.NextDouble();
            double b = rand.NextDouble();
            (double, double) randomNumbers = (a, b);
            return randomNumbers;
        }

        static double CalculateHypotenuse(Random rand)
        {
            double x = rand.NextDouble();
            double y = rand.NextDouble();
            return Math.Sqrt(x * x + y * y);
        }
    }
}

