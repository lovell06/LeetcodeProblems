namespace Leetcode.Problems;

public partial class Solution 
{
    public int MinOperations(int[][] grid, int x) 
    {
        if (grid.Length * grid[0].Length == 1) return 0;
        
        int norm = grid[0][0] % x;
        List<int> lst = [];
        foreach (var rows in grid)
        {
            foreach (var cell in rows)
            {
                if (cell % x != norm) return -1;
                lst.Add(cell);
            }
        }

        lst.Sort();

        int mid = lst[lst.Count/2];
        int count = 0;
        lst.ForEach(e => 
        {
            count += Math.Abs((e-mid)/x);
        });

        return count;
    }
}