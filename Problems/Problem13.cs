namespace Leetcode.Problems;

public partial class Solution
{
    public int RomanToInt(string s) {
        var conversions = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        int res = conversions[s[^1]];
        for (int i = s.Length-2; i >= 0; --i)
        {
            char preNumber = s[i+1];
            char romanNumber = s[i];
            if (conversions[romanNumber] >= conversions[preNumber])
            {
                res += conversions[romanNumber];
            }
            else 
            {
                res -= conversions[romanNumber];
            }
        }

        return res;
    }
}