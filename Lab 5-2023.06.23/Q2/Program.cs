using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the arrays:");
            int size = int.Parse(Console.ReadLine());

            Arrayc arrayHandler = new Arrayc();

            int[] array1 = arrayHandler.CreateArray(size);
            int[] array2 = arrayHandler.CreateArray(size);

            Console.WriteLine("Enter values for the first array:");
            arrayHandler.PopulateArray(array1);

            Console.WriteLine("Enter values for the second array:");
            arrayHandler.PopulateArray(array2);

            int[] vectorSum = arrayHandler.VectorSum(array1, array2);
            int[] vectorProduct = arrayHandler.VectorProduct(array1, array2);
            int scalarSum = arrayHandler.ScalarSum(array1, array2);
            int scalarProduct = arrayHandler.ScalarProduct(array1, array2);

            Console.WriteLine("Scalar Sum: " + scalarSum);

            Console.WriteLine("Vector Sum:");
            arrayHandler.DisplayArray(vectorSum);

            Console.WriteLine("Vector Product:");
            arrayHandler.DisplayArray(vectorProduct);

            Console.WriteLine("Scalar Product: " + scalarProduct);

            Console.ReadKey();
        }
    }
}
