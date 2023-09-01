using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Count_Odd_Even
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int evenCount = 0;
            int oddCount = 0;
            int[] Arr = { 1, 2, 3, 4, 5, 6, 7, 8, };

            for (int i = 0; i < Arr.Length; i++)
            {
                if ((i % 2) == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }

            }
            Console.WriteLine(evenCount);

            Console.WriteLine(oddCount);

        }
    }
}
