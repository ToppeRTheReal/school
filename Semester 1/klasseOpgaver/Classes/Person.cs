using System;

namespace klasseOpgaver.Classes {
    public class Person {

        public Person(int personID) {
            id = personID; // Normally generated ids will differ
        }

        public int? id { get; set; }
        public string Name { get; set; }


    }
}