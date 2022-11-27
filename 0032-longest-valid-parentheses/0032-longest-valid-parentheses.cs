public class Solution {
    public int LongestValidParentheses(string s) {
        Stack<int> stack = new Stack<int>();
        int max = 0;
        stack.Push(-1);
        s += "(";

        for (int i = 0; i < s.Length; ++i)
        {
            char c = s[i];
            if (c == '(')
            {  
                stack.Push(i);
            }
            else // c == ')'
            {
                if (stack.Count > 1)
                {
                    stack.Pop();
                }
                else
                {
                    int count = i - stack.Pop() - 1;
                    if (max < count)
                        max = count;
                    stack.Push(i);
                }
            }
        }

        int lastI = stack.Pop();
        while(stack.Count > 0)
        {
            var i = stack.Pop();
            int count = lastI - i - 1;
            lastI = i;
            if (max < count)
                max = count;
        }
        
        return max;
    }
}