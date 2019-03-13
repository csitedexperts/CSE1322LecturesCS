using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionJ14_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, d;
            x = 5; y = 10; z = 15;
            try { 
            d = z / (y - 2 * x);  // Exception Makes Here (Division by zero)
            }                //		d = 15/(10-10)  

            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.StackTrace); // In Java  ex.printStackTrace();
                Console.WriteLine("The Exception : "+ ex.Message);  
                Console.WriteLine("Value of d is undetermined");
                Console.WriteLine("\t(Division by zero)");  //ERROR Message
                d = z / (y - x);  // OK and displayed
            }

            Console.WriteLine("Hello friend....");
            Console.WriteLine("d = " + d);

            Console.ReadKey();

        }
    }
}
