using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO_ReadWriteByte
{
    class Program
    {
        static void Main(string[] args) {
            String fileName = "./testt.txt";

            FileStream F = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
         
         for (int i = 1; i <= 20; i++) {
            F.WriteByte((byte) i);
         }

            if (File.Exists(fileName))
            {
                Console.WriteLine("The File " + fileName + " exists and contains");

                F.Position = 0;
                for (int i = 0; i <= 20; i++)
                {
                    Console.Write(F.ReadByte() + " ");
                }
            }

            else
            {
                Console.WriteLine("The File " + fileName + " does not Exist");
            }


            F.Close();
         Console.ReadKey();
      }
   }
}