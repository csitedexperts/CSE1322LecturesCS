using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOperationsTest2AB
{
    class StringOperationsTest2AB
    {
        static void Main(string[] args)
        {
            String oop = "I like Object-Oriented Programming";

            
            Console.WriteLine(oop.Substring(7, 14));

            String s = "Object Orientation";
            s = s + s.Length;
            Console.WriteLine(s);
            String river = "Mississippi River";
            Console.WriteLine(river.Substring(0, 6));

            Console.WriteLine(river.Substring(2, river.Length - 3));
            Console.WriteLine(river.Substring(2));

            Console.ReadKey();

        }
    }
}
