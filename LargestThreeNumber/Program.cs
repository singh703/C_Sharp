using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestThreeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;  
            int c = 3;

            if (a > b && a > c)
            {
                Console.WriteLine("a is greater number");
            }
            else if (b > c && b > a)
            {
                Console.WriteLine("b is greater number");
            }
            else
            {
                Console.WriteLine("c is greater number");
            }
        }
    }
}
