using System;

namespace ExceptionHandling
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value","first name cannot be null or empty !");
                }
                else
                {
                    this.firstName = value;
                }
            }
        }
        public string LastName

        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value", "last name cannot be null or empty !");
                }
                else
                {
                    this.lastName = value;
                }
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0 || value > 120)
                {
                    throw new ArgumentOutOfRangeException("value", "age must be in the range : 0 - 120 !");
                }
                else
                {
                    this.age = value;
                }
            }
        }

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }


    }
}
