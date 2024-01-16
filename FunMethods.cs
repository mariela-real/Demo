using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class FunMethods : NumbersGame
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
        public override int RepeatedValuesArray(int[] array)
        {
            Dictionary<int, int> frequency = new Dictionary<int, int>();

            foreach (int number in array)
            {
                if (frequency.ContainsKey(number))
                {
                    frequency[number]++;
                }
                else
                {
                    frequency[number] = 1;
                }
            }

            int frequentNumber = frequency.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;

            return frequentNumber;
        }



    }
}
