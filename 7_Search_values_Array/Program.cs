using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Search_values_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 6, 2, 8, 4, 9, 6, 7, 5 };
            int key = 7;
            bool found = false;

            foreach (int i in arr)
            {
                if (i == key)
                {
                    found = true;
                    break;
                }
            }
            if (found)
            {
                Console.WriteLine("Value found in the array.")
            }
            else
            { 
                Console.WriteLine("Value not found in the array.")
            }
        }
    }
}
