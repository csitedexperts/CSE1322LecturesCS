using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = "Agent";
            s = s + s.Length;
            Console.WriteLine(s);
            String river = "Mississippi";

            Console.WriteLine(river.Substring(1, 2));
            Console.WriteLine(river.Substring(2, river.Length - 3));
            Console.WriteLine(river.Substring(1));
            Console.WriteLine(river.Substring(4, 1)); // [4, 1]
            Console.ReadKey();
        }
    }
}
