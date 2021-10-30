using System;
using System.IO;
namespace ReadTextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "D:/OneDrive/Documents/IP.txt";
            string detail = File.ReadAllText(filename);
            Console.WriteLine(detail);
        }
    }
}
