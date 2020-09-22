using System;
namespace Fatbøde
{
    public class Person
    {
        public Person(string _plate)
        {
            this.ID = Guid.NewGuid();
            this.plate = _plate;
        }

        public Guid ID { get; private set; }
        public string plate { get; private set; }
        public int klip { get; private set; }

        public void TilføjKlip(int n)
        {
            klip = klip + n;
        }
    }

    public static class FartMåler
    {
        public static int BeregnKlip(int speed)
        {
            if (speed < 0)
                throw new Exception("Ulovlig fart");

            int klip = (speed - 50) / 5;

            if (klip < 0)
                return 0;

            return klip;
        }
    }
}
