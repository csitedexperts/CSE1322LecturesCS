using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11Ex3
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Example3..........");

            int a = 42;
            Console.WriteLine(a);
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
