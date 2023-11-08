namespace kjwProgram
{


    internal class Program
    {
        static void Main(string[] args)
        {
            #region 자료형

            //byte stream = 1;
            //bool boolean = false;
            //char character = 'A';
            //short data = 200;
            //int integer = 100;
            //long longData = 300;

            //float[] buffer = new float[3];

            //buffer[0] = 1.15f;
            //buffer[1] = 2.15f;
            //buffer[2] = 3.15f;

            //double pi = 3.14;
            //decimal decimalData = 0.1m;

            //Console.WriteLine("stream : " + stream);
            //Console.WriteLine("boolean : " + boolean);

            #endregion

            #region 박싱(BOXING)

            // 값 형식의 데이터를 참조 형식으로 변환하는 과정.
            //int data = 5;

            //object obj = data;

            //Console.WriteLine(obj);
            //Console.WriteLine(data);

            #endregion

            #region 언박싱(UnBoxing)

            // 참조 타입의 데이터를 값 타입으로 변환하는 과정.

            int count = 10;
            object obj1 = count;
            int result = (int)obj1;

            Console.WriteLine(result);



            #endregion
        }
    }
}