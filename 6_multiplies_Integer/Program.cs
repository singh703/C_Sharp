using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_multiplies_Integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };

            int multiply()
            {
                int mul = 1;
                for (int i = 0; i < arr.Length; i++)
                    mul *= arr[i];
                return mul;

                
            }
            Console.WriteLine(multiply());
        }
    }
}
