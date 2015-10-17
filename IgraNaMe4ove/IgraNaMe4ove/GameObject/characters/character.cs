using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgraNaMe4ove.GameObject.characters
{
    public abstract class character : GameObject
    {
        public character(int x, int y, char symbol, int health, int mana, int range , int attackDamage) : base(x,y,symbol)
        {
            this.Health = health;
            this.Mana = mana;
            this.Range = range;
            this.AttackDamage = attackDamage;
        }

        private int mana;
        private int health;
        private int range;
        private int attackDamage;

        public int Mana
        {
            get
            {
                return this.mana;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("mana", "mana must be positive !");
                }
                this.mana = value;
            }
        }

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
            set
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
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("attackDamage", "attack damage must be positive !");
                }
                this.attackDamage = value;
            }
        }

        public void Attack(enemy.Enemy target)
        {
            target.Health -= AttackDamage;
        }
    }
}
