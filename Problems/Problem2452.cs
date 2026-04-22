namespace Leetcode.Problems;

public partial class Solution
{
    public IList<string> TwoEditWords(string[] queries, string[] dictionary) {
        var res = new List<string>();

        foreach (var query in queries)
        {
            foreach (var dict in dictionary)
            {
                if (query == dict)
                {
                    res.Add(query);
                    break;
                }
                
                var queryLetters = query.ToCharArray();
                var dictionaryLetters = dict.ToCharArray();

                int diffCount = 0;
                for (int k = 0; k < queryLetters.Length; ++k)
                {
                    if (diffCount > 2) break;
                    if (queryLetters[k] != dictionaryLetters[k]) ++diffCount;
                }

                if (diffCount <= 2)
                {
                    res.Add(query);
                    break;
                }
            }
        }

        return res;
    }
}