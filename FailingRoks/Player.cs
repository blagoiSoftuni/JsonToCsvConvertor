using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FailingRoks
{
    public class Player
    {
        int x;
        int y;

        String representation;

        bool hasBeenHit;
        
        public Player(int x, int y)
        {
           this.X = x;
            this.Y = y;
            Representation = "P"; 
            HasBeenHit = false;
        }
        public int X { get; set; }
        public int Y { get; set; }
        public string Representation { get; set; }
        public bool HasBeenHit { get;  set; }


       public void Draw() {
            Console.SetCursorPosition(X, Y);
            Console.Write(Representation);
        }
       public void Move() {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                ClearKeyAvailableBuffer();

                switch (key.Key)
                {
                    case ConsoleKey.LeftArrow:
                        X = Math.Max(0, X - 1);
                        break;
                    case ConsoleKey.RightArrow:
                        X = Math.Min(Console.WindowWidth - 1, X + 1);
                        break;
                }
            }
        }

        public bool IsOutOfConsoleBoundaries()
        {
            return X < 0 || X >= Console.WindowWidth || Y < 0 || Y >= Console.WindowHeight;
        }

        public void ClearKeyAvailableBuffer()
        {
            while (Console.KeyAvailable)
            {
                Console.ReadKey(true);
            }
        }
    }
}
        

   
