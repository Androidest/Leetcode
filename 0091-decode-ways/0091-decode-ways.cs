public class Solution {
    string str;
    int lastIndex;
    int[] Memo;
    Dictionary<string, bool> Map;

    public int NumDecodings(string s) {
        str = s;
        lastIndex = s.Length - 1;
        Map = new Dictionary<string, bool>();
        Memo = new int[s.Length];

        for (int i = 1; i < 27; ++i)
            Map.Add($"{i}", true);
        for (int i = 0; i < Memo.Length; ++i)
            Memo[i] = -1;
        return GetDecodeWaysRecursively(0);
    }
    
    int GetDecodeWaysRecursively(int i)
    {
        if (Memo[i] != -1)
            return Memo[i];
        
        int count = 0;
        int j = i + 1; 
        if (Map.ContainsKey($"{str[i]}"))
        {
            if (i == lastIndex)
                count = 1;
            else
                count += GetDecodeWaysRecursively(j);
        }
        if (j <= lastIndex && Map.ContainsKey($"{str[i]}{str[j]}"))
        {
            if (j == lastIndex)
                count += 1;
            else
                count += GetDecodeWaysRecursively(j + 1);
        } 
        Memo[i] = count;
        return count;
    }
}