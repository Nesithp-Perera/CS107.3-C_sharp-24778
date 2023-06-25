using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class FindValues
    {
        public double findArea(double radius)
        {
            double area = Math.PI * radius * radius;
            return area;

        }

        public double findCircumference(double radius) 
        {
            double circumference = Math.PI * radius * 2;
            return circumference;

        }
    }
}
