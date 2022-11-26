public class Solution {
    int[,] Memo;
    int M;
    int N;
    public int UniquePaths(int m, int n) {
        Memo = new int[m, n];
        for (int i = 0; i < m; ++i)
            for (int j = 0; j < n; ++j)
                Memo[i, j] = -1;
        M = m - 1;
        N = n - 1;
        return GetPathsRecursively(0, 0);
    }
    
    int GetPathsRecursively(int i, int j)
    {
        if (i > M || j > N) 
            return 0;
        if (i == M && j == N)
            return 1;

        if (Memo[i, j] != -1)
            return Memo[i, j];
        Memo[i, j] = GetPathsRecursively(i+1, j) + 
                     GetPathsRecursively(i, j+1);
        return Memo[i, j];
    }
}