using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace _3AErrorsExceptions.Tests
{
    class Program

    // CHECKED will not work in this program because all variables are floating point, CHECKED only works on integer arithmetic.

    {   
        private static void Main(string[] args)
        {
            try
            {
                bool displayMenu = true;
                while (displayMenu)
                {
                    displayMenu = MainMenu();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                const int countDown = 3;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                for (int i = countDown; i >= 1; i--)
                {
                    Console.SetCursorPosition(0, 2);
                    Console.WriteLine($"Closing database connections...{i}");
                    System.Threading.Thread.Sleep(1000);
                }
            }
        }

        private static bool MainMenu()
        { 
            Console.Clear();
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("\r\n1) Calculate the circumference and area of a circle.");
            Console.WriteLine("2) Calculate the volume of a hemisphere.");
            Console.WriteLine("3) Calculate the area of a triangle");
            Console.WriteLine("4) Solve a quadratic equation given coefficients a, b, and c");
            Console.WriteLine("5) Exit");
            //Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    CircleCircumferenceArea();
                    return true;
                case "2":
                    VolumeHemisphere();
                    return true;
                case "3":
                    AreaTriangle();
                    return true;
                case "4":
                    SolveQuadratic();
                    return true;
                case "5":
                    return false;
                default:
                    return true;
            }
        }

        private static void CircleCircumferenceArea()
        {
            {
                Console.Write("Enter the radius of the circle: ");
                double radius;
                if (!double.TryParse(Console.ReadLine(), out radius))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Please enter a number.");
                    Console.ForegroundColor = ConsoleColor.White;
                    CircleCircumferenceArea();
                }
                else if (radius <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Please enter a number greater than 0");
                    Console.ForegroundColor = ConsoleColor.White;
                    CircleCircumferenceArea();
                }
                else
                {
                    double circumference = (2 * Math.PI * radius);
                    double area = (Math.PI * Math.Pow(radius, 2));

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"The circumference is {circumference} and the area is {area}");
                    ReturnToMain();
                }
            }
        }

        private static void VolumeHemisphere()
        {
            Console.Write("Enter the radius of the circle: ");

            double hemRadius;
            if (!double.TryParse(Console.ReadLine(), out hemRadius))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Please enter a number.");
                Console.ForegroundColor = ConsoleColor.White;
                VolumeHemisphere();
            }
            else if (hemRadius <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Please enter a number greater than 0");
                Console.ForegroundColor = ConsoleColor.White;
                VolumeHemisphere();
            }
            else
            {
                double volume = 4.0 / 3.0 * Math.PI * Math.Pow(hemRadius, 3) / 2;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"The volume of the hemisphere is {volume}");
                ReturnToMain();
            }
        }

        private static void AreaTriangle()
        {
            try
            {
                Console.Write("Enter side a: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Enter side b: ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Enter side c: ");
                double c = double.Parse(Console.ReadLine());

                if (a <= 0 || b <= 0 || c <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Enter a number greater than 0.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                    AreaTriangle();
                }

                else
                {
                    double p = (a + b + c) / 2;
                    double triArea = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                    if (triArea < 0)
                    {
                        triArea = 0;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"The area is {triArea}");
                    ReturnToMain();
                }

            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You entered a non-integer. Enter numbers only.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine();
                AreaTriangle();
            }
        }

        protected static void SolveQuadratic()
        {
            try
            {
                Console.Write("Enter side a: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Enter side b: ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Enter side c: ");
                double c = double.Parse(Console.ReadLine());
                if (a <= 0 || b <= 0 || c <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Enter a number greater than 0.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                    SolveQuadratic();
                }
                else
                {
                    DoQuadraticMaths(a, b, c);
                }
            }
            catch(FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You entered a non-integer. Enter numbers only.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine();
                SolveQuadratic();
            }
        }
    
        private static void DoQuadraticMaths(double a, double b, double c)
        {
            double positive_num;
            double negative_num;
            double denominator = 2 * a;
            double firstCheck = Math.Pow(b, 2) - 4 * a * c;

            if (firstCheck < 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("No real solution.");
                Console.ForegroundColor = ConsoleColor.White;
                ReturnToMain();
            }

            else if (firstCheck > 0)
            {
                positive_num = -b + Math.Sqrt(firstCheck);
                negative_num = -b - Math.Sqrt(firstCheck);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Solution 1 is: {positive_num / denominator}");
                Console.WriteLine($"Solution 2 is: {negative_num / denominator}");
                Console.ForegroundColor = ConsoleColor.White;
                ReturnToMain();
            }

            else
            {
                double x = (-b + Math.Sqrt(firstCheck)) / denominator;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"The equation is linear. Only one real solution: {x}.");
                Console.ForegroundColor = ConsoleColor.White;
                ReturnToMain();
            }

            /*
             
            Test for quadratic:
            6, 11, -35 = 1.666 or -3.5
            5, 6, 1    = -0.2 or -1
            2, 4, 2    = -1
            5, 2, 1    = No real solution

            */
        }

        private static void ReturnToMain()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Press enter to return to main menu.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
            MainMenu();
        }
    }
}
