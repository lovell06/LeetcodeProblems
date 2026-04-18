namespace Leetcode.Problems;

// 757. Set Intersection Size At Least Two
public partial class Solution
{
    public int IntersectionSizeTwo(int[][] intervals) 
    {
        Array.Sort(intervals, (a, b) => {
            int cmp = a[1].CompareTo(b[1]);
            if (cmp != 0) return cmp;
            return b[0].CompareTo(a[0]);
        });

        int min = -2;
        int max = -1;
        int ans = 0;

        foreach (var interval in intervals)
        {
            int start = interval[0];
            int end = interval[1];

            if (start > max)
            {
                min = end - 1;
                max = end;
                ans += 2;
            } 
            else if (start > min)
            {
                min = max;
                max = end;
                ans += 1;
            }
        }

        return ans;

    }
}
