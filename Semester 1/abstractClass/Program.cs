using System;
using System.Collections.Generic; // List
using abstractClass.Classes;

namespace abstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var Kunde = new Kunde();
            var p = new Person2();
            Console.WriteLine(Kunde.ID);
        }
    }
}
