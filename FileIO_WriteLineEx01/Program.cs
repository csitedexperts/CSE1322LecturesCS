using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO_WriteLineEx01
{
    class Program
    {
        static void Main(string[] args)
        {
            String fileName = "C:\\Users\\mhossa12\\testt.txt";

           
            if (File.Exists(fileName))
            {
             Console.WriteLine("Please some content for the file:" + fileName);
             string newContent = Console.ReadLine();
             File.WriteAllText(fileName, newContent);

                Console.WriteLine("The File " + fileName + " exists and contains");
                String content = File.ReadAllText(fileName);
                File.WriteAllText(fileName, content);

                //Console.WriteAllText(fileName, content);

            }
            else{
                Console.WriteLine("The File " + fileName + " does not Exist");
            }
      //   F.Close();
            Console.ReadKey();
        }
    }
}