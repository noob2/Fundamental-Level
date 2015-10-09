using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHyerarchy.SalesAndProjects
{
    class Sale
    {
        private string productName;
        private int price;

        public string ProductNasme
        {
            get
            {
                return productName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("productName", "product name must not be empty");
                }
                this.productName = value;
            }
        }

        public  DateTime Date { get; set;}

        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("price", "price must be positive number");
                }
                this.price = value;
            }
        }

        public Sale(string productName, DateTime date, int price)
        {
            this.ProductNasme = productName;
            this.Date = date;
            this.Price = price;
        }
    }
}
