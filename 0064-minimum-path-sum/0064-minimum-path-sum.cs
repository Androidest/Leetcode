public class Solution {
    int[,] Memo;
    int[][] Grid;
    int M;
    int N;
    public int MinPathSum(int[][] grid) {
        Grid = grid;
        int m = grid.Length;
        int n = grid[0].Length;
        Memo = new int[m, n];
        for (int i=0; i<m; ++i)
            for (int j=0; j<n; ++j)
                Memo[i, j] = -1;
        M = m - 1;
        N = n - 1;
        return GetMinSumRecursively(0, 0);
    }
    
    public int GetMinSumRecursively(int i, int j)
    {
        if (i == M && j == N)
            return Grid[i][j];
        
        if (i > M || j > N)
            return Int32.MaxValue;

        if (Memo[i, j] != -1)
            return Memo[i, j];
        var min = Math.Min(GetMinSumRecursively(i+1, j), GetMinSumRecursively(i, j+1));
        Memo[i, j] = Grid[i][j] + min;
        return Memo[i, j];
    }
}