public class Solution {
    public void SetZeroes(int[][] matrix) {
        int m = matrix.Length;
        int n = matrix[0].Length;
        bool[] r = new bool[m];
        bool[] c = new bool[n];

        for (int i = 0; i < m; ++i)
        {
            for (int j = 0; j < n; ++j)
            {
                if (matrix[i][j] == 0)
                {
                    r[i] = true;
                    c[j] = true;
                }
            }
        }

        for (int i = 0; i < m; ++i)
        {
            for (int j = 0; j < n; ++j)
            {
                if(r[i] || c[j])
                    matrix[i][j] = 0;
            }
        }
    }
}