using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceEx1BookShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Book mehanika = new Book("Mehanika na tvurdoto tqlo", "A.Murvakov", 12.32);
            Console.WriteLine(mehanika);

            GoldenEditionBook mehanikaGold = new GoldenEditionBook("Mehanika na tvurdoto tqlo", "A.Murvakov", -12.32);
            Console.WriteLine(mehanikaGold);
        }
    }
}
