using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortowanie_Projekt
{
    class HeapSort
    {

        public static void heapSorting(int[] arr, int n)
        {
            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(arr, n, i);
            for (int i = n - 1; i >= 0; i--)
            {
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;
                heapify(arr, i, 0);
            }
        }
        public static void heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < n && arr[left] > arr[largest])
                largest = left;
            if (right < n && arr[right] > arr[largest])
                largest = right;
            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;
                heapify(arr, n, largest);
            }
        }



        public static void shortheapSorting(short[] arr, int n)
        {
            for (int i = n / 2 - 1; i >= 0; i--)
                shortheapify(arr, n, i);
            for (int i = n - 1; i >= 0; i--)
            {
                short temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;
                shortheapify(arr, i, 0);
            }
        }
        public static void shortheapify(short[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < n && arr[left] > arr[largest])
                largest = left;
            if (right < n && arr[right] > arr[largest])
                largest = right;
            if (largest != i)
            {
                short swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;
                shortheapify(arr, n, largest);
            }
        }


        public static void floatheapSorting(float[] arr, int n)
        {
            for (int i = n / 2 - 1; i >= 0; i--)
                floatheapify(arr, n, i);
            for (int i = n - 1; i >= 0; i--)
            {
                float temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;
                floatheapify(arr, i, 0);
            }
        }
        public static void floatheapify(float[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < n && arr[left] > arr[largest])
                largest = left;
            if (right < n && arr[right] > arr[largest])
                largest = right;
            if (largest != i)
            {
                float swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;
                floatheapify(arr, n, largest);
            }
        }
        /*public static void Main()
        {
            int[] arr = { 55, 25, 89, 34, 12, 19, 78, 95, 1, 100 };
            int n = 10, i;
         
            heapSort(arr, 10);
            Console.Write("\nSorted Array is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }*/


    }
}
