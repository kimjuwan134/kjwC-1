namespace kjwProgram
{
    internal class AdjacencyList<T>
    {
        // 그래프의 사이즈
        int size;
        // 그래프의 인접 리스트
        List<T>[] adjacencyList;

        bool[] visited;
        int visitedSize;

        public AdjacencyList(int vertexSize)
        {
            size = vertexSize;
            adjacencyList = new List<T>[vertexSize];
            for(int i = 0; i < vertexSize; i++)
            {
                adjacencyList[i] = new List<T>();
            }
            visited = new bool[vertexSize];
        }

        public void InsertEdge(int vertex, T edge)
        {
            adjacencyList[vertex].Add(edge);
        }

        public void Display()
        {
            for(int i = 0; i < size; i++)
            {
                Console.Write("adjacencyList[" + i + "] : ");
                for (int j = 0; j < adjacencyList[i].Count; j++)
                {
                    Console.Write(adjacencyList[i][j] + " ");
                }
                Console.WriteLine("");
            }
        }

        public void BFS(T root)
        {
            T index;
            Queue<T> queue = new Queue<T>();
            queue.Enqueue(root);
            index = queue.Dequeue();
            Console.Write(index + " ");
            visited[visitedSize++] = true;

            for (int i = 0; i < adjacencyList.Length; i++)
            {
                for (int j = 0; j < adjacencyList[i].Count; j++)
                {
                    if (visited[visitedSize] == false)
                    {
                        queue.Enqueue(adjacencyList[i][j]);
                        visited[visitedSize++] = true;
                        index = queue.Dequeue();
                        Console.Write(index + " ");
                    }
                }
            }
        }
        
    }
}
