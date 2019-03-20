using System;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test-1. .  . . ");

            int[] arr = new int[7] { 65, 72, 23, 99, 1, 20, 44 };


            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;                                //Creating loop
                }
                arr[j + 1] = key;
            }

            //the display
            foreach (var item in num)
            {
                Console.WriteLine(item);
            }
        }
    }
}
