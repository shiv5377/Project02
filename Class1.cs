using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project02
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int a = 15;
            int b = 20;
            int c = a + b;
            int d = b - a;
            int e = a * b;
            int f = a / b;

            Console.WriteLine("addition is "+c);
            Console.WriteLine("substraction is " + d);
            Console.WriteLine("multiplication is " + e);
            Console.WriteLine("division is " +f);
        }
    }
}