using System;

namespace Connect_Four
{
    internal class Controller
    {
        private Model model;
        private View view;

        // Constructor
        public Controller()
        {
            model = new Model();
            view = new View();
        }

        // This is called by Program.cs
        public void StartGame()
        {
            view.ShowMessage("Game is starting...");
        }
    }
}