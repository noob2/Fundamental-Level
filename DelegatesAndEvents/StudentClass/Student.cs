using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    public delegate void PropertyChangedEventHandler(Student student, PropertyChangedEventArgs args);

    public class PropertyChangedEventArgs : EventArgs
    {
        public PropertyChangedEventArgs(string propertyName,dynamic oldValue,dynamic newValue)
        {
            this.PropertyName = propertyName;
            this.OldValue = oldValue;
            this.NewValue = newValue;
        }

        public string PropertyName { get; set; }
        public dynamic OldValue { get; set; }
        public dynamic NewValue { get; set; }
    }

    public class Student
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string name;
        private int age;
        public Student(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (this.PropertyChanged != null)
                {
                    this.PropertyChanged(this,
                        new PropertyChangedEventArgs("Name", this.name, value));
                }

                this.name = value;
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
                if (this.PropertyChanged != null)
                {
                    this.PropertyChanged(this,
                        new PropertyChangedEventArgs("Age", this.age, value));
                }

                this.age = value;
            }
        }
    }
}
