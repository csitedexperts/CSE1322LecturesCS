using System;

namespace PowerFactorial {
    class Program {
        static void Main(string[] args) {
                        int x = 5, y = 3;
            Console.WriteLine("The " + x + " to the power " + y + " is : " + power(x, y));
            Console.ReadKey();
            
        }
        static int power(int x, int y) {
            if (y == 1) 
                return x;
            else{
                return x * power(x, y - 1);  // recursion makes here
            }
        }

    }
}
