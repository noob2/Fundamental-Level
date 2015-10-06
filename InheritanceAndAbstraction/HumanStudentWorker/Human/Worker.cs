using System;

namespace HumanStudentWorker.Worker
{
    class Worker : Human.Human , IComparable<Worker>
    {
        private double workHoursPerDay;

        private double mounthSalary;

        public double WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException
                        ("workHoursPerDay", "work hours per day must be positive number");
                }
                this.workHoursPerDay = value;
            }
        }

        public double MounthSalary
        {
            get
            {
                return this.mounthSalary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException
                        ("mouthSalary", "mounth salary must be positive number");
                }
                this.mounthSalary = value;
            }
        }

        public Worker(string firstName, string lastName, double mounthSalary, double workHoursPerDay)
            : base(firstName,lastName)
        {
            this.MounthSalary = mounthSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double MoneyPerHour()
        {
            double dailySalary = this.mounthSalary / 30;
            double moneyPerHour = dailySalary / this.workHoursPerDay;
            return moneyPerHour;
        }

        public int CompareTo(Worker other)
        {
            return other.MoneyPerHour().CompareTo(this.MoneyPerHour());
        }
    }
}
