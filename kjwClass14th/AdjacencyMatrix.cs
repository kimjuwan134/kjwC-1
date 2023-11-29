namespace kjwClass14th
{
    internal class AdjacencyMatrix<T>
    {
        int size;
        int maxSize;
        T[] vertex;
        int[,] array;

        public AdjacencyMatrix(int maxSize)
        {
            this.maxSize = maxSize;
            vertex = new T[maxSize];
            array = new int[maxSize, maxSize];
        }

        public void InsertEdge(int x, int y)
        {
            array[y, x] = 1;
            array[x, y] = 1;
        }

        public void InsertVertex(T data)
        {
            vertex[size++] = data;
        }

        public void Display()
        {
            for(int i = 0; i < maxSize; i++)
            {
                for(int j = 0; j < maxSize; j++)
                {
                    Console.Write(array[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine("");
            }
        }
    }
}
