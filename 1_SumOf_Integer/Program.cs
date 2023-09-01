using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_SumOf_Integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] myNum = { 10, 20, 30, 40 };

            for (int i=0; i<myNum.Length; i++)
            {
                sum += myNum[i];
            }
            Console.WriteLine(sum);
        }
    }
}
