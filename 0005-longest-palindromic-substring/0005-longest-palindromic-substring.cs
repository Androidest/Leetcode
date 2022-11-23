public class Solution {
    public string LongestPalindrome(string s) {
        for (int l = s.Length - 1; l >= 0; --l)
        {
            int subStringCount = s.Length - l;
            for (int p1 = 0; p1 < subStringCount; ++p1)
            {
                int p2 = p1 + l;
                if (IsPalindromic(s, p1, p2))
                    return s.Substring(p1, l+1);
            }
        }
        return "";
    }
    
    public bool IsPalindromic(string s, int p1, int p2)
    {
        while(p1 < p2)
            if(s[p1++] != s[p2--])
                return false;
        return true;
    }
}