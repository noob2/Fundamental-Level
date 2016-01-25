using Cosmetics.Contracts;
using System;
using Cosmetics.Common;
using System.Text;

namespace Cosmetics.Products
{
    public abstract class Product : IProduct
    {
        private const int MinProductNameLength = 3;
        private const int MaxProductNameLength = 15;
        private const int MinBrandNameLength = 2;
        private const int MaxBrandNameLength = 10;

        private string name;
        private string brand;

        protected Product(string name, string brand, decimal price, GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
        }

        public string Brand
        {
            get
            {
                return this.brand;
            }

            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.ObjectCannotBeNull, "Product brand"));

                Validator.CheckIfStringLengthIsValid(value, MaxBrandNameLength, MinBrandNameLength, string.Format(GlobalErrorMessages.InvalidStringLength, "Product brand", MinBrandNameLength, MaxBrandNameLength));

                this.brand = value;
            }
        }

        public GenderType Gender { get; private set; }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.ObjectCannotBeNull, "Product name"));

                Validator.CheckIfStringLengthIsValid(value, MaxProductNameLength, MinProductNameLength, string.Format(GlobalErrorMessages.InvalidStringLength, "Product name", MinProductNameLength, MaxProductNameLength));

                this.name = value;
            }
        }

        public virtual decimal Price { get; private set; }


        public virtual string Print()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("- {0} - {1}{2}", this.Brand, this.Name, Environment.NewLine);
            sb.AppendLine("  * Price: $" + this.Price);
            sb.AppendLine("  * For gender: $" + this.Gender.ToString());

            return sb.ToString();
        }
    }
}
