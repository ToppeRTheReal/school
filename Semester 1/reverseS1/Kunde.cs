using System;

namespace reverseS1 {
    public class Kunde : Person {
        public Kunde(string nameInput, int kreditInput):base(nameInput) {
            base.name = nameInput;
            Kredit = kreditInput;
        }

        private int kredit;

        public int Kredit {
            get => this.kredit;
            set {
                if(value > 10000) {
                    throw new KreditException();
                }else {
                    this.kredit = value;
                }
            }
        }
    }
}