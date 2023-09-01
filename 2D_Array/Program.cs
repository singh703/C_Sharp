using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[3, 3];
            int[,] mat2 = new int[3, 3];
            int[,] mat3 = new int[3, 3];

            Console.WriteLine("Enter first matrix: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mat[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter Second matrix: ");
            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {

                    mat2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Sum of Array is : ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mat3[i, j] = mat[i, j] + mat2[i, j];
                }
            }

            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                { 

                    Console.Write(mat3[i,j]+ " ");
                }
                Console.WriteLine();
            }
        Console.ReadLine();
        }
    }
}
            

            
         
