using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_LargestElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int largest = 0;
                int[] Arr = { 4, 2, 35, 4, 5, 6 };

                for (int i = 0; i < Arr.Length; i++)
                {
                    if (largest <= Arr[i])
                    {
                        largest = Arr[i];
                    }
                }
                Console.WriteLine("Largest Element is: "largest);
            }
    }
}
