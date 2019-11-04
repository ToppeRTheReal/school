using System; 

namespace reverseS1 {
    public class LengthException : Exception {
        public LengthException() {
            
        }

        public override string ToString() {
            return "Error: Name cannot be more than 20 characters";
        }
    }

    public class KreditException : Exception {
        public KreditException() {

        }

        public override string ToString() {
            return "Error: Kredit can max be a num of 10.000";
        } 
    }
}