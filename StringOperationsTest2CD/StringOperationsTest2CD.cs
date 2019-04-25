using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOperationsTest2CD
{
    class StringOperationsTest2CD
    {
        static void Main(string[] args)
        {

            String oop = "Try Taking The Road Less Travelled";

            Console.WriteLine();

            Console.WriteLine(oop.Substring(6, 16));

            String s = "Software Engineering";
            s = s + s.Length;
            Console.WriteLine(s);
            String river = "Tennessee River";
            Console.WriteLine(river.Substring(0, 6));

            Console.WriteLine(river.Substring(2, river.Length - 4));
            Console.WriteLine(river.Substring(4));

            Console.ReadKey();

        }
    }
}
