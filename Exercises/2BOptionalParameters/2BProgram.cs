using System;
using System.IO.Compression;
using System.Runtime.CompilerServices;

namespace _2BOptionalParameters
{
    class Program
    {
        /* Syntactic sugar == Creating syntax that is easier to read.  Makes code more 
        clear and concise. This should make programming easier.  Alternatively, 
        syntactic saccharin or syntactic syrup describes over the top syntax that
        doesn't really make programming any easier.
        */

        static void Main(string[] args)
        {
            //--------Problem #1 (method that takes 2 optional parameters)----------//

            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter your zip code: ");
            int zipCode = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("passes 0 parameters. Returns default values.");
            contactInfo();

            Console.WriteLine("passes 1 parameter, last name. Returns default value of zip code.");
            contactInfo(lastName);

            Console.WriteLine("passes 2 parameters, returns both.");
            contactInfo(lastName, zipCode);

            //---------------Problem #2 (using overloaded function)-----------------//

            Console.WriteLine("overloaded function 'Contact' can take a string or an int.");
            Contact(lastName);
            Contact(zipCode);
        }

        private static void contactInfo(string lastName = "No last name entered", int zipCode = 0)
        {
            Console.WriteLine($"Last Name: {lastName} \r\n Zip Code: {zipCode} \r\n");
        }

        private static void Contact(string lastName)
        {
            Console.WriteLine(lastName);
        }
        private static void Contact(int zipCode)
        {
            Console.WriteLine(zipCode);
        }
    }
}

