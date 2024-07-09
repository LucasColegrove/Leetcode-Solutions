//Leetcode 2011 - Final Value of Variable After Performing Operations
//AUTHOR: Lucas Colegrove (06/03/2024)    
using System;

public class Solution 
{
    public int FinalValueAfterOperations(string[] operations) 
    {
        int output = 0;

        foreach (string operation in operations)
        {
            if (operation == "X++" || operation == "++X")
            {
                output++;
            }
            else if (operation == "X--" || operation == "--X")
            {
                output--;
            }
        }

        return output;
    }
}