using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_3
{
    internal class ArrayOperations
    {
        public static void PerformArrayOperations(int[] array)
        {
            int minValue = array[0];
            int maxValue = array[0];
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minValue)
                    minValue = array[i];

                if (array[i] > maxValue)
                    maxValue = array[i];

                sum += array[i];
            }

            double average = (double)sum / array.Length;

            Console.WriteLine("Minimum value: " + minValue);
            Console.WriteLine("Maximum value: " + maxValue);
            Console.WriteLine("Average value: " + average);

            Array.Reverse(array);

            Console.WriteLine("Reversed order of values:");
            foreach (int value in array)
            {
                Console.WriteLine(value);
            }
        }
    }
}
