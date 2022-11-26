public class Solution {
    public int[] FindBall(int[][] grid) {
        int m = grid.Length;        
        int n = grid[0].Length;
        int[] result = new int[n];
        
        for (int c = 0; c < n; ++c)
        {
            int ballCol = c;
            for (int r = 0; r < m; ++r)
            {
                ballCol = GetNextCol(grid, r, ballCol, n);
                if (ballCol == -1)
                    break;
            }
            result[c] = ballCol;
        }
        return result;
    }
    
    int GetNextCol(int[][] grid, int row, int col, int cols)
    {
        int dir = grid[row][col];
        int nextCol = col + dir;
        if (nextCol < 0 || cols <= nextCol || dir != grid[row][nextCol])
            return -1;
        
        return nextCol;
    }
}