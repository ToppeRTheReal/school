using System;
using System.IO;

namespace fileStream
{
    class Program
    {

        private static string filePath;

        static void Main(string[] args)
        {
            Console.Write("Filename.type> ");
            filePath = Console.ReadLine();
            if(filePath.Contains("C:") || filePath.Contains("/")) {
                Console.WriteLine("Only filenames are allowed!");
                Console.WriteLine("Shutting down ...");
                return;
            }
            if(!filePath.Contains('.')) {
                Console.WriteLine("No file extension where provided!");
                Console.WriteLine("Shutting down ...");
                return;
            }

            if(!File.Exists(filePath)) {
                Console.WriteLine("File does not exist!");
                Console.Write("Do you wish to create the file (Y/N) ");
                string filePrompt = Console.ReadLine();

                //Prompt actions depending on answer
                if(filePrompt.ToUpper() == "N") {
                    Console.WriteLine("File ignored and the program will therefore not be able to run :(");
                    Console.WriteLine("Shutting downn ...");
                    return;
                }else if(filePrompt.ToUpper() != "Y"){
                    Console.WriteLine("Key was neither y/n");
                    Console.WriteLine("Shutting down ...");
                    return;
                }

                FileStream file = File.Create(filePath);
                file.Close();
                Console.WriteLine("File created succesfuly!");
            }

            using(StreamWriter sw = new StreamWriter(filePath)) {
                bool active = true;
                string input = string.Empty;
                Console.WriteLine("exit() to stop");
                while(active) {
                    Console.Write("Line to file> ");
                    input = Console.ReadLine();
                    if(input == "exit()") {
                        active = false;
                        break;
                    }
                    sw.WriteLine(input);
                }
            }

            Console.WriteLine("In file -------------------------------------------");
            string fileContent = File.ReadAllText(filePath);
            Console.WriteLine(fileContent);
        }
    }
}
