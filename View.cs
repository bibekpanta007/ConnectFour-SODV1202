using System;

namespace Connect_Four
{
    internal class View
    {
        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        // Optional: display board for later
        public void DisplayBoard(char[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}