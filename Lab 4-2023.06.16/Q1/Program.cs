using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateValues calculator = new CalculateValues();

            Console.WriteLine("Enter the number 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number 2: ");   
            int num2 = int.Parse(Console.ReadLine());


            Console.WriteLine("Choose the operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.Write("Enter your choice (1-4): ");
            int choice = int.Parse(Console.ReadLine());

            double quotient;
            int result;

            switch (choice)
            {
                case 1:
                    {
                        result = calculator.Add(num1, num2);
                        Console.WriteLine($"Sum: {result}");
                        break;
                    }

                case 2:
                    {
                        result = calculator.Subtract(num1, num2);
                        Console.WriteLine($"Difference: {result}");
                        break;
                    }

                   

                case 3:
                    {
                        result = calculator.Multiply(num1, num2);
                        Console.WriteLine($"Product: {result}");
                        break;
                    }

                case 4:
                    {
                        quotient = calculator.Divide(num1, num2);
                        Console.WriteLine($"Quotient: {quotient}");
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Invalid choice!");

                        break;
                    }
            }

            Console.ReadLine();
        }
    }
}
