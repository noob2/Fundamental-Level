using System;

namespace HumanStudentWorker.Student
{
    class Student : Human.Human , IComparable<Student>
    {
        private string facultyNumber;

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                if (value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentOutOfRangeException("facultyNumber", 
                        "faculty number must contain 5-10 letters");
                }
                this.facultyNumber = value;
            }
        }

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName,lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public int CompareTo(Student other)
        {
            return this.FacultyNumber.CompareTo(other.FacultyNumber);
        }
    }
}
