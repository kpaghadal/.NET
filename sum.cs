using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class sum
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the number:1");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the number:2");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"sum of {a} + {b} numbers: " + (a + b));

        }
        }
}
