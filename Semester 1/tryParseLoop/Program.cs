using System;

namespace tryParseLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            bool active = true;
            while(active) {
                Console.Write("Enter number to TryPars> ");
                string numAsString = Console.ReadLine();
                int num = 0;
                if(int.TryParse(numAsString, out num)) {
                    active = false;
                    Console.WriteLine("Parsed {0} succesfuly", num);
                }else {
                    Console.WriteLine("Parsing failed");
                    Console.WriteLine("Try again");
                }

            }
        }
    }
}
