using System;

namespace StringReverse {
    class Program  {
        static void Main(string[] args){
            String hello = "Hello";

            Console.WriteLine("Reverse of the string '" + hello + "' is : " + reverse(hello));
            Console.ReadKey();
        }
         static String reverse(String str){
            if (str == null || str.Length <= 1)
                return str;
            else{
                return (reverse(str.Substring(1)) + str[0]);  // recursion makes here
            }
        }
    }
}
