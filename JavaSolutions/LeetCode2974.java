//Leetcode 2974 - Minimum Number Game
//AUTHOR: Lucas Colegrove (07/02/2024)
import java.util.Arrays;

public class LeetCode2974 
{
    public int[] numberGame(int[] nums) 
    {
        Arrays.sort(nums);

        for (int i = 0; i < nums.length; i += 2)
        {
            int temp = nums[i];
            nums[i] = nums[i + 1];
            nums[i + 1] = temp;
        }

        return nums;
    }    
}
