using System;
using System.IO;

namespace filesystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\Samples";
            string userDirectory = "wishList";

            string newDirectoryFullPath = $@"{rootDirectory}\{userDirectory}";
            Console.WriteLine(newDirectoryFullPath);


            Directory.CreateDirectory(newDirectoryFullPath);

        }
    }
}
