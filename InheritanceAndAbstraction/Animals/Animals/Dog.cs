using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Animals
{
    class Dog : Animal, ISoundProducible
    {
        public Dog(string name, int age, string gender, string breed)
            : base(name, age, gender)
        {
            this.Breed = breed;
        }

        private string breed;

        public string Breed
        {
            get
            {
                return this.breed;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                   throw new ArgumentNullException("breed", "bred must not be empty");
                }       
                this.breed = value;
            }
        }

        public void ProduceSound()
        {
            Console.WriteLine("Bau");
        }
    }
}
