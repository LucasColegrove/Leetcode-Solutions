//Leetcode 345 - Reverse Vowels of a String
//AUTHOR: Lucas Colegrove (06/08/2024)    
using System;
using System.Collections.Generic;

public class Solution 
{
    HashSet<char> vowels = new HashSet<char> {'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};
    public string ReverseVowels(string s) 
    {

        char[] chars = s.ToCharArray();

        int start = 0;
        int end = chars.Length - 1;

        if(HasVowels(chars) == false)
        {
            return s;
        }
        
        while (start < end)
        {
            while (!vowels.Contains(chars[start]))
            {
                start++;
            }

            while (!vowels.Contains(chars[end]))
            {
                end--;
            } 

            if (start < end)
            {
                char temp = chars[start];
                chars[start] = chars[end];
                chars[end] = temp;
                start++;
                end--;
            }           
        }

        return new string(chars);
    }

    public bool HasVowels(char[] chars)
    {
        foreach (char c in chars)
        {
            if (vowels.Contains(c))
            {
                return true;
            }
        }
        return false;
    }
}