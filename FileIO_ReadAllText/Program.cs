using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO_ReadAllText
{
    class Program
    {
        static void Main(string[] args)
        {
            String fileName = "C:\\Users\\mhossa12\\testt.txt";
            String fileContent = null;


            if (File.Exists(fileName))
            {
                fileContent = File.ReadAllText(fileName);
                Console.WriteLine("The File " + fileName + " exists and contains");

                Console.WriteLine(fileContent);
            }
            else
            {
                Console.WriteLine("The File " + fileName + " does not exist");

            }

            Console.ReadKey();

        }
    }
}