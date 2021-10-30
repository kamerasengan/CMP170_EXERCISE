using System;
using System.IO;
namespace MyDocumentsFolder
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:/OneDrive/Documents";

            var files = Directory.GetDirectories(path);

            foreach(var file in files)
            {
                Console.WriteLine(file);
            }
        }
    }
}
