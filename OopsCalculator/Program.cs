using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace OopsCalculator
{
    internal class Program
    {
        public class Calc
        {
            int num1;
            int num2;
            int result;

            void Add()
            {
                result = num1 + num2;
                Console.WriteLine(result);
                Console.ReadLine();
            }

            void Sub()
            {
                result = num1 - num2;
                Console.WriteLine(result);
                Console.ReadLine();
            }
        }
        static void Main(string[] args)
        {
            Calc obj = new Calc();
            obj.num1 = 20;
            obj.num2 = 30;
            obj.Add();
            obj.Sub();
        }
    }
}
