using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project02
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Two Number");
            int n1= Convert.ToInt32(Console.ReadLine());
            int n2= Convert.ToInt32(Console.ReadLine());
            int n3 = n1 + n2;
            Console.WriteLine(+n3);
        }
    }
}
