namespace TwoSum.Logic;

public class Operations
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = 0; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new []{i,j};
                }
            }
        }

        throw new Exception( "blabla");
    }
}