using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceEx1BookShop
{
    public class GoldenEditionBook : Book
    {
        private const double overcharge = 1.3; // +30%

        public GoldenEditionBook(string title, string author, double price)
            : base(title,author,price)
        {

        }

        public override double Price
        {
            get
            {
                return base.Price*overcharge;
            }
        }
    }
}
