public class Solution {
    int M;    
    int N;
    int[,,] Memo;
    const long MOD = 1000000007;
    
    public int FindPaths(int m, int n, int maxMove, int startRow, int startColumn) {
        M = m;
        N = n;
        Memo = new int[m, n, maxMove];
        for (int i = 0; i < m; ++i)
        {
            for (int j = 0; j < n; ++j)
            {
                for (int k = 0; k < maxMove; ++k)
                {
                    Memo[i, j, k] = -1;
                }
            }
        }
        
        
        return GetPathsRecursively(startRow, startColumn, maxMove);
    }
    
    public int GetPathsRecursively(int r, int c, int stepLeft)
    {
        if (r < 0 || M == r || c < 0 || N == c)
            return 1;
        if (stepLeft == 0)
            return 0;
        
        --stepLeft;
        if (Memo[r, c, stepLeft] != -1)
            return Memo[r, c, stepLeft];
        long result = (long) GetPathsRecursively(r+1, c, stepLeft) +   
                    GetPathsRecursively(r-1, c, stepLeft) +
                    GetPathsRecursively(r, c+1, stepLeft) +
                    GetPathsRecursively(r, c-1, stepLeft);
        Memo[r, c, stepLeft] = (int)(result % MOD);
        return Memo[r, c, stepLeft];
    }
}