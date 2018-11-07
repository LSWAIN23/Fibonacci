using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Create a console app that outputs the Fibonacci Sequence by each iteration.

namespace Fibonacci
{
    class Program
    {
        static void Fib(int num)
        {
            int a = 0, b = 1, c = 0;
            string output = a + ", ";

            for (int i = 2; i < num; i++)
            {
                c = a + b;
                Console.Clear();
                Console.WriteLine("Press Enter to see the next number in Fibonacci's Sequence.\n");
                Console.WriteLine(output);
                Console.ReadKey();
                output += b + ", ";

                a = b;
                b = c;
            }
        }

        static void Main(string[] args)
        {      

            Fib(25);
        }
    }
}
