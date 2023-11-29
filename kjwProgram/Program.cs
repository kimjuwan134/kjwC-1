namespace kjwProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region BFS(너비 우선 탐색)

            // Queue에 root 노드 넣기.

            // visited 방문 체크.

            // 반복문이 돌아가는 위치.
            // 1. Queue가 비어있을 때까지 반복.

            // 2. Queue에서 데이터를 뽑습니다.

            // 3. Queue에서 뽑은 데이터 출력.

            // 4. 반복문을 이용해서 자기와 인접한 노드를 Queue에 넣기.

            // 5. 방문하지 않은 정점이라면 해당 vertex 방문 체크하고 Queue 데이터 삽입.

            AdjacencyList<int> adjacency = new AdjacencyList<int>(7);
            adjacency.InsertEdge(0, 1);
            adjacency.InsertEdge(0, 2);
            adjacency.InsertEdge(1, 3);
            adjacency.InsertEdge(1, 4);
            adjacency.InsertEdge(2, 5);
            adjacency.InsertEdge(2, 6);

            adjacency.BFS(0);

            #endregion



        }
    }
}