public class Solution {
    public bool IsPalindrome(int x) {
        string str = x.ToString();
        int p1 = 0, p2 = str.Length - 1;
        while (p1 < p2)
            if (str[p1++] != str[p2--])
                return false;
        return true;
    }
}