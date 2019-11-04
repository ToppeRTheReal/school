using System;

namespace Mogens.Opgs {

    public class Opg7 {

        public static void RunMain() {
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
        public static void Run71() {
            Console.WriteLine("Running opg 7.1");
            int sqrtFound = 0;
            for(int i = 0; sqrtFound < 10; i++) {
                if(i % 4 == 0) {
                    sqrtFound++;
                    Console.WriteLine("{0} er et kvadrattal", i);
                }
            }
        }

        public static void Run72() {
            int sum = 0;
            double gnms = 0;
            for(int i = 0; i<=25; i++) {
                sum = sum + i;
                if(i == 25) {
                    gnms = (double) sum / ((double) i + 1.00);
                    Console.WriteLine("Sum = {0}", sum);
                    Console.WriteLine("Gnms = {0}", gnms);
                }
            }
        }

        public static void Run73() {
            Console.WriteLine("Alle lige tal mellem 0 og 25");
            Console.ReadKey();
            for(int i = 0; i <= 25; i++) {
                if(i % 2 == 0) {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("Alle ulige tal mellem 1 og 25");
            Console.ReadKey();
            for(int i = 1; i <= 25; i++) {
                if(i % 2 != 0) {
                    Console.WriteLine(i);
                }
            }
        }

        public static void Run74() {
            for(int i = 302; i <= 398; i++) {
                char[] chars = i.ToString().ToCharArray();
                if(chars[0] != chars[1] && chars[0] != chars[2] && chars[1] != chars[2]) {
                    Console.WriteLine("No digit in {0} is the same", i);
                }
            }
        }

        public static void Run75() {
            int a = Convert.ToInt32('A');
            int z = Convert.ToInt32('Z');
            for(int i = a; i <= z; i++) {
                Console.WriteLine(Convert.ToChar(i) + " = " + i.ToString());
            }
        }

        public static void Run76() {
            Console.Write("Input det der skal laves om til tabel> ");
            string input = Console.ReadLine();
            char[] chars = input.ToCharArray();
            Console.WriteLine("-----");
            foreach(char c in chars) {
                Console.WriteLine("| " + c + " |");
                Console.WriteLine("-----");
            }
        }
    }
}