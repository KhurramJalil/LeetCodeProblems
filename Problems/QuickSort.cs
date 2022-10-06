using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems
{
    internal class QuickSort
    {
        public static void SolveIt(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);
                
                SolveIt(arr, left, pivot-1);
                SolveIt(arr, pivot+1, right);
            }
        }

        static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int i = left - 1;
            for(int j=left; j <= right-1; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    //swap arr[j] with arr[i]
                    int temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                }
            }

            //swap arr[right] with arr[i+1]
            arr[right] = arr[i + 1];
            arr[i + 1] = pivot;
            return i +1;
        }
    }
}
