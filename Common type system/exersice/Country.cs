using System;
using System.Collections.Generic;
using System.Linq;

namespace exersice

{
    class Country : IComparable<Country>, ICloneable
    {
        private string name;
        private ulong population;
        private int area;

        public Country(string name, ulong population, int area, params string[] cities)
        {
            this.name = Name;
            this.population = Population;
            this.area = Area;
            this.Cities = new HashSet<string>(cities);
        }

        public string Name { get; set; }
        public ulong Population { get; set; }
        public int Area { get; set; }
        public HashSet<string> Cities { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as Country;

            if (object.Equals(other, null))
            {
                return other.Name == this.Name;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }

        public int CompareTo(Country other)
        {
            if (this.Area == other.Area)
            {
                if (this.Population == other.Population)
                {
                    return string.Compare(this.Name, other.Name, StringComparison.InvariantCulture);
                }
                return this.Population.CompareTo(other.Population);
            }
            return this.Area.CompareTo(other.Area);
        }

        public object Clone()
        {
            return new Country(this.Name, this.Population,this.Area, this.Cities.ToArray());
        }

        public static bool operator ==(Country country, Country country2)
        {
            if (country == null)
            {
                return false;
            }
            return country.Equals(country2);
        }

        public static bool operator !=(Country country, Country country2)
        {
            return !(country == country2);
        }
    }
}
