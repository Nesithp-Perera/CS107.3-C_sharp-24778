using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_1
{
    internal class CalculateValues
    {

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Divide(int a, int b)
        {
            if (a == 0)
            {
                Console.WriteLine("Error: Division by zero!");
                return 0;
            }
            else if (b == 0)
            {
                Console.WriteLine("Error: Division by zero!");
                return 0;
            }
            else
            {
                return (double)a / b;
            }
        }
    }
}
