namespace kjwClass15th
{
    internal class AdjacencyList<T>
    {
        // 그래프의 사이즈
        int size;
        // 그래프의 인접 리스트
        List<int>[] adjacencyList;

        bool[] visited;
        int visitedSize;

        public AdjacencyList(int vertexSize)
        {
            size = vertexSize;
            adjacencyList = new List<int>[vertexSize];
            for(int i = 0; i < vertexSize; i++)
            {
                adjacencyList[i] = new List<int>();
            }
            visited = new bool[vertexSize];
        }

        public void InsertEdge(int vertex, int edge)
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

        public void BFS(int root)
        {
            int index;
            Queue<int> queue = new Queue<int>();
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

        public void DFS(int root)
        {
            if (!visited[visitedSize] && root < adjacencyList.Length)
            {
                visited[visitedSize++] = true;
                Console.Write(root + " ");
                
                for(int i = 0; i < adjacencyList[root].Count; i++)
                {
                    DFS(adjacencyList[root][i]);
                }
            }
        }
        
    }
}