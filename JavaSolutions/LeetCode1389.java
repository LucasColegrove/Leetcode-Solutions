//Leetcode 1389 - Create Target Array in the Given Order
//AUTHOR: Lucas Colegrove (06/28/2024) 
import java.util.*;
public class LeetCode1389 
{
    public int[] createTargetArray(int[] nums, int[] index) 
    {
        int[] answer = new int[nums.length];
        List<Integer> order = new ArrayList<>();

        for (int i = 0; i < nums.length; i++)
        {
            order.add(index[i], nums[i]);
        }

        for (int i = 0; i < nums.length; i++)
        {
            answer[i] = order.get(i);
        }        
        return answer;
    }    
}
