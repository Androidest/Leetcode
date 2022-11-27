public class Solution {
    int[][] Image;
    Queue<(int, int)> Queue;
    int M;
    int N;

    public int[][] FloodFill_2(int[][] image, int sr, int sc, int color) {
        Image = image;
        M = image.Length;
        N = image[0].Length;

        int target = Image[sr][sc];
        FillColorRecurcive(sr, sc, color, target);
        return image;
    }

    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        Queue = new Queue<(int, int)>();
        Image = image;
        M = image.Length;
        N = image[0].Length;

        int target = Image[sr][sc];
        FillColor(sr, sc, color, target);
        while(Queue.Count > 0)
        {
            (int i, int j) = Queue.Dequeue();
            FillColor(i+1, j, color, target);
            FillColor(i-1, j, color, target);
            FillColor(i, j+1, color, target);
            FillColor(i, j-1, color, target);
        }
        return image;
    }

    void FillColorRecurcive(int i, int j, int color, int target)
    {
        if (0 <= i && i < M && 0 <= j && j < N && 
            Image[i][j] == target && Image[i][j] != color)
        {
            Image[i][j] = color;
            FillColorRecurcive(i+1, j, color, target);
            FillColorRecurcive(i-1, j, color, target);
            FillColorRecurcive(i, j+1, color, target);
            FillColorRecurcive(i, j-1, color, target);
        }
    }

    void FillColor(int i, int j, int color, int target)
    {
        if (0 <= i && i < M && 0 <= j && j < N && 
            Image[i][j] == target && Image[i][j] != color)
        {
            Image[i][j] = color;
            Queue.Enqueue((i, j));
        }
    }
}