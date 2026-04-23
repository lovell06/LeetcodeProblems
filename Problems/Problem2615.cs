namespace Leetcode.Problems;

public partial class Solution {
    public long[] Distance(int[] nums) 
    {
        Dictionary<int, List<int>> indexGroups = new Dictionary<int, List<int>>();        
        for (int i = 0; i < nums.Length; ++i)
        {
            if (!indexGroups.ContainsKey(nums[i]))
            {
                indexGroups[nums[i]] = [i];
                continue;
            }
            indexGroups[nums[i]].Add(i);
        }

        long[] res = new long[nums.Length];
        foreach (var mapGroup in indexGroups)
        {
            var group = mapGroup.Value;

            int groupSize = group.Count;

            var prefixSum = new long[groupSize];

            prefixSum[0] = group[0];
            for (int i = 1; i < groupSize; ++i)
                prefixSum[i] = group[i] + prefixSum[i-1];

            for (int i = 0; i < groupSize; ++i)
            {
                int index = group[i];

                res[index] = 1L * i * group[i] - 1L * (groupSize - i - 1) * group[i];
                int l = i - 1;
                if (l >= 0)
                    res[index] -= prefixSum[l];
                res[index] += prefixSum[groupSize-1] - prefixSum[i];
            }
        }
        
        return res;
    }
}