namespace kjwProgram
{
    public delegate void Calculator(int x, int y);

    internal class Program
    {
        static void Add(int x, int y)
        {
            Console.WriteLine("x + y = " + (x + y));
        }

        static void Substract(int x, int y)
        {
            Console.WriteLine("x - y = " + (x - y));
        }

        static void Multiple(int x, int y)
        {
            Console.WriteLine("x * y = " + (x * y));
        }
        
        static void Divide(int x, int y)
        {
            Console.WriteLine("x / y = " + (x / y));
        }


        static void Main(string[] args)
        {
            Calculator calculator;

            calculator = Add;
            calculator(10, 20);

        }
    }
}