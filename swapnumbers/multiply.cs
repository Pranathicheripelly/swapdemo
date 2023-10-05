using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapnumbers
{
    internal class multiply
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, result;
            Console.WriteLine("input the first number to multiply:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("input the second number to multiply:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("input the third number to multiply:");
            num3 = Convert.ToInt32(Console.ReadLine());
            result = num1 * num2 * num3;
            Console.WriteLine($"{num1}*{num2}*{num3}={result}");
            Console.ReadLine();

        }
    }
}
