using System;
using System.Threading;
using System.Diagnostics;

namespace SortAlgoritmns
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 100000;
            Console.WriteLine("Hello World!");
            int[] a = new int[length];
            int[] b = new int[length];
            int[] c = new int[length];
            int[] d = new int[length];
            int[] e = new int[length];
            int[] f = new int[length];
            var rand = new Random();
            for (int i = 0; i < length; i++) { 
                a[i] = rand.Next(0, 50);
                b[i] = rand.Next(0, 50); 
                c[i] = rand.Next(0, 50); 
                d[i] = rand.Next(0, 50);
                e[i] = rand.Next(0, 50);
                f[i] = rand.Next(0, 50);
            }

            var stopwatch = new Stopwatch();

            //Removed print method with comment
            stopwatch.Start();
            InsertionSortClass.InsertionSort(a);
            stopwatch.Stop();
            
            Console.WriteLine("Insertion took: " + stopwatch.Elapsed.TotalMilliseconds.ToString("#,##0.00 'ms'"));

            stopwatch.Restart();
            //Removed print method with comment
            SelectionSortClass.SelectionSort(b);
            stopwatch.Stop();
            Console.WriteLine("Selection took: " + stopwatch.Elapsed.TotalMilliseconds.ToString("#,##0.00 'ms'"));

            stopwatch.Restart();
            BubbleSortClass.bubbleSort(c);
            stopwatch.Stop();
            //BubbleSortClass.printArray(c);

            Console.WriteLine("bubblesort took: " + stopwatch.Elapsed.TotalMilliseconds.ToString("#,##0.00 'ms'"));   
        
            stopwatch.Restart();
            Array.Sort(d); // Quicksort :)
            stopwatch.Stop();
            Console.WriteLine("C# implementation took: " + stopwatch.Elapsed.TotalMilliseconds.ToString("#,##0.00 'ms'"));
        
            stopwatch.Restart();
            MergeSortClass.MergeSort(e);
            stopwatch.Stop();
            Console.WriteLine("Merge took: " + stopwatch.Elapsed.TotalMilliseconds.ToString("#,##0.00 'ms'"));

            stopwatch.Restart();
            CQuickSort.Quicksort(e, 0, e.Length - 1);
            stopwatch.Stop();
            Console.WriteLine("Quicksort took: " + stopwatch.Elapsed.TotalMilliseconds.ToString("#,##0.00 'ms'"));
        }
    }
}
