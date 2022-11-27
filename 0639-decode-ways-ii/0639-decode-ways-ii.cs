public class Solution {
    public int NumDecodings(string s) {
        long[] memo = new long[s.Length + 1];
        memo[s.Length] = 1;
        
        for (int i = s.Length - 1; i >= 0; --i)
        {
            int j = i + 1;
            if (s[i] == '*')
                memo[i] = memo[j] * 9;
            else if (isValid(s[i]))
                memo[i] = memo[j];
            else 
                memo[i] = 0;

            if (j < s.Length)
            {
                char c1 = s[i];
                char c2 = s[j];

                if (c1 == '*' && c2 == '*')
                    memo[i] += 15 * memo[i + 2];
                else if (c1 == '*')
                {
                    if ('0' <= c2 && c2 <= '6')
                        memo[i] += 2 * memo[i + 2];
                    if ('6' < c2 && c2 <= '9')
                        memo[i] += memo[i + 2];
                }
                else if (c2 == '*')
                {
                    if ('1' == c1)
                        memo[i] += 9 * memo[i + 2];
                    else if (c1 == '2')
                        memo[i] += 6 * memo[i + 2];
                }
                else if (isValidDouble(c1, c2))
                    memo[i] += memo[i + 2];
            }
            memo[i] = memo[i] % 1000000007;
        }
        
        return (int)memo[0];
    }
    
    bool isValid(char c) => '1' <= c && c <= '9';
    bool isValidDouble(char c1, char c2) 
    {
        if ('1' == c1)
            return '0' <= c2 && c2 <= '9';
        if ('2' == c1)
            return '0' <= c2 && c2 <= '6';
        return false;
    }
}