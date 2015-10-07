using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Animals
{
    class Kitten : Cat
    {
        private const string kittenGenger = "female";
        public Kitten(string name, int age, string breed) : base(name, age, kittenGenger, breed)
        {

        }
    }
}
