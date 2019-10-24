using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

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
                Console.WriteLine("3 - Update stock in object");
                Console.WriteLine("4 - Delete file");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.Write("Action> ");
                string action = Console.ReadLine();

                if(action == "1")
                    Write();
                if(action == "2")
                    Read(null);
                if(action == "3")
                    UpdateStock();
                if(action == "4")
                    Delete();
            }   
        }

        public static void Write() {
            Console.Clear();
            Console.WriteLine("If the program crashes you made an error here!");
            Console.Write("Enter the path to the file (no extension)");
            string path = Console.ReadLine() + ".bin";

            Product prod = new Product();
            Console.WriteLine("Person instance created");

            Console.WriteLine("-------------------------------------------------");
            
            prod.Id = generateID();

            Console.Write("Name of product> ");
            prod.Name = Console.ReadLine().ToString();
            Console.Write("Description of product> ");
            prod.Description = Console.ReadLine();
            Console.Write("Price of product> ");
            try{
                prod.Price = int.Parse(Console.ReadLine());
            }catch {
                Console.WriteLine("Not a valid number, roloading");
                return;
            }
            Console.Write("How many is in stock> ");
            try{
                prod.InStock = int.Parse(Console.ReadLine());
            }catch {
                Console.WriteLine("Not a valid number, roloading");
                return;
            }

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Trying to write object to binary file");

            bool append = false;

            if (File.Exists(path)) {
                Console.WriteLine("file.bin already exists");
                Console.Write("Do you want yo delete it or append (D/A)");
                string ans = Console.ReadLine().ToUpper();
                if(ans == "D")
                    File.Delete(path);
                if (ans == "A")
                    append = true;
            }

            FileStream fs;
            if (!append)
                fs = File.Create(path);
            else
                fs = File.Open(path, FileMode.Append);

            var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            binaryFormatter.Serialize(fs, prod);

            fs.Close();
            Console.WriteLine("File has been created and object was written");
        }

        public static void Read(string path) {
            Console.Clear();
            if(path == null) {
                Console.WriteLine("If the program crashes you made an error here!");
                Console.Write("Enter the path to the file (no extension)");
                path = Console.ReadLine() + ".bin";
            }
            
            FileStream fs = File.Open(path, FileMode.Open);

            var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            bool dataIsNotNull = true;
            List<Product> DataFromFile = new List<Product>();
            while (dataIsNotNull)
            {
                try
                {
                    Product personFromFile = (Product) binaryFormatter.Deserialize(fs);
                    DataFromFile.Add(personFromFile);
                }
                catch(Exception e)
                {
                    dataIsNotNull = false;
                }

            }

            foreach(Product prod in DataFromFile)
            {
                Console.WriteLine("ID................" + prod.Id);
                Console.WriteLine("Name.............." + prod.Name);
                Console.WriteLine("Description......." + prod.Description);
                Console.WriteLine("Price............." + prod.Price);
                Console.WriteLine("InStock..........." + prod.InStock);

            }

            fs.Close();
        }

        public static void UpdateStock() {
            Console.Clear();
            Console.WriteLine("If the program crashes you made an error here!");
            Console.Write("Enter the path to the file (no extension)");
            string path = Console.ReadLine() + ".bin";

            Read(path);

            Console.Write("Id of the product you want to update> ");
            string id = Console.ReadLine();

            FileStream fs = File.Open(path, FileMode.Open);

            FileStream temp = File.Create("temp.bin");
            temp.Close();
            temp = File.Open("temp.bin", FileMode.Append);

            var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

            bool dataIsNotNull = true;
            while (dataIsNotNull)
            {
                try
                {
                    Product FromFile = (Product) binaryFormatter.Deserialize(fs);

                    if(FromFile.Id != id) {
                        Console.WriteLine("Not found with id");
                        binaryFormatter.Serialize(temp, FromFile);
                    }else {
                        Console.WriteLine("Found item with id");
                        Console.Write("New stock> ");
                        try{
                            FromFile.InStock = int.Parse(Console.ReadLine());
                            binaryFormatter.Serialize(temp, FromFile);
                            fs.Close();
                            temp.Close();
                            File.Delete(path);
                            File.Move("temp.bin", path);
                        }catch {
                            Console.WriteLine("Not a valid number :(");
                        }
                    }
                }
                catch(Exception e)
                {
                    dataIsNotNull = false;
                }

            }
        }

        public static void Delete() {
            Console.Clear();
            Console.WriteLine("If the program crashes you made an error here!");
            Console.Write("Enter the path to the file (no extension)");
            string path = Console.ReadLine() + ".bin";

            if(!Directory.Exists("Papirkurv"))
                Directory.CreateDirectory("Papirkurv");

            if(!File.Exists(path)){
                Console.WriteLine("file not found");
                return;
            }

            File.Move(path, "Papirkurv/" + path);
            Console.WriteLine("File moved to bin");
                
        }

        private static Random r = new Random();
        public static string generateID()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            return new string(Enumerable.Repeat(chars, 5)
                .Select(s => s[r.Next(s.Length)]).ToArray());

        }
    }

    [Serializable]
    public class Product {
        public string Id { get; set; }
        public string Name { get; set;}
        public string Description { get; set; }
        public int Price { get; set; }
        public int InStock { get; set; }
    }
}
