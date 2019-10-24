using System;
using System.IO;
using System.Collections.Generic;

namespace objectToFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true) {
                Console.WriteLine("Please choose an aaction by entering the number of the action");
                Console.WriteLine(" ");
                Console.WriteLine("1 - Object to binary");
                Console.WriteLine("2 - Read file from last instance");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.Write("Action> ");
                string action = Console.ReadLine();

                if(action == "1")
                    Write();
                if(action == "2")
                    Read();
            }   
        }

        public static void Write() {
            Console.WriteLine("This program will create a new binaray file");
            Console.WriteLine("Hit any key when you're ready");
            Console.ReadKey();

            Person person = new Person();
            Console.WriteLine("Person instance created");

            Console.WriteLine("-------------------------------------------------");
            Console.Write("What is your name> ");
            person.Name = Console.ReadLine().ToString();
            Console.Write("How old are you (as number only)> ");
            person.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Trying to write object to binary file");

            bool append = false;

            if (File.Exists("file.bin")) {
                Console.WriteLine("file.bin already exists");
                Console.Write("Do you want yo delete it (Y/N)");
                string ans = Console.ReadLine().ToUpper();
                if(ans == "Y")
                    File.Delete("file.bin");
                if (ans == "N")
                    append = true;
            }

            FileStream fs;
            if (!append)
                fs = File.Create("file.bin");
            else
                fs = File.Open("file.bin", FileMode.Append);

            var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            binaryFormatter.Serialize(fs, person);

            fs.Close();
            Console.WriteLine("File has been created and object was written");
        }

        public static void Read() {
            Console.WriteLine("Reading file.bin");
            FileStream fs = File.Open("file.bin", FileMode.Open);

            var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            bool dataIsNotNull = true;
            List<Person> DataFromFile = new List<Person>();
            while (dataIsNotNull)
            {
                try
                {
                    Person personFromFile = (Person)binaryFormatter.Deserialize(fs);
                    DataFromFile.Add(personFromFile);
                    Console.WriteLine("Added object with name " + personFromFile.Name + " to list");
                }
                catch(Exception e)
                {
                    dataIsNotNull = false;
                    Console.WriteLine("End of file reached...");
                }

            }

            foreach(Person person in DataFromFile)
            {
                Console.WriteLine("{");
                Console.WriteLine("   Name: " + person.Name);
                Console.WriteLine("   Age: " + person.Age);
                Console.WriteLine("}");

            }

            fs.Close();
        }
    }

    [Serializable]
    public class Person {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
