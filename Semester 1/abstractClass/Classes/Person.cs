using System;
using abstractClass.Generators;

namespace abstractClass.Classes {
    
    interface IPrintable {
        void Print();
    }
    public abstract class Person : IPrintable {
        public virtual string ID { get; set; }

        public abstract void ShowMyClass();
        public void Print() {
            Console.WriteLine("BRUH");
        }
    }

    public class Kunde : Person {
        public override void ShowMyClass(){

        }

        public Kunde() {
            this.ID = RandomClass.RandomString(5);
        }
    }

    public class Person2 : Person {
        public override void ShowMyClass() {

        }

        public string baseID() {
            return this.ID;
        }
    }
}