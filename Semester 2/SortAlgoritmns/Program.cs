using System;
using System.Threading;
using System.Diagnostics;

namespace SortAlgoritmns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] a = new int[10000];
            int[] b = new int[10000];
            int[] c = new int[10000];
            var rand = new Random();
            for (int i = 0; i < 10000; i++) { 
                a[i] = rand.Next(0, 50);
                b[i] = rand.Next(0, 50); 
                c[i] = rand.Next(0, 50); 
            }

            

            var stopwatch = new Stopwatch();

            Console.ForegroundColor = ConsoleColor.Green;
            stopwatch.Start();
            InsertionSortClass.InsertionSort(a);
            stopwatch.Stop();
            
            Console.WriteLine("Insertion took: " + stopwatch.Elapsed.TotalMilliseconds.ToString("#,##0.00 'millisekunder'"));

            stopwatch.Restart();
            SelectionSortClass.SelectionSort(b);
            stopwatch.Stop();
            Console.WriteLine("Selection took: " + stopwatch.Elapsed.TotalMilliseconds.ToString("#,##0.00 'millisekunder'"));

            stopwatch.Restart();
            BubbleSortClass.bubbleSort(c);
            stopwatch.Stop();
            //BubbleSortClass.printArray(c);

            Console.WriteLine("bubblesort took: " + stopwatch.Elapsed.TotalMilliseconds.ToString("#,##0.00 'millisekunder'"));   
        
        }
    }
}
