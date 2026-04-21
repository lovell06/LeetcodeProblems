namespace Leetcode.Problems;

public partial class Solution
{
    public int[]? TwoSum(int[] nums, int target) {
        var complements = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; ++i)
        {
            int complement = target - nums[i];
            if (complements.ContainsKey(nums[i]))
            {
                return [complements[nums[i]], i];
            }
            complements[complement] = i;
        } 

        return null;
    }
}