using Cosmetics.Common;
using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cosmetics.Products
{
    public class Category : ICategory
    {
        const int MinLength = 2;
        const int MaxLength = 15;

        private string name;
        private IList<IProduct> products;

        public Category(string name)
        {
            this.products = new List<IProduct>();
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.ObjectCannotBeNull, "Categoty name"));

                Validator.CheckIfStringLengthIsValid(value, MinLength, MaxLength, string.Format(GlobalErrorMessages.InvalidStringLength, "Category name", MinLength, MaxLength));

                this.name = value;
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            this.products.Add(cosmetics);
        }

        public string Print()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} category - {1} product{2} in total{2}", this.Name, this.products.Count, this.products.Count == 1 ? string.Empty : "s", Environment.NewLine);

            var sortedProducts = this.products.OrderBy(product => product.Brand).ThenByDescending(product => product.Price);

            foreach (var product in this.products)
            {
                sb.AppendLine(product.Print());
            }

            return sb.ToString().Trim();
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            if (this.products.Contains(cosmetics))
            {
                throw new ArgumentException(string.Format("Product {0} does not exists in category {1}!", cosmetics.Name, this.name));
            }

            this.products.Remove(cosmetics);
        }
    }
}
