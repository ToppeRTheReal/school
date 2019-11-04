using System;
using Mogens.Opgs;

namespace Mogens
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            AsciiArt.print();

            Console.Write("Do you wish to run Opg 7? (Y/N) ");
            string ans = Console.ReadLine().ToUpper();
            if(ans == "Y") {
                Opg7.RunMain();
            }
        }
    }
}
