//AUTHOR: Lucas Colegrove (05/25/2024)    
using System;

public class Solution 
{
    public int[] SmallerNumbersThanCurrent(int[] nums) 
    {
        int[] ansArray = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            int count = 0;

            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] < nums[i])
                {
                    count++;
                }
            }

            ansArray[i] = count;
        }
  
        return ansArray;
    }
}