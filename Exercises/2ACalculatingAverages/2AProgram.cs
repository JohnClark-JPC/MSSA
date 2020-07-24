using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;

namespace _2ACalculatingAverages
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }

        public static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("\r\n1) Calculate the sum of between 1 and 10 numbers");
            Console.WriteLine("2) Calculate the average of between 1 and 10 grades");
            Console.WriteLine("3) Calculate the average of between 1 and 100 grades");
            Console.WriteLine("4) Enter grades to find the overall average (min 0, max 100)");
            Console.WriteLine("5) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Sum();
                    return true;
                case "2":
                    AverageTenGrades();
                    return true;
                case "3":
                    AverageKnownNumberGrades();
                    return true;
                case "4":
                    AverageUnknownNumberGrades();
                    return true;
                case "5":
                    return false;
                default:
                    return true;
            }

            //TODO have to hit 5 2 times to exit.
        }
        static void Sum()
        {
            List<double> listOfNumbersToSum = new List<double>();

            Console.WriteLine("Enter how many numbers are to be summed. Minimum 1 and maximum 10: ");
            int entries = int.Parse(Console.ReadLine());

            if (entries < 1 || entries > 10)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("That entry was not between 1 and 10, please enter a number between 1 and 10: ");
                entries = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;
            }

            for (int i = 0; i < entries; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                listOfNumbersToSum.Add(double.Parse(Console.ReadLine()));
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"The sum of your numbers is: {listOfNumbersToSum.Sum()}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Press enter to return to main menu.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
            MainMenu();

            //TODO initial entry between 1&10, user can enter decimal value and it crashes.  TryParse?
        }
        static void AverageTenGrades()
        {
            List<double> listOfNumbersToAverage = new List<double>();

            Console.WriteLine("Enter 10 scores to be averaged.");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                listOfNumbersToAverage.Add(double.Parse(Console.ReadLine()));
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"The average score is: {listOfNumbersToAverage.Average()}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Press enter to return to main menu.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();

            //TODO does not handle null values

        }
        static void AverageKnownNumberGrades()
        {
            List<double> testScores = new List<double>();
            char letterGrade;

            Console.Write("Enter the number of test scores to average (from 1 to 100): ");
            int numberOfTestScores = int.Parse(Console.ReadLine());

            if (numberOfTestScores < 1 || numberOfTestScores > 100)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("That entry was not between 1 and 100, please enter a number between 1 and 100: ");
                numberOfTestScores = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;
            }

            for (int i = 0; i < numberOfTestScores; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                testScores.Add(double.Parse(Console.ReadLine()));
            }

            int averageTestScore = Convert.ToInt32(testScores.Average());

            if (averageTestScore > 99)
            {
                letterGrade = 'A';
            }
            else
            {
                switch (averageTestScore / 10)
                {
                    case 9:
                        letterGrade = 'A';
                        break;
                    case 8:
                        letterGrade = 'B';
                        break;
                    case 7:
                        letterGrade = 'C';
                        break;
                    case 6:
                        letterGrade = 'D';
                        break;
                    default:
                        letterGrade = 'F';
                        break;
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Your average score is: {Math.Round(testScores.Average(), 2)}" +
                              $"\r\nYour letter grade is a: {letterGrade}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Press enter to return to main menu.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
            MainMenu();
        }
        static void AverageUnknownNumberGrades()
        {
            List<double> listOfNumbersToAvg = new List<double>();
            double entries;
            int i = 0;
            char letterGrade;

            Console.WriteLine("Enter scores (max 100). When you are done, press 'a' to get the average: ");

            while (i <= 100)
            {
                //TODO does not account for user entering letters instead of numbers.
                Console.Write("Enter a score or press 'a' if you are done: ");
                string score = Console.ReadLine();

                if (score != "a")
                {
                    entries = Convert.ToInt32(score);
                    listOfNumbersToAvg.Add(entries);
                    i++;
                }
                else
                {
                    break;
                }
            }

            int avgTestScore = Convert.ToInt32(listOfNumbersToAvg.Average());

            if (avgTestScore > 99)
            {
                letterGrade = 'A';
            }
            else
            {
                switch (avgTestScore / 10)
                {
                    case 9:
                        letterGrade = 'A';
                        break;
                    case 8:
                        letterGrade = 'B';
                        break;
                    case 7:
                        letterGrade = 'C';
                        break;
                    case 6:
                        letterGrade = 'D';
                        break;
                    default:
                        letterGrade = 'F';
                        break;
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"The average of all scores is: {Math.Round(listOfNumbersToAvg.Average(), 2)}" +
                              $" \r\nYour letter grade is a: {letterGrade}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Press enter to return to main menu.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
            MainMenu();
        }
    }
}