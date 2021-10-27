using System;
using System.IO;

namespace FileCreate
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\Samples\wishList";
            Console.WriteLine("Enter file name:");
            string fileName = Console.ReadLine();
            string fullFilePath = $@"{rootDirectory}\{fileName}.txt";

            bool directoryExists = Directory.Exists(rootDirectory);
            bool fileExists = File.Exists(fullFilePath);

            if(directoryExists && fileExists)
            {
                Console.WriteLine($"File {fileName} already exists in {rootDirectory}.");
            }
            else if (!directoryExists)
            {
                Console.WriteLine($"wishList directory does not exist.");
                Directory.CreateDirectory(rootDirectory);
                File.Create(fullFilePath);
            }
            else
            {
                File.Create(fullFilePath);
                Console.WriteLine($"File {fileName}.txt has been created.");
            }
            
        }
    }
}
