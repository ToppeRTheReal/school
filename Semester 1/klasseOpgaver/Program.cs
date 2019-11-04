using System;
using klasseOpgaver.Classes;

namespace klasseOpgaver
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car("2315");

            c.regNr = "287589";
            Console.WriteLine(c.GetRegNr());
        }
    }
}
