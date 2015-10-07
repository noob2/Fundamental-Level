using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Animals
{
    class Frog : Animal
    {
        private string colour;

        public string Colour
        {
            get
            {
                return this.colour;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("colour", "colour must not be empty");
                }
                this.colour = value;
            }
        }

        public Frog(string name, int age, string gender, string colour) : base(name, age, gender)
        {
            this.Colour = colour;
        }
    }
}
