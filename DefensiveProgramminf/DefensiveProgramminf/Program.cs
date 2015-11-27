using System;

namespace DefensiveProgramminf
{
    class Program
    {
        public static int[] SelectionSort(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException("array to sort cannot be null");
            }

            if (array.Length < 2)
            {
                throw new ArgumentNullException("array to sort is too short");
            }

            int[] sortedArray = array;
            int tmp, min_key;

            for (int j = 0; j < sortedArray.Length - 1; j++)
            {
                min_key = j;

                for (int k = j + 1; k < sortedArray.Length; k++)
                {
                    if (sortedArray[k] < sortedArray[min_key])
                    {
                        min_key = k;
                    }
                }

                tmp = sortedArray[min_key];
                sortedArray[min_key] = sortedArray[j];
                sortedArray[j] = tmp;
            }

            return sortedArray;
        }

        static void Main(string[] args)
        {
            int[] array = null;

            array = SelectionSort(array);

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
