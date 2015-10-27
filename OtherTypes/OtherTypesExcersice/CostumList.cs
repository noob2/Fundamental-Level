using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherTypesExcersice
{
    public class CostumList<T> where T : IComparable<T>
    {
        private const int DefaultCapacity = 8;
        private T[] elements;
        private int currentIndex;

        private void Resize()
        {
            T[] newElements = new T[this.elements.Length * 2];

            for (int i = 0; i < currentIndex; i++)
            {
                newElements[i] = elements[i];
            }
            this.elements = newElements;
        }

        public CostumList(int capacity = DefaultCapacity)
        {
            this.elements = new T[capacity];
            currentIndex = 0;
        }

        public void Add(T elementToAdd)
        {
            if (this.currentIndex >= this.elements.Length)
            {
                Resize();
            }

            elements[currentIndex] = elementToAdd;
            currentIndex++;
        }

        public int IndexOf(T elementToFind)
        {
            for (int i = 0; i < currentIndex; i++)
            {
                if (this.elements[i].Equals(elementToFind))
                {
                    return i;
                }
            }

            return -1;
        }

        public void Remove(T elementToRemove)
        {
            int index = this.IndexOf(elementToRemove);

            if (index == -1)
            {
                throw new ArgumentNullException("the element is missing");
            }

            for (int i = index; i < currentIndex-1; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }
            this.currentIndex--;
            this.elements[currentIndex] = default(T);
        }

        public T Max()
        {
            if (this.currentIndex == 0)
            {
                throw new ArgumentNullException("the list is empty");
            }

            T maxElement = this.elements[0];

            for (int i = 1; i < currentIndex; i++)
            {
                if (maxElement.CompareTo(this.elements[i]) < 0)
                {
                    maxElement = this.elements[i];
                }
            }
            return maxElement;
        }

        public T Min()
        {
            if (this.currentIndex == 0)
            {
                throw new ArgumentNullException("the list is empty");
            }

            T minElement = this.elements[0];

            for (int i = 1; i < currentIndex; i++)
            {
                if (minElement.CompareTo(this.elements[i]) > 0)
                {
                    minElement = this.elements[i];
                }
            }
            return minElement;
        }

        public T this[int i]
        {
            get
            {
                if (i < 0 || i >= this.currentIndex)
                {
                    throw new IndexOutOfRangeException("Index was outside of the boundaries of the CostumList method");
                }
                return this.elements[i];
            }
            set
            {
                this.elements[i] = value;
            }
        }

        public override string ToString()
        {
            return string.Format("[{0}]", string.Join(", ", this.elements.Take(currentIndex)));
        }
    }
}
