using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11Ex42
{
    class Program
    {

        static void Main(String[] args)
        {
            String myName = "Mokter";
            Console.WriteLine(myName);
            B( myName);
            Console.WriteLine(myName);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        static void B(String myName)
        {
            myName = "Mokter Hossain";
            Console.WriteLine(myName);
        }
    }
}

