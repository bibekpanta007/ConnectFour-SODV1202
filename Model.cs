namespace Connect_Four
{
    internal class Model
    {
        private char[,] board = new char[6, 7];

        public Model()
        {
            InitializeBoard();
        }

        private void InitializeBoard()
        {
            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 7; j++)
                    board[i, j] = '.';
        }

        public char[,] GetBoard()
        {
            return board;
        }
    }
}