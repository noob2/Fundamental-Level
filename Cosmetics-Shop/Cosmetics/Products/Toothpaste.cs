using Cosmetics.Common;
using Cosmetics.Contracts;
using System.Collections.Generic;

namespace Cosmetics.Products
{
    public class Toothpaste : Product, IToothpaste
    {
        private IList<string> ingredients;

        public Toothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients) : base(name, brand, price, gender)
        {
            this.ingredients = ingredients;
        }

        public string Ingredients
        {
            get
            {
                return string.Join(", ", this.ingredients);
            }
        }

        public override string Print()
        {
            return string.Format("  * Ingredients: {0}",string.Join(", ",ingredients));
        }
    }
}
