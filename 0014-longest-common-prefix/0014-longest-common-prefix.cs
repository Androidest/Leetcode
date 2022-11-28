public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string prefix = "";
        string firstStr = strs[0];
        for (int i = 0; i < firstStr.Length; ++i)
        {
            char c = firstStr[i];
            foreach (var str in strs)
            {
                if (i >= str.Length || str[i] != c)
                    return prefix;
            }
            prefix += c;
        }
        return prefix;
    }
}