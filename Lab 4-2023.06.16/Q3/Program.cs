using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            Console.WriteLine("Enter 10 values:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Value " + (i + 1) + ": ");
                array[i] = int.Parse(Console.ReadLine());
            }

            ArrayOperations.PerformArrayOperations(array);
            Console.ReadKey();
        }
    }
}
