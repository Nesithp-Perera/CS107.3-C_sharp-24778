using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Arrayc
    {
        public int[] CreateArray(int size)
        {
            return new int[size];
        }

        public void AddValueToArray(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i += 2)
            {
                if (array[i] == 0)
                {
                    array[i] = value;
                    break;
                }
            }
        }
    }
}
