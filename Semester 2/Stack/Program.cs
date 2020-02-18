using System;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Check> ");
            string check = Console.ReadLine();
            Boolean addedOnce = false;

            Stack<char> s = new Stack<char>();

            foreach(char c in check) {
                if( c == '(' || c == '[' || c == '{'){
                    s.Push(')');
                    addedOnce = true;
                }
                else {
                    if(c == ')' || c == ']' || c == '}') {
                        if(!addedOnce){
                            Console.WriteLine("Error");
                            return;
                        }
                        try {
                            if( c != s.Pop()) {
                                Console.WriteLine("Error");
                                return;
                            }
                        }catch (InvalidOperationException) {
                            Console.WriteLine("Error");
                            return;
                        }
                    }
                }
            }
            if(s.Count > 0){
                Console.WriteLine("Error");
                return;
            }
            Console.WriteLine("Det er korrekt!");
        }
    }
}
 