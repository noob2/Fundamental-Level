using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgraNaMe4ove.GameObject
{
    class Wall : GameObject
    {
        public Wall(int x, int y, char symbol = '+') : base(x,y,symbol)
        {
        }
    }
}
