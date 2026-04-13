namespace Connect_Four
{
    internal class Model
    {
        public char[,] Board { get; private set; }

        public Model()
        {
            Board = new char[6, 7];

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Board[i, j] = '.';
                }
            }
        }

        public bool MakeMove(char symbol, int column)
        {
            if (column < 0 || column >= 7)
                return false;

            for (int row = 5; row >= 0; row--)
            {
                if (Board[row, column] == '.')
                {
                    Board[row, column] = symbol;
                    return true;
                }
            }

            return false;
        }

        public bool CheckWin(char symbol)
        {
            for (int row = 0; row < 6; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    if (Board[row, col] == symbol &&
                        Board[row, col + 1] == symbol &&
                        Board[row, col + 2] == symbol &&
                        Board[row, col + 3] == symbol)
                    {
                        return true;
                    }
                }
            }

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    if (Board[row, col] == symbol &&
                        Board[row + 1, col] == symbol &&
                        Board[row + 2, col] == symbol &&
                        Board[row + 3, col] == symbol)
                    {
                        return true;
                    }
                }
            }

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    if (Board[row, col] == symbol &&
                        Board[row + 1, col + 1] == symbol &&
                        Board[row + 2, col + 2] == symbol &&
                        Board[row + 3, col + 3] == symbol)
                    {
                        return true;
                    }
                }
            }

            for (int row = 3; row < 6; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    if (Board[row, col] == symbol &&
                        Board[row - 1, col + 1] == symbol &&
                        Board[row - 2, col + 2] == symbol &&
                        Board[row - 3, col + 3] == symbol)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool CheckDraw()
        {
            for (int col = 0; col < 7; col++)
            {
                if (Board[0, col] == '.')
                {
                    return false;
                }
            }

            return true;
        }
    }
}