using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNumberWithoutUsingThirdVar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("Value of a is = " + a);
            Console.WriteLine("Value of b is = " + b);   
            Console.ReadLine();
        }
    }
}
