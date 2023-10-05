using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapnumbers
{
    internal class testdata
    {
        static void Main(string[] args)
        {
            double x, y, z;
            Console.WriteLine("enter first number:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter second number:");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter third number:");
            z = Convert.ToDouble(Console.ReadLine());
            double result1 = (x + y) * z;
            double result2 = (x * y) + (y * z);
            Console.WriteLine($"result of specified numbers {x},{y},{z},(x+y).z is {result1} and x.y+y.z is {result2} ");
            Console.ReadLine();

        }
    }
}
