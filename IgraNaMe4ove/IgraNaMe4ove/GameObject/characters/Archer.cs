using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgraNaMe4ove.GameObject.characters
{
    class Archer : character
    {
        public Archer(int x, int y, char symbol = 'A', int health = 100, int mana = 150, int range = 4, int attackDamage = 30) : base(x,y,symbol,health,mana,range,attackDamage)
        {

        }
    }
}
