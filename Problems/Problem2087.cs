namespace Leetcode.Problems;

public partial class Solution
{
    public int MaxDistance(int[] colors) {
        int maxDistance = Int32.MinValue;
        for (int i = 0; i < colors.Length; ++i)
        {
            for (int j = i + 1; j < colors.Length; ++j)
            {
                if (colors[i] != colors[j])
                    maxDistance = Math.Max(maxDistance, Math.Abs(i-j));
            }
        }

        return maxDistance;
    }
}