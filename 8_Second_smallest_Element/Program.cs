using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Second_smallest_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 132, 13, 25, 9, 34, 1 };
            int n = arr.Length;
            Array.Sort(arr);
            Console.WriteLine("Smallest element is " + arr[0]);
            Console.WriteLine("Second smallest element is " + arr[1]);
        }
    }
}
