using Animals.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  Create an abstract class Animal holding name, age and gender.
//	Create a hierarchy with classes Dog, Frog, Cat, Kitten and Tomcat.
//  Dogs, frogs and cats are animals.Kittens are female cats and Tomcats are male cats.
//  Define useful constructors and methods.
//	Define an interface ISoundProducible which holds the method ProduceSound(). 
//  All animals should implement this interface. 
//  The ProduceSound() method should produce a specific sound depending on the animal invoking it(e.g.the dog should bark).
//	Create an array of different kinds of animals and calculate the average age of each kind of animal using LINQ.


namespace Animals
{
    class Program
    {
        static void Main()
        {
            Dog dog = new Dog("joni",2,"male","nemska ov4arka");
            Frog frog = new Frog("Jabcho", 1, "female", "green");
            Cat cat = new Cat("Melisa", 3, "male", "ulichna");
            Tomcat tomcat = new Tomcat("Tom", 4, "domashna");
            Kitten kitten = new Kitten("Minka", 2, "persijska");
        }
    }
}
