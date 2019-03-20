using System;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)

        {
            String inh = "Inheritane defines a relationship";
            Console.WriteLine(inh.Substring(0, 29));

            String s1 = "polymorphism";
            Console.WriteLine(s1.Replace(s1[0], 'X'));

            String a = "Abstraction";
            a = a.ToString() + (a.Length - a.Length);
            Console.WriteLine(a);

            String state = "Maryland";

            Console.WriteLine(state.Substring(4).ToUpper());

            String city = "Marietta";

            Console.WriteLine(city.Substring(city.Length - 4));
                     


            Console.ReadKey();
        }
    }
}
