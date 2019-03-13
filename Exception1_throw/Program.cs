using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception1_throw
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std = null;

            try
            {
                PrintStudentName(std);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }

        private static void PrintStudentName(Student std)
        {
            if (std == null)
                throw new NullReferenceException("Student object is null.");

        }
    }

}
