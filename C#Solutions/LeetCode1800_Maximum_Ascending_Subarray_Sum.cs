/*
PROGRAM DESCRIPTION:


EXAMPLE OUTPUT:


AUTHOR: Lucas Colegrove (05/21/2024)    
*/
using System;

public class Solution 
{
    public int MaxAscendingSum(int[] nums) 
    {
        int maxSum = nums[0];
        int sum = nums[0];
     
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > nums[i - 1])
            {
                sum += nums[i];           
            }
            else
            {
                sum = nums[i];
            }
 
            if (sum > maxSum)
            {
                maxSum = sum;
            }  
        }
        
        return maxSum;
    }
}