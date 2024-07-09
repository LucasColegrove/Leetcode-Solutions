//Leetcode 1431 - Kids With the Greatest Number of Candies
//AUTHOR: Lucas Colegrove (06/06/2024)    
using System;
using System.Collections.Generic;

public class Solution 
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) 
    {
        IList<bool> List = new List<bool> {};
        
        int mostCandy = 0;
        foreach (int candy in candies)
        {
            if (candy > mostCandy)
            {
                mostCandy = candy;
            }
        }

        for (int i = 0; i < candies.Length; i++)
        {
            candies[i] += extraCandies;
            if (candies[i] >= mostCandy)
            {
                List.Add(true);
            }
            else
            {
                List.Add(false);
            }
        }

        return List;
    }
}