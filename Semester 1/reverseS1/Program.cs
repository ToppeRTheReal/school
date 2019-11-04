using System;

namespace reverseS1
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Kunde k = new Kunde("Benny", 10000);
                Console.WriteLine(k.name);
            }catch (LengthException e) {
                Console.WriteLine(e.ToString());
            }catch (KreditException e) {
                Console.WriteLine(e.ToString());
            }catch(Exception e) {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
