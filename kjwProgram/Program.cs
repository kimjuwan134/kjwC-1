namespace kjwProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 그래프

            // 정점(Vertex)과 간선(Edge)들이 서로 복잡하게 연결되어있는 자료구조.

            // 정점(Vertex)
            // 노드(node)라고도 하며, 데이터가 저장되는 그래프의 기본 원소.

            // 간선(Edge)
            // 링크(link)라고도 하며, 정점간의 관계를 나타냄.

            // 인접 정점(Adjacent Vertex)
            // 하나의 정점에서 간선에 의해 직접 연결되어 있는 정점을 의미.

            // 차수(Degree)
            // 정점에 연결되어 있는 간선의 수를 의미.

            // 진입 차수
            // 외부에서 오는 간선의 수.

            // 진출 차수
            // 외부로 향하는 간선의 수.

            // 단순 경로(Simple Path)
            // 경로 중에서 반복되는 간선이 없는 경로를 의미.

            // 사이클(Cycle)
            // 시작 정점과 종료 정점이 같은, 단순 경로를 의미.





            #endregion

            #region 인접 행렬

            //AdjacencyMatrix<string> adjacencyMatrix = new AdjacencyMatrix<string>(4);

            //adjacencyMatrix.InsertVertex("A");
            //adjacencyMatrix.InsertVertex("B");
            //adjacencyMatrix.InsertVertex("C");
            //adjacencyMatrix.InsertVertex("D");

            //adjacencyMatrix.InsertEdge(0, 1);
            //adjacencyMatrix.InsertEdge(0, 2);
            //adjacencyMatrix.InsertEdge(0, 3);
            //adjacencyMatrix.InsertEdge(1, 2);
            //adjacencyMatrix.InsertEdge(3, 2);

            //adjacencyMatrix.Display();

            #endregion

            #region 인접 리스트

            AdjacencyList<char> adjacency = new AdjacencyList<char>(5);

            adjacency.AddEdge('A');
            adjacency.AddEdge('B');
            adjacency.AddEdge('C');
            adjacency.AddEdge('D');
            adjacency.AddEdge('E');







            #endregion


        }
    }
}