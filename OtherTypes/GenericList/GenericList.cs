using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GenericList
{
    [Version(0, 1)]
    public class GenericList<T> where T : IComparable<T>
    {
        private const int DefaultCapacity = 16;

        private T[] elements;
        private int currentIndex;

        public GenericList(int capacity = DefaultCapacity)
        {
            this.elements = new T[capacity];
            this.currentIndex = 0;
        }

        private void Resize()
        {
            T[] newElements = new T[this.elements.Length * 2];

            for (int i = 0; i < currentIndex; i++)
            {
                newElements[i] = elements[i];
            }
            this.elements = newElements;
        }

        public void Add(T element)
        {
            if (this.currentIndex >= this.elements.Length)
            {
                Resize();
            }

            this.elements[currentIndex] = element;
            currentIndex++;
        }

        public T this[int i]
        {
            get
            {
                if (i < 0 || i >= this.currentIndex)
                {
                    throw new IndexOutOfRangeException("GenericList does not contain this element");
                }

                return this.elements[i];
            }
            set
            {
                this.elements[i] = value;
            }
        }

        public void Remove(int elementIndex)
        {
            if (elementIndex < 0 || elementIndex >= this.currentIndex)
            {
                throw new IndexOutOfRangeException("GenericList does not contain this element");
            }

            for (int i = elementIndex; i < currentIndex-1; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }
            currentIndex--;

            elements[currentIndex] = default(T);
        }

        public void Insert(T element,int position)
        {
            if (this.currentIndex >= this.elements.Length)
            {
                Resize();
            }

            if (position < 0 || position >= this.currentIndex)
            {
                throw new IndexOutOfRangeException("GenericList does not contain this element");
            }

            for (int i = currentIndex; i > position; i--)
            {
                this.elements[i] = this.elements[i - 1];
            }
            this.elements[position] = element;

            currentIndex++;
        }

        public void Clear()
        {
            for (int i = 0; i < currentIndex; i++)
            {
                this.elements[i] = default(T);
            }
            currentIndex = 0;
            //TO DO : resize to 16
        }

        public int FindIndexOf(T value)
        {
            for (int i = 0; i < currentIndex; i++)
            {
                if (elements[i].CompareTo(value) == 0)
                {
                    return i;
                }
            }
            throw new ArgumentNullException("the value was not found");
        }

        public bool Contains(T value)
        {
            for (int i = 0; i < currentIndex; i++)
            {
                if (elements[i].CompareTo(value) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            string result = string.Format
                ("[{0}]", string.Join(", ", this.elements.Take(currentIndex)));
            return result;
        }

        public T Min()
        {
            if (this.currentIndex == 0)
            {
                throw new ArgumentNullException("the list is empty");
            }

            T min = elements[0];

            for (int i = 1; i < currentIndex; i++)
            {
                if (min.CompareTo(elements[i]) == +1)
                {
                    min = elements[i];
                }
            }
            return min;
        }

        public T Max()
        {
            if (this.currentIndex == 0)
            {
                throw new ArgumentNullException("the list is empty");
            }

            T max = elements[0];

            for (int i = 1; i < currentIndex; i++)
            {
                if (max.CompareTo(elements[i]) == -1)
                {
                    max = elements[i];
                }
            }
            return max;
        }

        public void Version()
        {
            Type type = typeof(GenericList<T>);
            object[] allAttributes = type.GetCustomAttributes(false);

            foreach (var ver in allAttributes)
            {
                if (ver is Version)
                {
                    Version temp = ver as Version;
                    Console.WriteLine("GenericList v.{0}.{1}", temp.Major, temp.Minor);
                }
            }
        }
    }
}