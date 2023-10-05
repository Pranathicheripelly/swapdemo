using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapnumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstnumber, secondnumber, temp;
            Console.WriteLine("input the first number:");
            firstnumber=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input the second number:");
           secondnumber = Convert.ToInt32(Console.ReadLine());
            //swap the numbers using a temporary variable
            temp = firstnumber;
            firstnumber= secondnumber;
            secondnumber= temp;
            Console.WriteLine("after swapping:");
            Console.WriteLine("first number:" + firstnumber);
            Console.WriteLine("second number:" + secondnumber);
            Console.ReadLine();


        }
    }
}
