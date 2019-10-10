using System;

namespace opg7Mogens {
    public class AsciiArt {
        public static void print() {
            string title = @"
            ___________.__                                  
            \__    ___/|  |__   ____   _____  _____    ______
               |  |    |  |  \ / _  \ /     \ \__  \  /  ___/
               |  |    |  Y   ( <_>  )   Y Y \ / __ \_\___ \ 
               |__|    |__|  / \____/ |__|_|  (____  /____  >
                           \/               \/     \/     \/                                 
                                                                                ";
            Console.WriteLine(title);  
        }
    }
}