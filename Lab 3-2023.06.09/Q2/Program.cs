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
            FindValues objFindValues = new FindValues();

            Console.WriteLine("Enter radius: ");
            double radius=double.Parse(Console.ReadLine());

            double area = objFindValues.findArea(radius);
            double circumference = objFindValues.findCircumference(radius);
            Console.WriteLine("The area: " + area);
            Console.WriteLine("The circumference: " + circumference);
            Console.ReadKey();  
        }
    }
}
