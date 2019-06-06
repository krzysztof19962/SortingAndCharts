using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortowanie_Projekt
{
    class RecursiveQuickSork
    {
       public class Example
        {
            public static void QuickSortRecursive( int[] data, int left, int right)
            {
                if (left < right)
                {
                    int q = Partition(data, left, right);
                    QuickSortRecursive( data, left, q - 1);
                    QuickSortRecursive( data, q + 1, right);
                }
            }

            private static int Partition(int[] data, int left, int right)
            {
                int pivot = data[right];
                int temp;
                int i = left;

                for (int j = left; j < right; ++j)
                {
                    if (data[j] <= pivot)
                    {
                        temp = data[j];
                        data[j] = data[i];
                        data[i] = temp;
                        i++;
                    }
                }

                data[right] = data[i];
                data[i] = pivot;

                return i;
            }

            /*static void Main(string[] args)
            {
                int[] arr = { 67, 12, 95, 56, 85, 1, 100, 23, 60, 9 };
                int n = 10, i;
              
                quickSort(arr, 0, 9);
                Console.Write("\nSorted Array is: ");
                for (i = 0; i < n; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }*/
        }
    }
}
