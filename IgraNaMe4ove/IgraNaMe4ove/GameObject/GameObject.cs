using System;

namespace IgraNaMe4ove.GameObject
{
    public abstract class GameObject
    {
        public GameObject(int x, int y, char symbol)
        {
            this.X = x;
            this.Y = y;
            this.Symbol = symbol;
        }

        private int x;
        private int y;
        private char symbol;

        public int X
        {
            get
            {
                return this.x;
            }
            set
            {
                if (value < 0 && value < GameEngine.rowSize)
                {
                    throw new ArgumentOutOfRangeException("X","X-position must be in the console !");
                }
                this.x = value;
            }
        }

        public int Y
        {
            get
            {
                return this.y;
            }
            set
            {
                if (value < 0 && value < GameEngine.colSize)
                {
                    throw new ArgumentOutOfRangeException("Y", "Y-position must be in the console !");
                }
                this.y = value;
            }
        }

        public char Symbol
        {
            get
            {
                return this.symbol;
            }
            protected set
            {
                this.symbol = value;
            }
        }

    }
}
