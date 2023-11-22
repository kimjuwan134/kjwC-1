using System;
using System.Security.Cryptography.X509Certificates;

namespace kjwProgram
{
    internal class Program
    {
        public void BinarySearch(int[] a, int b)
        {
            int pivot = a.Length / 2;
            int left = 0;
            int right = a.Length - 1;
            
            while(true)
            {
                if(a[pivot] == b)
                {
                    Console.WriteLine("자료 발견 : " + b);
                }
                else if (b < a[pivot])
                {
                    right = pivot;
                    pivot = (left + right) / 2;
                }
                else if (b > a[pivot])
                {
                    left = pivot;
                    pivot = (left + right) / 2;
                }
                else if()
            }
        }

        static void Main(string[] args)
        {
            #region 이진 탐색

            // 오름차순으로 정렬된 리스트에 특정한 값의 위치를 찾는 알고리즘.

            // 1. 배열의 가운데 요소의 인덱스를 pivot으로 설정.

            // 2. [pivot]의 값이 찾고자 하는 요소와 같다면 검색 완료.

            // 3. [pivot]의 값이 찾는 값보다 크다면 left ~ pivot 사이를 검색.

            // 4. [pivot]의 값이 찾는 값보다 작다면 pivot ~ right 사이를 검색.

            int[] array = new int[6] { 1, 6, 8, 13, 15, 20 };

            

            
            


            


            #endregion


        }
    }
}