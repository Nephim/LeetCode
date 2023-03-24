using System.ComponentModel.DataAnnotations;

Solution s = new Solution();

s.LengthOfLongestSubstring("dvdf");


public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        int ans = 0;
        var map = new Dictionary<char, int>();

        int j = 0;
        for (int i = 0; i < s.Length; i++) 
        {
            char c = s[i];
            if(map.ContainsKey(c))
            {
                ans = ans > j ? ans : j;

                map.TryGetValue(c, out i);
                i++;
                c = s[i];
                map = new Dictionary<char, int>();
                j = 0;
            }

            map.Add(c, i);
            j++;
        }

        ans = ans > j ? ans : j;

        return ans;
    }
}