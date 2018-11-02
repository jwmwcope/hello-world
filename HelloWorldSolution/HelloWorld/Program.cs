using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("Type something");
            string input = Console.ReadLine();
            Console.WriteLine($"You wrote {input}");
            Console.WriteLine("Goodbye World");
            Console.ReadLine();
        }
    }
}
