namespace kjwProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 숙제 등차수열

            int N = 6;
            int A = 1;
            int B = 10;

            for(int i = 0; i < B; i++)
            {
                A += N;
                Console.WriteLine(A);
            }

        }
    }
}