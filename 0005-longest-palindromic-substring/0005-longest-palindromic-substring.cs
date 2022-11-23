public class Solution {
    public string LongestPalindrome(string s) {
        int max1=0, max2=0;
        for (int i = 0; i < s.Length; ++i)
        {
            int o1, o2, e1, e2, p1, p2;
            (o1, o2) = GetPalindrome(s, i-1, i+1);
            (e1, e2) = GetPalindrome(s, i-1, i);
            (p1, p2)  = (o2 - o1 > e2 - e1)? (o1, o2) : (e1, e2);
             Console.WriteLine($"{o1} {o2} {e1} {e2} {p1} {p2}");
            (max1, max2) = (p2 - p1 > max2 - max1)? (p1, p2) : (max1, max2);
        }
       
        return s.Substring(max1, max2 - max1);
    }
    
    public (int, int) GetPalindrome(string s, int p1, int p2)
    {
        while(0 <= p1 && p2 < s.Length)
        {
            if (s[p1] != s[p2])
                break;
            --p1;            
            ++p2;
        }
            
        return (p1 + 1, p2);
    }
}