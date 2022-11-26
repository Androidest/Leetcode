public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        int mStart = 0;
        int nStart = 0;
        int mEnd = matrix.Length - 1;
        int nEnd = matrix[0].Length - 1;

        int i = mStart;
        int j = nStart;
        int i_dir = 0;
        int j_dir = 1;

        List<int> result = new List<int>();
        while (mStart <= mEnd && nStart <= nEnd)
        {
            // right -> down
            if (j_dir == 1 && j == nEnd)
            {
                ++mStart;
                i_dir = 1;
                j_dir = 0;
            }
            // down -> left
            else if (i_dir == 1 && i == mEnd)
            {
                --nEnd;
                j_dir = -1;
                i_dir = 0;
            }
            // left -> up
            else if (j_dir == -1 && j == nStart)
            {
                --mEnd;
                i_dir = -1;
                j_dir = 0;
            }
            // up -> right
            else if (i_dir == -1 && i == mStart)
            {
                ++nStart;
                j_dir = 1;
                i_dir = 0;
            }

            result.Add(matrix[i][j]);
            i += i_dir;
            j += j_dir;
        }
        return result;
    }
}