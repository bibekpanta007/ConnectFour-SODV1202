using System;

namespace Connect_Four
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create the game controller
            Controller controller = new Controller();

            // Start the game
            controller.StartGame();

            // Keep console open
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}