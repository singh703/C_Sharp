using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_AverageOfFloatingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float sum = 0;
            float Avg = 0;
            float[] floatArray = { 3.0f, 3.5F, 4.0F, 4.5F, 5.0F };


            for (int i = 0; i < floatArray.Length; i++)
            {
                sum += floatArray[i];
                Avg = sum / floatArray.Length;
            }
            Console.WriteLine("Average is: " + Avg);
        }
    }
}
