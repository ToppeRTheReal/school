using System;

namespace SortAlgoritmns {
    public static class CQuickSort {

        public static int Partition(int[] arr, int left, int right) {
            int pivot = arr[left];
            while (true) 
            {
                while (arr[left] < pivot) 
                    left++;

                while (arr[right] > pivot)
                    right--;

                if (left < right)
                {
                    if (arr[left] == arr[right]) 
                        return right;
                    
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
                else 
                    return right;
            }
        }
        public static void Quicksort(int[] arr, int left, int right) {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                    Quicksort(arr, left, pivot - 1);
                if (pivot + 1 < right)
                    Quicksort(arr, pivot + 1, right);
            }
        }
    }
}