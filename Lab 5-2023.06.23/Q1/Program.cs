using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array:");
            int size = int.Parse(Console.ReadLine());

            Arrayc arrayHandler = new Arrayc();
            int[] array = arrayHandler.CreateArray(size);

            Console.WriteLine("Enter values for the array:");

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Value {i + 1}: ");
                int value = int.Parse(Console.ReadLine());
                arrayHandler.AddValueToArray(array, value);
            }

            Console.WriteLine("Array with additional 0 values:");
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.ReadKey();
        }
    }
}
