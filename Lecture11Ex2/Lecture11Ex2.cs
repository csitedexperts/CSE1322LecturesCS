using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11Ex2
{
    class Lecture11Ex2
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Example2..........");

            int a = 42;
            Console.WriteLine(a);
            B(ref a);
            Console.WriteLine(a);
            Console.ReadKey();

        }
        static void B(ref int x)
        {
            x += 9;
            Console.WriteLine(x);
        }

    }
}
