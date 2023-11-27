namespace kjwProgram
{
    internal class Program
    {
        static void MergeSort1(int[] array, int left, int right)
        {
            if(left < right)
            {
                int mid = (left + right) / 2;
                MergeSort1 (array, left, mid);
                MergeSort1(array, mid + 1, right);
                MergeSort2(array, left, mid, right);
            }
        }

        static void MergeSort2(int[] array, int left, int mid, int right)
        {
            int[] a = new int[8];
            int l, m, k;
            l = left;
            m = mid + 1;
            k = left;
            
            while(l <= mid && m <=right)
            {
                if (array[l] <= array[m])
                {
                    a[k] = array[l];
                    l++;
                }
                else
                {
                    a[k] = array[m];
                    m++;
                }
                k++;
            }
            if (l > mid)
            {
                for(int t = m; t <= right; t++)
                {
                    a[k] = array[t];
                    k++;
                }
            }
            else
            {
                for(int t = l; t <= mid; t++)
                {
                    a[k] = array[t];
                    k++;
                }
            }
            for(int t = left; t <= right; t++)
            {
                array[t] = a[t];
            }
        }

        static void Main(string[] args)
        {
            #region 병합 정렬

            // 하나의 리스트를 두 개의 균등한 크기로 분할하고 분할된 부분 리스트를 정렬한 다음,
            // 두 개의 정렬된 부분 리스트를 합하여 전체가 정렬된 리스트가 되게 하는 방법.

            // 분할 : 입력 배열을 같은 크기의 2개의 부분 배열로 분할.
            // 정복 : 부분 배열을 정렬하며 부분 배열의 크기가 충분히 작지 않으면 
            //        순환 호출을 이용하여 다시 분할 정복 실행.
            // 결합 : 정렬된 부분 배열들을 하나의 배열에 병합.
            int[] array = new int[8] { 10, 25, 37, 8, 3, 12, 41, 9 };
            
            MergeSort1(array, 0, array.Length - 1);
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }





            #endregion


        }
    }
}