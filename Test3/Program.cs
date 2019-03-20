using System;

namespace Test3
{
    class Program
    {

        static void Main(String[] args)
        {
            int x = 81;
            int y = 9;
            Console.WriteLine(x + " " +y); // printline 1
            int z = DoIt(x, ref y);
            Console.WriteLine(x + " "  +y + " " +z);  // printline 3
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        static int DoIt(int a, ref  int b)
        {
            a += 4;
            b *= 7;
            Console.WriteLine(a + " " +b); // printline 2
            return (a + b);

        }
    }
}
