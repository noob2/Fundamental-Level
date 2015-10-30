using IgraNaMe4ove.Exceptions;
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
                if (value < 0 && value < GameEngine.MapHeight)
                {
                    throw new ObjectOutOfMapException("X-position must be in the map !");
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
                if (value < 0 && value < GameEngine.MapWidth)
                {
                    throw new ObjectOutOfMapException("Y-position must be in the map !");
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
