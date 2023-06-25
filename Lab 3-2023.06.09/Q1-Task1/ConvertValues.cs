using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_Task1
{
    internal class ConvertValues
    {
        public void kilometerTOmeter()
        {
            double kilometers, meters;

            Console.WriteLine("Enter kilometers value:  ");
            kilometers = double.Parse(Console.ReadLine());

            meters = kilometers * 1000;

            Console.WriteLine("The meter value of entered kilometer value is: " + meters);
        }
    }
}
