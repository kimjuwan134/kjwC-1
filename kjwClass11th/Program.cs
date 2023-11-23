namespace kjwClass11th
{
    internal class Program
    {
        static void BinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                // 1. 배열의 가운데 요소의 인덱스를 pivot으로 설정.
                int pivot = (left + right) / 2;

                // 2. [pivot]의 값이 찾고자 하는 요소와 같다면 검색 완료.
                if (array[pivot] == target)
                {
                    Console.WriteLine("array[pivot] : " + array[pivot]);
                    return;
                }

                // 3. [pivot]의 값이 찾는 값보다 크다면 left ~ pivot 사이를 검색.
                else if (array[pivot] > target)
                {
                    right = pivot - 1;
                }

                // 4. [pivot]의 값이 찾는 값보다 작다면 pivot ~ right 사이를 검색.
                else
                {
                    left = pivot + 1;
                }
            }
            Console.WriteLine("Not value Found");
        }

        static void Main(string[] args)
        {
            #region 이진 탐색

            // 오름차순으로 정렬된 리스트에 특정한 값의 위치를 찾는 알고리즘.

            //int[] array = new int[8] { 6,5,11,13,27,55,66,10};
            //Array.Sort(array); // 배열을 오름차순으로 정렬하는 함수.
            //BinarySearch(array, 3);

            #endregion


        }
    }
}
