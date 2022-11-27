public class Solution {
    class Person
    {
        public int InTrust = 0;
        public int OutTrust = 0;
    }
    
    public int FindJudge(int n, int[][] trust) {
        Person[] people = new Person[n + 1];
        for (int i = 1; i <= n; ++i)
            people[i] = new Person();
        
        for (int i = 0; i < trust.Length; ++i)
        {
            int a = trust[i][0];
            int b = trust[i][1];
            ++people[a].OutTrust;
            ++people[b].InTrust;
        }
        
        int result = 0;
        int count = 0;
        int n_1 = n - 1;
        for (int i = 1; i <= n; ++i)
        {
            var person = people[i];
            if (person.InTrust == n_1 && person.OutTrust == 0)
            {
                result = i;
                ++count;
            }
        }
        
        if (count == 1)
            return result;
        return -1;
    }
}