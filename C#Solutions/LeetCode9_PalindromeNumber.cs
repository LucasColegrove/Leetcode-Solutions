/*
PROGRAM DESCRIPTION:


EXAMPLE OUTPUT:


AUTHOR: Lucas Colegrove (05/24/2024)    
*/
using System;

public class Solution 
{
    public bool IsPalindrome(int x) 
    {
        string numberString = x.ToString();

        int i = 0;
        int j = numberString.Length - 1;

        while (i < j)
        {
            if (numberString[i] != numberString[j])
            {
                return false;
            }

            i++;
            j--;
        }

        return true;
    }
}