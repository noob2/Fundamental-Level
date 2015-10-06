using System;

namespace HumanStudentWorker.Human
{
    abstract class Human : IComparable<Human>
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("firstName", "first name must not be empty");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("lastName", "last name must not be empty");
                }
                this.lastName = value;
            }
        }

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int CompareTo(Human other)
        {
            int result = this.FirstName.CompareTo(other.FirstName);

            if (result == 0)
            {
                return this.LastName.CompareTo(other.LastName);
            }
            return result;
        }
    }
}
