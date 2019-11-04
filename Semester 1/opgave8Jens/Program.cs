using System;
using System.IO;

namespace opgave8Jens
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The converted file will be located in the root folder of this app");
            Console.Write("filepath+name and extension> ");
            string filepath = Console.ReadLine();

            string file = File.ReadAllText(filepath);

            if(File.Exists("CONV.txt")) {
                Console.WriteLine("CONV.txt already exists");
                Console.Write("Do you wish to remove the current one (Y/N) ");
                string ans = Console.ReadLine().ToUpper();
                if(ans == "Y") {
                    File.Delete("CONV.txt");
                }else {
                    Console.WriteLine("Stopping the converter");
                    return;
                }
            }

            string[] lines = file.Split(" ");
            Console.Write("Which word do you wanna check for? > ");
            string checkFor = Console.ReadLine().ToUpper();

            int i = 0;
            foreach(string line in lines) {
                Console.WriteLine(line.ToUpper());
                if(line.ToUpper().Contains(checkFor)) {
                    i++;
                }
            }
            Console.WriteLine("{0} was found {1} time(s)", checkFor, i);
            Console.WriteLine("Hit any key to continue");
            Console.ReadKey();

            Console.WriteLine("Which case do you want enter either");
            Console.Write("upper, lower or none> ");
            string caseType = Console.ReadLine().ToUpper();

            FileStream fs = File.Create("CONV.txt");
            using(StreamWriter sw = new StreamWriter(fs)) {
                foreach(string line in lines) {
                    if(caseType == "UPPER"){
                        sw.WriteLine(line.ToUpper());
                    }else if (caseType == "LOWER") {
                        sw.WriteLine(line.ToLower());
                    }else {
                        sw.WriteLine(line);
                    }
                }
            }
            fs.Close();

        }
    }
}
