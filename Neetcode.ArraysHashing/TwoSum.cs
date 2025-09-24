namespace Neetcode.ArraysHashing;

public class Class1
{
    public int[] TwoSum(int[] nums, int target)
    {
        var seen = new Dictionary<int, int>();
        for (int i = 0; i <= nums.Length; i++)
        {
            int difference = target - nums[i];
            if (seen.ContainsKey(difference))
            {
                return new int[] { seen[difference], i };
            }
            seen[nums[i]] = i;
        }
        return new int[] { -1, -1 };
        //throw new InvalidOperationException("No solution found");
    }
}
