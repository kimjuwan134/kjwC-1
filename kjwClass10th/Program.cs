namespace kjwClass10th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 등차 수열

            // 숙제 등차수열
            /*
            int N = 13;
            int A = 5;
            int B = 10;

            for(int i = 0; i < B; i++)
            {
                A += N;
                Console.WriteLine(A);
            }
            */

            // 숙제 등차수열 풀이

            //int firstTerm = 0; // 첫 항
            //int commonDifferent = 0; // 공차
            //int size = 0;

            // Console.ReadLine() : string 타입으로만 값을 반환.
            //string name = Console.ReadLine();

            // Int32.Parse : int 타입으로 값을 반환.
            //Console.Write("첫 항의 값 입력 : ");
            //firstTerm = Int32.Parse(Console.ReadLine());

            //Console.WriteLine("");

            //Console.Write("공차의 값 입력 : ");
            //commonDifferent = Int32.Parse(Console.ReadLine());

            //Console.WriteLine("");

            //Console.Write("n의 값 입력 : ");
            //size = Int32.Parse(Console.ReadLine());


            //Console.WriteLine("firstTerm 변수의 값 : " + firstTerm);
            //Console.WriteLine("commonDifferent 변수의 값 : " + commonDifferent);
            //Console.WriteLine("size 변수의 값 : " + size);

            ////Console.WriteLine("name의 변수의 값 : " + name);

            //for (int i = 0; i < size; i++)
            //{
            //    Console.WriteLine(firstTerm + commonDifferent * i);
            //}

            #endregion

            #region 등비 수열

            //int first;
            //int different;
            //int size;

            //Console.Write("첫 항의 값 : ");
            //first = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("");
            //Console.Write("공비의 값 : ");
            //different = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("");
            //Console.Write("n의 값 : ");
            //size = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("");

            //for(int i = 1; i <= size; i++)
            //{
            //    Console.WriteLine(first);
            //    first *= different;
            //}

            #endregion

            #region 무명 형식

            // 이름이 존재하지 않는 객체 또는 변수를 의미.

            // 무명 형식의 경우 값을 읽기만 할 수 있음.
            //var data = new { Name = "Data", Value = 10 };

            //Console.WriteLine("data.Name : " + data.Name + " data.Value : " + data.Value);

            #endregion
        }
    }
}
