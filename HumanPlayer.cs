using System;

namespace Connect_Four
{
    internal class HumanPlayer : Player
    {
        public override int MakeMove()
        {
            Console.Write("Enter column (1-7): ");
            return int.Parse(Console.ReadLine());
        }
    }
}