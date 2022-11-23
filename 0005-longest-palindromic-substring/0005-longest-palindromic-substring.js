/**
 * @param {string} s
 * @return {string}
 */
var longestPalindrome = function(s) {
    for (let l=s.length-1; l >= 0; --l)
    {
        for (let p1 = 0; p1 < s.length - l; ++p1)
        {
            if (isPalindromic(s, p1, p1 + l))
                return s.substring(p1, p1 + l + 1);
        }
    }
};

function isPalindromic(s, p1, p2)
{
    while (p1 < p2)
        if (s[p1++] != s[p2--])
            return false;
    return true;
}