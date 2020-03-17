using System;

namespace SortAlgoritmns {
    public class InsertionSortClass {
        public static void InsertionSort(int[] values) {
            
            // loop over data.Length - 1 elements                      
            for (var next = 1; next < values.Length; ++next) {
                
                // store value in current element                       
                var insert = values[next];

                // initialize location to place element                 
                var moveItem = next;

                // search for place to put current element              
                while (moveItem > 0 && values[moveItem - 1] > insert)
                {
                    // shift element right one slot                      
                    values[moveItem] = values[moveItem - 1];
                    moveItem--;
                }

                values[moveItem] = insert; // place inserted element    
                //PrintPass(values, next, moveItem); // output pass of algorithm
            }
        }

        // display a pass of the algorithm
        public static void PrintPass(int[] values, int pass, int index) {
            Console.Write($"after pass {pass}: ");

            // output elements till swapped item
            for (var i = 0; i < index; ++i)
            {
                Console.Write($"{values[i]}  ");
            }

            Console.Write($"{values[index]}* "); // indicate swap

            // finish outputting array
            for (var i = index + 1; i < values.Length; ++i)
            {
                Console.Write($"{values[i]}  ");
            }

            Console.Write("\n              "); // for alignment

            // indicate amount of array that is sorted
            for (var i = 0; i <= pass; ++i)
            {
                Console.Write("--  ");
            }

            Console.WriteLine("\n"); // skip a line in output
        }
    }
}