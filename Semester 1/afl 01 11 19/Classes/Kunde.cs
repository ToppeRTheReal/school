using System;

namespace afl_01_11_19.Classes {
    public class Kunde {

        public Kunde() {
            // Kode til konstruering dvs finde et unikt bruger id
        }

        private int ID; // Ville foretrække at benytte property her til at sætte den til get og private set som kun sker i constructoren
        public string Name;
        public string Adresse;
        public string Tlf;


        public static int getID() {
            return ID;
        }

    }
}