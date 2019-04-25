using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Exception_CustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            Student newStudent = null;

            try
            {
                newStudent = new Student();
                newStudent.StudentName = "Mokter Hossain";
                MatchStudentName(newStudent);

                ValidateStudentName(newStudent);

            }

            catch (MismatchStudentNameException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (InvalidStudentNameException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }

        private static void MatchStudentName(Student std)
        {
            String name = "Mokter Hossain";

            if (!name.Equals(std.StudentName))
                throw new MismatchStudentNameException(std.StudentName);
            
        }

        private static void ValidateStudentName(Student std)
        {
          
            Regex regex = new Regex("^[a-zA-Z]+$");

            if (!regex.IsMatch(std.StudentName))
                throw new InvalidStudentNameException(std.StudentName);

        }
    }
}
