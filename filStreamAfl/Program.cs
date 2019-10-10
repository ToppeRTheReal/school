using System;
using System.IO;

namespace filStreamAfl
{
    class Program
    {
        static void Main(string[] args)
        {
            //init
            Console.WriteLine("Init phase started");

            if(!Directory.Exists("folder1")) {
                Console.WriteLine("Folder1 being created due to it not exisisting");
                Directory.CreateDirectory("folder1");
            }
            if(!Directory.Exists("folder2")){
                Console.WriteLine("Folder2 being created due to it not existing");
                Directory.CreateDirectory("folder2");
            }
            if(!Directory.Exists("backup")){
                Console.WriteLine("Backup folder being created due to it not existing");
                Directory.CreateDirectory("backup");
            }

            Console.WriteLine("Init phase done");

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("File wil be created inside folder1");
            Console.Write("filename, no extension> ");
            string fileName = Console.ReadLine();

            if(!File.Exists("folder1/" + fileName + ".txt")) {
                FileStream fileStream = File.Create("folder1/" + fileName + ".txt");
                fileStream.Close();
            }else {
                Console.WriteLine("File already exists, it will be used later");
            }

            Console.WriteLine("Move file to folder2");
            Console.WriteLine("Hit any key to continue...");
            Console.ReadKey();
            Console.Clear();

            // Creating backup of file in folder2 if it exists
            if(File.Exists("folder2/" + fileName + ".txt")) {
                Console.WriteLine("File already exists in folder2, creating backup of file");
                try {
                    File.Move("folder2/" + fileName + ".txt", "backup/" + fileName + ".txt");
                }catch {
                    Console.WriteLine("Stupid user! this file already has a backup");
                }
                Console.WriteLine("Backup created");
            }

            Console.WriteLine("Moving file...");
            File.Move("folder1/" + fileName + ".txt", "folder2/" + fileName + ".txt");
            Console.WriteLine("File moved to folder2");

        }
    }
}
