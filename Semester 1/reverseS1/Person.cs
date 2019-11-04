using System;
using System.Collections.Generic;

namespace reverseS1 {
    public class Person {
        public Person(string _name) {
            this.name = _name;
        }

        private string Name; // Her en name
        public List<string> errors;

        public string name { // Getter og Setter
            get => this.Name;
            set {
                if(value.Length >= 20) {
                    throw new LengthException();
                }else {
                    this.Name = value;
                }
            }
        }
    }
}