using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionJ14_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, d;
            x = 5; y = 10; z = 15;

            d = z / (y - 2 * x);  // Exception Makes Here (Division by zero)
                                  //		d = 15/(10-10)  

            Console.WriteLine("Hello friend....");
            Console.WriteLine("d = " + d);

            Console.ReadKey();

        }
    }
}
