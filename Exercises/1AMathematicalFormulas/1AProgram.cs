using System;
using System.Dynamic;

namespace Mathematical_Formulas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1
            // Partially worked example
            Console.WriteLine("\nPart 1, circumference and area of a circle.");
            Console.Write("Enter an integer for the radius: ");
            string strradius = Console.ReadLine();
            int intradius = int.Parse(strradius);
            double circumference = 2 * Math.PI * intradius;
            Console.WriteLine($"The circumference is {circumference}");

            double area = Math.PI * Math.Pow(intradius, 2);
            Console.WriteLine($"The area is {area}");

            // Part 2
            Console.WriteLine("\nPart 2, volume of a hemisphere.");

            Console.Write("Enter an integer for the radius: ");
            int hemRadius = int.Parse(Console.ReadLine());
            double volume = 4.0 / 3.0 * Math.PI * Math.Pow(hemRadius, 3) / 2;
            Console.WriteLine($"The volume is {volume}");

            // Part 3
            Console.WriteLine("\nPart 3, area of a triangle (Heron's formula).");

            Console.Write("Enter side a: ");
            int a1 = int.Parse(Console.ReadLine());
            Console.Write("Enter side b: ");
            int b1 = int.Parse(Console.ReadLine());
            Console.Write("Enter side c: ");
            int c1 = int.Parse(Console.ReadLine());

            double p = (a1 + b1 + c1) / 2;
            double triArea = Math.Sqrt(p * (p - a1) * (p - b1) * (p - c1));
            Console.WriteLine($"The area is {triArea}");

            // Part 4
            Console.WriteLine("\nPart 4, solving a quadratic equation.");

            Console.Write("Enter coefficient a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter coefficient b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter coefficient c: ");
            double c = double.Parse(Console.ReadLine());

            double positive_num;
            double negative_num;
            double denominator = 2 * a;
            double firstCheck = Math.Pow(b, 2) - 4 * a * c;

            if (firstCheck < 0)
            {
                Console.WriteLine("No real solution.");
            }

            else if (firstCheck > 0)
            {
                positive_num = -b + Math.Sqrt(firstCheck);
                negative_num = -b - Math.Sqrt(firstCheck);
                Console.WriteLine($"The positive solution is: {positive_num / denominator}");
                Console.WriteLine($"The negative solution is: {negative_num / denominator}");
            }

            else
            {
                double x = (-b + Math.Sqrt(firstCheck)) / denominator;
                Console.WriteLine($"The equation is linear. Only one real solution: {x}.");
            }

            /*
             
            Test for quadratic:
            6, 11, -35 = 1.666 or -3.5
            5, 6, 1    = -0.2 or -1
            2, 4, 2    = -1
            5, 2, 1    = No real solution

            */
        }
    }
}