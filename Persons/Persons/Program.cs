using System;

class Program
{
    static void Main(string[] args)
    {
        Person one = new Person("Kiro", 20, "kiro@pesho.com");
        Person two = new Person("Pesho", 30);

        Console.WriteLine(one);
        Console.WriteLine(two);
    }
}

