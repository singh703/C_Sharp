using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Remove_Duplicates_values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 10, 20, 230, 34, 56, 10, 12, 34, 56, 56 };
            Console.WriteLine("Array before removing duplicate values: ");
            Array.ForEach(data, i => Console.WriteLine(i));


            int[] unique = data.Distinct().ToArray();

            Console.WriteLine("Array after remove duplicate values: ");
            Array.ForEach(unique, j => Console.WriteLine(j));
        }
    }
}
