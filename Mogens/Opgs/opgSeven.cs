using System;

namespace Mogens.Opgs {

    public class Opg7 {
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
                if(chars[0] != chars[1] && chars[0] != chars[2] && chars[1] == chars[2]) {
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