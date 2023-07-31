using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Arrayc
    {
        public int[] CreateArray(int size)
        {
            return new int[size];
        }

        public void PopulateArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Value {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        public int[] VectorSum(int[] array1, int[] array2)
        {
            int size = Math.Min(array1.Length, array2.Length);
            int[] result = new int[size];

            for (int i = 0; i < size; i++)
            {
                result[i] = array1[i] + array2[i];
            }

            return result;
        }

        public int[] VectorProduct(int[] array1, int[] array2)
        {
            int size = Math.Min(array1.Length, array2.Length);
            int[] result = new int[size];

            for (int i = 0; i < size; i++)
            {
                result[i] = array1[i] * array2[i];
            }

            return result;
        }

        public int ScalarSum(int[] array1, int[] array2)
        {
            int size = Math.Min(array1.Length, array2.Length);
            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum += array1[i] + array2[i];
            }

            return sum;
        }

        public int ScalarProduct(int[] array1, int[] array2)
        {
            int size = Math.Min(array1.Length, array2.Length);
            int product = 1;

            for (int i = 0; i < size; i++)
            {
                product *= array1[i] * array2[i];
            }

            return product;
        }

        public void DisplayArray(int[] array)
        {
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}
