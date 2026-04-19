using System;

namespace Connect_Four
{
    // Inheritance: HumanPlayer inherits from Player
    internal class HumanPlayer : Player
    {
        public HumanPlayer(string name, char symbol)
            : base(name, symbol)
        {
        }

        // Polymorphism: overriding MakeMove method
        public override int MakeMove()
        {
            while (true)
            {
                Console.Write($"{Name} ({Symbol}), enter column (1-7): ");
                string? input = Console.ReadLine();

                if (int.TryParse(input, out int column))
                {
                    if (column >= 1 && column <= 7)
                    {
                        return column - 1;
                    }
                }

                Console.WriteLine("Invalid input. Try again.");
            }
        }
    }
}