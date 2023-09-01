using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Search_Value_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 6, 2, 8, 4, 9, 6, 7, 5 };
            int key = 8;
            int foundIndex = -1;

            foreach (int i in arr)
            {
                if (arr[i] == key)
                {
                    foundIndex = i;
                    break;
                }
            }
            if (foundIndex != -1)
            {
                Console.WriteLine($"Value found the index in the array: {foundIndex}");
            }
            else
            {
                Console.WriteLine("Value not found in the array.");
            }

        }
    }
}
