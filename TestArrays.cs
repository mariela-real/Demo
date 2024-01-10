using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class TestArray : Array
    {
        public override int[] InvestedArray(int[] array)
        {
            int[] newArray = new int[array.Length];
            for (int i = 0; array.Length > i; i++)
            {
                newArray[i] = array[array.Length - 1 - i];
            }
            return newArray;
        }
    }
}
