using System;

namespace SortAlgoritmns { 
    public class SelectionSortClass {
        public static void SelectionSort(int[] values) {
      // loop over data.Length - 1 elements                         
        for (var i = 0; i < values.Length - 1; ++i) {
         var smallest = i; // first index of remaining array            

         // loop to find index of smallest element                  
         for (var index = i + 1; index < values.Length; ++index){
            if (values[index] < values[smallest])
               smallest = index;
         }

         Swap(ref values[i], ref values[smallest]); // swap elements
         //PrintPass(values, i + 1, smallest); // output pass of algorithm  
      }
    }

   // helper method to swap values in two elements                
        public static void Swap(ref int first, ref int second) {
            var temporary = first; // store first in temporary  
            first = second; // replace first with second
            second = temporary; // put temporary in second      
        }

        // display a pass of the algorithm
        public static void PrintPass(int[] values, int pass, int index) {
            Console.Write($"after pass {pass}: ");

            // output elements through the selected item
            for (var i = 0; i < index; ++i) {
                Console.Write($"{values[i]}  ");
            }

            Console.Write($"{values[index]}* "); // indicate swap

            // finish outputting array
            for (var i = index + 1; i < values.Length; ++i) {
                Console.Write($"{values[i]}  ");
            }

            Console.Write("\n              "); // for alignment

            // indicate amount of array that is sorted
            for (var j = 0; j < pass; ++j) {
                Console.Write("--  ");
            }

            Console.WriteLine("\n"); // skip a line in output
        }
    }
}