﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[10]; /* n is an array of 10 integers */
            int i, j;

            int[] myNums = new int[] { 6, 5, 7, 10 };

            /* output each array element's value */
            for (j = 0; j < myNums.Length; j++)
            {
                Console.WriteLine("myNums[{0}] = {1}", j, myNums[j]);
            }
            Console.ReadKey();


            /* initialize elements of array n */
            for (i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }

            /* output each array element's value */
            for (j = 0; j < 10; j++)
            {
                Console.WriteLine("Element[{0}] = {1}", j, n[j]);
            }
            Console.ReadKey();

            

        }
    }
}
