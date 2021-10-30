using System;
using System.IO;
namespace MyDrives
{
    class Program
    {
        static void Main(string[] args)
        {
            var drives = DriveInfo.GetDrives();

            foreach(var drive in drives)
            {
                Console.WriteLine("Drive: " + drive.Name);
                Console.WriteLine("Drive Type: " + drive.DriveType);
                Console.WriteLine("Label: " + drive.VolumeLabel);
                Console.WriteLine("Format: " + drive.DriveFormat);
                Console.WriteLine("Size: " + drive.TotalSize);
                Console.WriteLine("Free: " + drive.TotalFreeSpace);
            }    
        }
    }
}
