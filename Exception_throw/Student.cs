using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception1_throw
{
    class Student
    {
        int Roll; 
        String Name;
        void setData() 
        {
            Roll = 101;
            Name = "Mokter Hossain";
        }
        void display()  
        {
            Console.WriteLine("Inside Student Class...");
            Console.WriteLine("Roll is : " + Roll);
            Console.WriteLine("Name is : " + Name);
        }

    }
}
