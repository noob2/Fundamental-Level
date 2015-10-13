using System.Collections.Generic;
using System.Linq;
using TheSlum.Interfaces;
using TheSlum.items;

namespace TheSlum.characters
{
    public class Warrior : Character , IAttack
    {
        public Warrior(string id, int x, int y,int healthPoints, int defensePoints,
            int attackPoints, Team team, int range )
            : base(id,x,y,healthPoints,defensePoints, team,range)
        {
            this.AttackPoints = attackPoints;
        }

        public int AttackPoints { get; set; }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
            ApplyItemEffects(item);
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            var target = targetsList.FirstOrDefault(ch => (ch.Team != this.Team && ch.IsAlive));
            return target;
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
            RemoveItemEffects(item);
        }

        public override string ToString()
        {
            string baseStr = base.ToString();
            return baseStr + string.Format(", Attack: {0}", this.AttackPoints);
        }
    }
}
