using System;

namespace Connect_Four
{
    internal class Controller
    {
        private Model model;
        private View view;
        private Player player1;
        private Player player2;

        public Controller()
        {
            model = new Model();
            view = new View();

            // Inheritance + Polymorphism:
            // HumanPlayer objects are stored as Player references
            player1 = new HumanPlayer("Player 1", 'X');
            player2 = new HumanPlayer("Player 2", 'O');
        }

        public void StartGame()
        {
            bool playAgain = true;

            while (playAgain)
            {
                model = new Model(); // reset board for new game
                Player currentPlayer = player1;
                bool gameOver = false;

                view.ShowMessage("Welcome to Connect Four!");
                view.ShowMessage("Player 1 = X, Player 2 = O");

                while (!gameOver)
                {
                    view.DisplayBoard(model.Board);

                    int column = currentPlayer.MakeMove();

                    if (model.MakeMove(currentPlayer.Symbol, column))
                    {
                        if (model.CheckWin(currentPlayer.Symbol))
                        {
                            view.DisplayBoard(model.Board);
                            view.ShowMessage($"{currentPlayer.Name} wins!");
                            gameOver = true;
                        }
                        else if (model.CheckDraw())
                        {
                            view.DisplayBoard(model.Board);
                            view.ShowMessage("It's a draw!");
                            gameOver = true;
                        }
                        else
                        {
                            // switch turns
                            currentPlayer = (currentPlayer == player1) ? player2 : player1;
                        }
                    }
                    else
                    {
                        view.ShowMessage("Invalid move. Column is full or out of range. Try again.");
                    }
                }

                Console.Write("Play again? (y/n): ");
                string input = Console.ReadLine();

                if (input == null || input.ToLower() != "y")
                {
                    playAgain = false;
                }
            }

            view.ShowMessage("Thanks for playing!");
        }
    }
}