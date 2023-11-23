using System;
using System.Security.Cryptography.X509Certificates;

namespace kjwProgram
{
    internal class Program
    {
        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        static void QuickSort(int[] array, int left, int right)
        {
            // 1. left가 right 보다 크거나 같아졌을 때
            if(left >= right)
            {
                return;
            }

            int pivot = array[left - 1];

            while (left <= right)
            {
                if (pivot > array[left])
                {
                    left++;
                }
                
                if(pivot < array[right])
                {
                    right--;
                }
            }
            Swap(ref pivot, ref right);
            QuickSort(array, pivot + 1, right - 1);
            QuickSort(array, right + 1, array.Length - 1);
        }

        static void Main(string[] args)
        {
            #region 퀵 정렬

            // 기준점을 획득한 다음 해당 기준점을 기준으로 배열을 나누고 한쪽에는
            // 기준점보다 작은 항목들이 위치하고 다른 쪽에는 기준점보다 큰 항목들이 위치.

            // 나뉘어진 하위 배열에 대해 재귀적으로 퀵 정렬을 호출하여 모든 배열이
            // 기본 배열이 될 때까지 반복하면서 정렬하는 알고리즘.

            // 시간복잡도 : O(log N)

            int[] array = new int[9] { 5, 8, 3, 2, 1, 9, 4, 7, 6 };

            QuickSort(array, 1, array.Length - 1);



            #endregion


        }
    }
}