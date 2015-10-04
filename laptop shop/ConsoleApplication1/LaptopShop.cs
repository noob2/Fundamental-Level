using ConsoleApplication1;
using System;

class LaptopShop
{
    static void Main()
    {
        Laptop laptop = new Laptop("S5",500m);
        Laptop laptop2 = new Laptop("S5", 500m,new Battery("gdfh",34),"ASUS");
        Console.WriteLine(laptop);
        Console.WriteLine(laptop2);
    }
}

