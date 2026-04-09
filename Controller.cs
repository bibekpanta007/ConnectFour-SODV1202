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

            player1 = new HumanPlayer("Player 1", 'X');
            player2 = new HumanPlayer("Player 2", 'O');
        }

        public void StartGame()
        {
            bool playAgain = true;

            while (playAgain)
            {
                model = new Model(); // reset board
                Player currentPlayer = player1;
                bool gameOver = false;

                view.ShowMessage("Welcome to Connect Four!");

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
                            currentPlayer = (currentPlayer == player1) ? player2 : player1;
                        }
                    }
                    else
                    {
                        view.ShowMessage("Column full or invalid move. Try again.");
                    }
                }

                Console.WriteLine("Play again? (y/n): ");
                string input = Console.ReadLine().ToLower();

                if (input != "y")
                {
                    playAgain = false;
                }
            }

            view.ShowMessage("Thanks for playing!");
        }
    }
}