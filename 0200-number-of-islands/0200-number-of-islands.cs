public class Solution {    
    int M;
    int N;
    char[][] Grid;
    Queue<(int, int)> PosQueue;
    
    public int NumIslands(char[][] grid) {
        M = grid.Length;
        N = grid[0].Length;
        int count = 0;
        Grid = grid;
        
        for (int i = 0; i < M; ++i)
        {
            for (int j = 0; j < N; ++j)
            {
                if (Grid[i][j] == '1')
                {
                    ++count;
                    InfectIsland_BFS(i, j);
                }
            }
        }
        return count;
    }
    
    void InfectIsland_BFS(int i, int j)
    {
        PosQueue = new Queue<(int, int)>();
        InfectValidIsland(i, j);
        while(PosQueue.Count > 0)
        {
            (i, j) = PosQueue.Dequeue();            
            InfectValidIsland(i+1, j);
            InfectValidIsland(i-1, j);
            InfectValidIsland(i, j+1);
            InfectValidIsland(i, j-1);
        }
    }
    
    void InfectValidIsland(int i, int j)
    {
        if (0 <= i && i < M && 0 <= j && j < N && Grid[i][j] == '1') 
        {
            Grid[i][j] = '0';
            PosQueue.Enqueue((i, j));
        }
    }
}