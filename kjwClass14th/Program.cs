﻿namespace kjwClass14th
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

            // 그래프에서 어느 노드들이 간선으로 연결되어 있는지를 나태내는 행렬이며,
            // 2차원 배열로 구현되어 있고 노드 사이에 간선이 있다면 1, 없ㄷ면 0으로 표현.

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

            // 각 노드에 연결된 노드들을 원소로 갖는 리스트들의 배열을 의미하며,
            // 인접 리스트가 있다면 [i]는 i 번째 노드에 연결된 노드들을 원소로
            // 가지는 리스트.

            //AdjacencyList<char> adjacency = new AdjacencyList<char>(5);
            //
            //adjacency.InsertEdge(0, 'A');
            //adjacency.InsertEdge(0, 'B');
            //adjacency.InsertEdge(1, 'C');
            //adjacency.InsertEdge(1, 'D');
            //adjacency.InsertEdge(2, 'E');
            //adjacency.InsertEdge(2, 'F');
            //
            //adjacency.Display();

            #endregion


        }
    }
}
