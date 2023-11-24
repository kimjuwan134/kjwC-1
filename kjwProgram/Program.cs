namespace kjwProgram
{
    public class A
    {
        public readonly int size5 = 8;
    }
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
            int l, m, r;
            l = left;
            m = mid + 1;
            r = right;
            int 
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
            A a = new A();
            int[] array = new int[A.] { 10, 25, 37, 8, 3, 12, 41, 9 };
            





            #endregion


        }
    }
}