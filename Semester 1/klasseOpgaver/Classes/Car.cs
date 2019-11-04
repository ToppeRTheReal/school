using System;

namespace klasseOpgaver.Classes {
    public class Car {

        public Car(string regNr) {
            this.regNr = regNr;

            this.owner = new Person(26);
        }

        private string _regNr;

        public string regNr {
            get => _regNr;
            set {
                this._regNr = value;
            }

        }

        public virtual double Weigth { get; set; }
        public Person owner { get; private set; }

        // This method is useless due to the property restrictions
        public string GetRegNr() {
            return this.regNr;
        }

        public Person GetOwner(){
            return this.owner;
        }

        public void SetPersonProps(Person p) {
            if(p.id != null)
                Console.WriteLine("Cannot change person id");
            owner.Name = p.Name;
        }
    }
}