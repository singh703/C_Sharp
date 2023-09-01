using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_class
{
    internal class Program
    {
        public static class MathHelper
        {
            public static double CalculateAverage(int[] numbers)
            {
                if (numbers == null || numbers.Length == 0)
                {
                    return 0;
                }

                int total = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    total += numbers[i];
                }

                return (double)total / numbers.Length;
            }
        }
}
