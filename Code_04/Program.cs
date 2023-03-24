
Solution s = new Solution();

int[] num1 = { 1, 2 };
int[] num2 = { 3, 4 };


Console.WriteLine(s.FindMedianSortedArrays(num1, num2));

public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int[] ans = new int[nums1.Length + nums2.Length];
        int j = 0;
        int jj = 0;
        for(int i = 0; i < ans.Length; i++) 
        {
            if(nums2.Length == jj)
            {
                ans[i] = nums1[j];
                j++;
            }
            else if(nums1.Length == j)
            {
                ans[i] = nums2[jj];
                jj++;
            }
            else if (nums1[j] < nums2[jj])
            {
                ans[i] = nums1[j];
                j++;
            }
            else
            {
                ans[i] = nums2[jj];
                jj++;
            }
        }
        if (ans.Length % 2 != 0) 
        {
            return ans[ans.Length / 2];
        }
        return Convert.ToDouble(ans[ans.Length / 2 - 1] + ans[ans.Length / 2]) / 2;
    }
}