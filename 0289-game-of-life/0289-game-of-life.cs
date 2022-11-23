public class Solution {
    public void GameOfLife(int[][] board) {
        int m = board.Length;
        int n = board[0].Length;
        var padded = padOne(board);
        for (int i = 1; i <= m; ++i)
        {
            for (int j = 1; j <= n; ++j)
            {
                board[i-1][j-1] = GetNeighbours(padded, i, j);
            }
        }
        for (int i = 0; i < m; ++i)
        {
            for (int j = 0; j < n; ++j)
            {
                var count = board[i][j];
                if (count == 2)
                    board[i][j] = padded[i+1, j+1];
                if (count == 3)
                    board[i][j] = 1;
                else if (count > 3 || count < 2)
                    board[i][j] = 0;
            }
        }
    }

    public int[,] padOne(int[][] board)
    {
        int m = board.Length;
        int n = board[0].Length;
        int[,] padded = new int[m+2, n+2];

        for (int i = 1; i <= m; ++i)
        {
            for (int j = 1; j <= n; ++j)
            {
                padded[i,j] = board[i-1][j-1];
            }
        }
        return padded;
    }

    public int GetNeighbours(int[,] b, int i, int j)
    {
        return b[i-1,j-1] + b[i,j-1] + b[i+1,j-1] +
               b[i-1,j  ] +          + b[i+1,j  ] +
               b[i-1,j+1] + b[i,j+1] + b[i+1,j+1];
    }
}