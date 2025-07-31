using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    /// <summary>
    ///this class incudes imp methods
    /// </summary>
    internal class calcmethod
    {


        /// <summary>
        /// used to share % values
        /// </summary>
        /// 

        int a; //just for demo, delete it when run this program


        /// <summary>
        ///used for swap values of 2 method
        /// </summary>
        /// <param name="a">first ref parameter or variable</param>
        /// <param name="b">second ref parameter or variable</param>
        /// <returns></returns>
        /// 



        static int Add(int a, int b) {
            return a + b; }

        static int Sub(int a, int b)
        {
            return a - b;
        }

        static int div(int a, int b)
        {
            return a / b;
        }

        static int mul(int a, int b)
        {
            return a * b;
        }
        static void Main()
        {
            int a = 20; int b=10; 
            int ra;
            ra= Add(a, b);
            Console.WriteLine("addition : " + ra);
            ra= Sub(a, b);
            Console.WriteLine("subtraction : " + ra);
            ra= div(a, b);
            Console.WriteLine("division : " + ra);
            ra= mul(a, b);
            Console.WriteLine("multiplication : " + ra);
        }
    }
}
