using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11Ex3
{
    class Lecture11Ex3
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Example3..........");

            int a; // Initialization is optional
            //Console.WriteLine(a);
            B(out a);
            Console.WriteLine(a);
            Console.ReadKey();

        }
        static void B(out int x)
        {
            x = 9;
            Console.WriteLine(x);
        }

    }
}
