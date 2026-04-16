using System;

namespace Connect_Four
{
    internal class View
    {
        public void DisplayBoard(char[,] board)
        {
            Console.WriteLine();

            for (int i = 0; i < 6; i++)
            {
                Console.Write("| ");
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine("|");
            }

            Console.WriteLine("-----------------");
            Console.WriteLine("  1 2 3 4 5 6 7");
            Console.WriteLine();
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}