using System;
using System.Collections.Generic;
using System.IO;

namespace binFiler
{
    class Program
    {
        private const string path = @"file.bin";
        static void Main(string[] args)
        {
            if (!File.Exists(path))
            {
                var file = File.Create(path);
                file.Close();
            }else
            {
                // Reading the file

                FileStream fsReader = File.OpenRead(path);
                BinaryReader br = new BinaryReader(fsReader);

                bool readerActive = true;
                List<string> intsGottenAsStrings = new List<string>();
                while(readerActive)
                {
                    try
                    {
                        intsGottenAsStrings.Add(br.ReadInt32().ToString());
                    }catch
                    {
                        readerActive = false;
                    }
                
                }
                foreach (string s in intsGottenAsStrings)
                {
                    Console.WriteLine(s);
                }

                // File deletion and creation to reset
                fsReader.Close();
                File.Delete(path);
                var file = File.Create(path);
                file.Close();
            }

            Console.WriteLine("Hey lad os gemme et tal!");
            // Gathering userinput as data to save
            List<int> DataToWrite = new List<int>();
            while (true)
            {
                Console.Write("Skriv dit tal> ");
                string input = Console.ReadLine();
                if(input == "exit()")
                {
                    break;
                }
                try
                {
                    DataToWrite.Add(int.Parse(input));
                }catch
                {
                    Console.WriteLine("Hov, det var ikke et tal");
                }
            }
            
            if(!File.Exists(path)) {
                File.Create(path);
            }

            // Writing to file
            FileStream fs = File.OpenWrite(path);
            BinaryWriter bw = new BinaryWriter(fs);
            foreach(int item in DataToWrite)
            {
                bw.Write(item);
            }
            bw.Close();
        }
    }
}
