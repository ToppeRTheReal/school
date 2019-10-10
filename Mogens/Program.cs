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

            Console.WriteLine("Opgave 7.1: Udarbejd et C# program, der udskriver de ti første kvadrattal;");
            Console.Write("Do you wish to run opg 7.1? (Y/N) ");
            string ans = Console.ReadLine().ToUpper();
            if(ans == "Y") {
                Opg7.Run71();
                Console.WriteLine("Hit any key...");
                Console.ReadKey();
                Console.Clear();
                AsciiArt.print();
            }

            Console.WriteLine("Opgave 7.2: Udarbejd et C# program, der kan udskrive summen og gennemsnittet af tallene fra 0 til 25.");
            Console.Write("Do you wish to run opg 7.2? (Y/N) ");
            ans = Console.ReadLine().ToUpper();
            if(ans == "Y") {
                Opg7.Run72();
                Console.WriteLine("Hit any key...");
                Console.ReadKey();
                Console.Clear();
                AsciiArt.print();
            }

            Console.WriteLine("Opgave 7.3: Udarbejd et C# program, der udskriver alle lige tal mellem 1 og 25 og derefter alle ulige tal mellem 25 og 0");
            Console.Write("Do you wish to run opg 7.3? (Y/N) ");
            ans = Console.ReadLine().ToUpper();
            if(ans == "Y") {
                Opg7.Run73();
                Console.WriteLine("Hit any key...");
                Console.ReadKey();
                Console.Clear();
                AsciiArt.print();
            }

            Console.WriteLine("Opgave 7.4: Udarbejd et C# program, der udskriver alle tal mellem 302 og 398 hvor alle tre cifre i tallet er forskellige. F.ex er alle cifre forskellige i tallene 302 og 367 men ikke i 303 og 332. ");
            Console.Write("Do you wish to run opg 7.4? (Y/N) ");
            ans = Console.ReadLine().ToUpper();
            if(ans == "Y") {
                Opg7.Run74();
                Console.WriteLine("Hit any key...");
                Console.ReadKey();
                Console.Clear();
                AsciiArt.print();
            }

            Console.WriteLine("Opgave 7.5: Udarbejd et C# program, der udskriver alle unicodes  fra ’A’ til ’Z’. Er disse unicodes de samme som dem for ’a’ til ’z’ ? ");
            Console.Write("Do you wish to run opg 7.5? (Y/N) ");
            ans = Console.ReadLine().ToUpper();
            if(ans == "Y") {
                Opg7.Run75();   
                Console.WriteLine("Hit any key...");
                Console.ReadKey();
                Console.Clear();
                AsciiArt.print();
            }

            Console.WriteLine("Opgave 7.6: Udarbejd et C# program, der kan udskrive den lille tabel ved hjælp at to indlejrede (nestede) loops.");
            Console.Write("Do you wish to run opg 7.6? (Y/N) ");
            ans = Console.ReadLine().ToUpper();
            if(ans == "Y") {
                Opg7.Run76();
                Console.WriteLine("Hit any key...");
                Console.ReadKey();
                Console.Clear();
                AsciiArt.print();
            }

        }
    }
}
