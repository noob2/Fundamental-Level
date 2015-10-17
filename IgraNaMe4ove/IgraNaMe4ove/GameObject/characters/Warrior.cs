using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgraNaMe4ove.GameObject.characters
{
    class Warrior : character
    {
        public Warrior(int x, int y, char symbol = 'W', int health = 100, int mana = 150, int range = 1, int attackDamage = 30) : base(x,y,symbol,health,mana,range,attackDamage)
        {

        }
    }
}
