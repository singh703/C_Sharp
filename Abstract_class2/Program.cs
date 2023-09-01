using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class2
{
    internal class Program
    {
        public abstract class Animal
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public abstract void Speak();
        }

        public class Dog : Animal
        {
            public override void Speak()
            {
                Console.WriteLine("Woof!");
            }
        }

        public class Cat : Animal
        {
            public override void Speak()
            {
                Console.WriteLine("Meow!");
            }
        }
    }
}
