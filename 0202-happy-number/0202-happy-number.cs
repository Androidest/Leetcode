using System.Collections;

public class Solution {
    public bool IsHappy(int n) {
        Hashtable dic = new Hashtable();
        while(true)
        {
            int sum = 0;
            while(n > 0)
            {
                int digit =  n % 10;
                sum += digit * digit;
                n /= 10;
            }
            if (sum == 1)
            {
                return true;
            }
            else
            {
                if (dic.ContainsKey(sum.ToString()))
                    return false;
                dic.Add(sum.ToString(), 0);
                n = sum;
            }
        }
    }
}