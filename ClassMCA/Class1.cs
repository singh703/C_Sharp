using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMCA
{
    internal class Class1
    {
        string[] names = new string[4];

        public void inputData()
        {
            Console.WriteLine("Enter Members name: ");

            for (int i=0; i<4; i++){
            Console.WriteLine("Enter name of Member{0}",(i+1));
            names[i] = Console.ReadLine();
            }
}

public  void shoData()
{
    Console.WriteLine("Enter Members name ");
    for (int i = 0; i < 4; i++)
    {
        Console.WriteLine("Name of members{0} is {1}",(i + 1),names[i]);
            }
        }
    }
}
