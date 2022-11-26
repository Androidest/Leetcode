public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        
        for (int i = 0; i < nums.Length; ++i)
        {
            int val = nums[i];
            if (map.TryGetValue(target - val, out var j))
            {
                return new int[] {i, j};
            }
            if (!map.ContainsKey(val))
                map.Add(val, i);
        }
        return null;
    }
}