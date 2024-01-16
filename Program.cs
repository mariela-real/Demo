using System;
using System.Threading.Tasks;

namespace Demo
{ 
    public class Program
    {
        public static void Main(string[] args)
        {
            FunMethods investedArray = new FunMethods();
            int[] newArray = investedArray.InvestedArray([2, 3, 3, 4]);
            int secondArray = investedArray.RepeatedValuesArray([2, 3, 3, 4]);

            Console.Write("[");
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.Write(newArray[i]);
                if (i < newArray.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");

            Console.WriteLine("["+ secondArray+ "]");

           


        }

    }

}