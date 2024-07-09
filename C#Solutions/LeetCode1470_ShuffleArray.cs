//Leetcode 1470 - Shuffle the Array
//AUTHOR: Lucas Colegrove (06/03/2024)    
using System;

public class Solution 
{
    public int[] Shuffle(int[] nums, int n) 
    {
        int[] shuffledArray = new int[2 * n]; 

        int x = 0;

        for (int i = 0; i < shuffledArray.Length; i ++)
        {
            if (i % 2 == 0)
            {
                shuffledArray[i] = nums[x];
                x++;
            }
            else
            {
                shuffledArray[i] = nums[n];
                n++;
            }
        }

        return shuffledArray;
    }
}