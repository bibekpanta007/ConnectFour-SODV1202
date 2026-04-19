namespace Connect_Four
{
    // Abstraction: Player defines what a player must do
    internal abstract class Player
    {
        public string Name { get; set; }
        public char Symbol { get; set; }

        protected Player(string name, char symbol)
        {
            Name = name;
            Symbol = symbol;
        }

        // Polymorphism: different players can implement this differently
        public abstract int MakeMove();
    }
}