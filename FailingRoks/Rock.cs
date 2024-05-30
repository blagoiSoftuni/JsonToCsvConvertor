namespace FailingRoks
{
    internal class Rock
{
        public int X { get; set; }
        public int Y { get; set; }
        public char Symbol { get; private set; }

        public Rock(int x)
        {
            X = x;
            Y = 0;
            Symbol = 'A'; 
        }
    }
}

