using System.Collections;

public class Solution {
    Dictionary<char, bool> dict = new Dictionary<char, bool>();

    public int LengthOfLongestSubstring(string s) {
        int j = -1;
        int max = 0;
        for (int i = 0; i < s.Length; ++i)
        {
            if (dict.ContainsKey(s[i]))
            {
                char repeated = s[i];
                dict.Remove(repeated);
                for (++j; j < i-1; ++j)
                {
                    dict.Remove(s[j]);
                    if (s[j] == repeated)
                        break;
                } 
            }
            dict.Add(s[i], true);
            if (i-j > max)
                max = i-j;
        }
        return max;
    }
}