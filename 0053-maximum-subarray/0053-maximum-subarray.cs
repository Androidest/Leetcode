public class Solution {
    public int MaxSubArray(int[] nums) {
        int sum = 0;
        int maxSum = nums[0];
        foreach (int num in nums)
        {
            sum = Math.Max(num + sum, num);
            maxSum = Math.Max(maxSum, sum);
        }
        return maxSum; 
    }
}