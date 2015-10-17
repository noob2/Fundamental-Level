using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgraNaMe4ove.GameObject.enemy
{
    class Wolf : Enemy
    {
        public Wolf(int x, int y, char symbol = 'W', int health = 50, int range = 1, int attackDamage = 20) : base(x,y,symbol,health,range,attackDamage)
        {

        }
    }
}
