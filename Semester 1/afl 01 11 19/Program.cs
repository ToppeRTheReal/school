using System;
using afl_01_11_19.Classes;

namespace afl_01_11_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating new customer");
            Kunde k = new Kunde(); // Id skulle blive konstrueret her
            Console.Write("Dit navn> ");
            k.Name = Console.ReadLine();
            Console.Write("Adresse> ");
            k.Adresse = Console.ReadLine();
            Console.Write("Telefon nummer> ");
            k.Tlf = Console.ReadLine();

            Console.WriteLine("Kunde instance sat");

            Console.WriteLine("-----------------------------");
            Console.WriteLine("{");
            Console.WriteLine("            id: " + k.getID());
            Console.WriteLine("          Navn: " + k.Name);
            Console.WriteLine("       Adresse: " + k.Adresse);
            Console.WriteLine("       Telefon: " + k.Tlf);
            Console.WriteLine("}");
        }
    }
}
