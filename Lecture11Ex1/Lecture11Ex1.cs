using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11Ex1
{
    class Lecture11Ex1
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Example1..........");

            int a = 42;
            Console.WriteLine(a);  // 42
            B(a);  // ???  51 
            Console.WriteLine(a);  // ????????????????????   
            Console.ReadKey();

        }
        static void B(int x)
        {
            x += 9;
            Console.WriteLine(x);
        }

    }
}
