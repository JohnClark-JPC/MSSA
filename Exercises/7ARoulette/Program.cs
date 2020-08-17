using System;

namespace _7ARoulette
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Roulette.Run();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("This is where the program exits.");
            }
        }
    }
}
