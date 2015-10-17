using IgraNaMe4ove.GameObject.characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgraNaMe4ove.GameObject.enemy
{
    public abstract class Enemy : GameObject
    {
        public Enemy(int x, int y, char symbol, int health, int range, int attackDamage) : base(x,y,symbol)
        {
            this.Health = health;
            this.Range = range;
            this.AttackDamage = attackDamage;
        }

        private int health;
        private int range;
        private int attackDamage;

        public int Health
        {
            get
            {
                return this.health;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("health", "health must be positive !");
                }
                this.health = value;
            }
        }

        public int Range
        {
            get
            {
                return this.range;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("range", "range must be positive !");
                }
                this.range = value;
            }
        }

        public int AttackDamage
        {
            get
            {
                return this.attackDamage;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("attackDamage", "attack damage must be positive !");
                }
                this.attackDamage = value;
            }
        }

        public void Attack(character target)
        {
            target.Health -= AttackDamage;
        }
    }
}
