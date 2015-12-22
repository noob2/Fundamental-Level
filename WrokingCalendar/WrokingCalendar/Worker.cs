using System;
using System.Collections.Generic;

namespace WrokingCalendar
{
    public class Worker
    {
        private string firstName;
        private string lastName;
        private int salary;
        private readonly IList<DateTime> workingDays = new List<DateTime>();

        public Worker(string firstName, string lastName, int salary = 0)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
            this.WorkingDays = workingDays;
        }

        public void AddWorkingDayThisMounth(int day)
        {
            DateTime today = DateTime.Now;

            DateTime date = new DateTime(today.Year, today.Month, day);
            this.workingDays.Add(date);
        }

        public void RemoveWorkingDayThisMounth(int day)
        {
            DateTime today = DateTime.Now;

            DateTime date = new DateTime(today.Year, today.Month, day);
            this.workingDays.Remove(date);
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(firstName))
                {
                    throw new ArgumentNullException(firstName,"first name should not be empty or whitespace");
                }
                this.firstName = value;
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
                if (!string.IsNullOrWhiteSpace(lastName))
                {
                    throw new ArgumentNullException(lastName, "last name should not be empty or whitespace");
                }
                this.lastName = value;
            }
        }

        public int Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                if (salary < 0)
                {
                    throw new ArgumentOutOfRangeException(salary.ToString(), "salary should not be negative");
                }
                this.salary = value;
            }
        }

        public IList<DateTime> WorkingDays { get; private set; }
    }
}
