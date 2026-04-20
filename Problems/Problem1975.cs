namespace Leetcode.Problems;

public partial class Solution
{
    public long MaxMatrixSum(int[][] matrix) {
        long sum = 0;
        int countNeg = 0;
        int min = Int32.MaxValue;
        for (int i = 0; i < matrix.Length; ++i)
        {
            for (int j = 0; j < matrix.Length; ++j)
            {
                if (matrix[i][j] < 0)
                {
                    ++countNeg;
                }
                min = Math.Min(min, Math.Abs(matrix[i][j]));
                sum += Math.Abs(matrix[i][j]);
            }
        }
        if (countNeg % 2 != 0)
        {
            if (min != 0)
            {
                sum -= 2*min;
            }
        }

        return sum;
    }
}