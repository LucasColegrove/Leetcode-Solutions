/*
PROGRAM DESCRIPTION:


EXAMPLE OUTPUT:


AUTHOR: Lucas Colegrove (05/21/2024)    
*/
using System;

public class Solution 
{
    public int[] GetConcatenation(int[] nums) 
    {
        int length = nums.Length;
        int[] ans = new int[length * 2];

        for(int i = 0; i < length; i++)
        {
            ans[i] = nums[i];
            ans[i + length] = nums[i];         
        }    
        
        return ans;
    }
}