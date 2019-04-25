using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 85;
            int y = 7;
            Console.WriteLine("PRINTLINE 1: " + x + " " +y); // PRINTLINE 1
            int z = DoIt(x, ref y);
            Console.WriteLine("PRINTLINE 2: " + x + "  " +y + " "  +z);  // PRINTLINE 2
            Console.ReadKey();
        }

        static int DoIt(int a, ref int b)
        {
            a += 5;
            b -= 8;
            Console.WriteLine("PRINTLINE 3: " + a + " " +b); // PRINTLINE 3
            return (a + b);
        }

    }
}
