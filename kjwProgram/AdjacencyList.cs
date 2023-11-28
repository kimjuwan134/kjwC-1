using System.ComponentModel;

namespace kjwProgram
{
    internal class AdjacencyList<T>
    {
        // 그래프의 노드
        // 그래프의 인접 리스트
        int size;
        int maxSize;
        List<T>[] adjacencyList;
        T vertex;


        public AdjacencyList(int maxSize)
        {
            this.maxSize = maxSize;
            adjacencyList = new List<T>[maxSize];
        }

        public void AddEdge(T data)
        {
            adjacencyList[size++].Add(data);
        }

        public void InsertEdge(int x, int y)
        {
            
        }


        
    }
}
