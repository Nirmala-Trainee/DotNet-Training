using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment_5
{
    class Count_Lines
    {
        static void Main()
        {
            string path = "C:\\Nirmala\\Csharp Assignments\\Assignment_5\\Nirmala.txt";
            if (File.Exists(path))
            {
                int lineCount = File.ReadAllLines(path).Length;
                Console.WriteLine("The number of lines in program are :" + lineCount);
            }
            else
            {
                Console.WriteLine("The specified path does not exist");
            }
            Console.ReadLine();
        }
    }
}