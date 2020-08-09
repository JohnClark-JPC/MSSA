using System;

namespace _6AManipulatingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MainMenu.mainMenu();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("");
            }
        }
    }
}
