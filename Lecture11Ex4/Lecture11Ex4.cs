using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11Ex4
{
    class Lecture11Ex4
    {
        class Z { public int y; }
        static void Main(String[] args)
        {
            Z myZ = new Z();
            myZ.y = 42;
            Console.WriteLine(myZ.y);
            B(myZ);
            Console.WriteLine(myZ.y);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        static void B(Z x)
        {
            x.y += 9;
            Console.WriteLine(x.y);
        }
    }
}

