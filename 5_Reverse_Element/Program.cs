using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Reverse_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, };
            
            Console.WriteLine("Original Array");
            PrintArray(numbers);

            ReverseArray(numbers);


            Console.WriteLine("\nReverse Array");
            PrintArray(numbers);
        }

        static void ReverseArray(int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;

            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;

                start++;
                end--;
            }
        }

        static void PrintArray(int[] arr)
        {
            
            foreach (int num in arr)
            {
                Console.WriteLine(num + " ");
            }
            
        }
        
    }
}
