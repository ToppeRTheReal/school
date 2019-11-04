using System;

namespace checkStringForWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program checks for the word \"Trump\"");
            Console.Write("Sentencte to check> ");
            string sen = Console.ReadLine();

            if(sen.Length < 5) {
                Console.WriteLine("Sentence provided wasn't long enough to contain \"Trump\"");
                return;
            }

            int occurences = 0;
            char[] chars = sen.ToUpper().ToCharArray();
            for(int i = 0; i < chars.Length; i++) {
                if(chars[i] == 'T' && chars[i + 1] == 'R' && chars[i + 2] == 'U' && chars[i + 3] == 'M' && chars[i + 4] == 'P') {
                    occurences++;
                }
            }
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Trump was mentioned {0} time(s)", occurences);

            //Second method
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Or easy method with string.Contains()");
            if(sen.ToUpper().Contains("TRUMP")) {
                Console.WriteLine("Sentence provided contains Trump");
            }else {
                Console.WriteLine("Sentence provided does not contain Trump");
            }
        }
    }
}
