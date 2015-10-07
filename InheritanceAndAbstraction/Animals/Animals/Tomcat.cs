using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Animals
{
    class Tomcat : Cat, ISoundProducible
    {
        private const string tomcatGenger = "male";
        public Tomcat(string name, int age, string breed) : base(name, age, tomcatGenger, breed)
        {

        }
        public void ProduceSound()
        {
            Console.WriteLine("Mauuu");
        }
    }
}
