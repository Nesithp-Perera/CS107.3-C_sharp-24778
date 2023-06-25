using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConvertValues objConvertValues = new ConvertValues();
            Console.WriteLine("Enter kilometers value: ");
            double kilometers = double.Parse(Console.ReadLine());
            objConvertValues.KilometerToMeter(kilometers);
            Console.ReadKey();
        }
    }
}
