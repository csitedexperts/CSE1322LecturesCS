using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO_WriteAllText
{
    class Program
    {
        static void Main(string[] args)
        {
            String fileName = "./test.txt";
            String fileContent = null;


            if (File.Exists(fileName))
            {
                fileContent = File.ReadAllText(fileName);
                Console.WriteLine("The File " + fileName + " exists and contains");

                Console.WriteLine(fileContent);
            }
            Console.WriteLine("Please enter new content for the file:");
            String newContent = Console.ReadLine();
            File.WriteAllText(fileName, newContent);

            fileContent = File.ReadAllText(fileName);
            Console.WriteLine("The File " + fileName + " exists and contains");

            Console.WriteLine(fileContent);

            Console.ReadKey();

        }
    }
}