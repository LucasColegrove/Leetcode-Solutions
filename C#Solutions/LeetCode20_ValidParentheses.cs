//AUTHOR: Lucas Colegrove (05/26/2024)    
using System;
using System.Collections.Generic;

public class Solution 
{
    public bool IsValid(string s) 
    {
       
       Stack<char> stack = new Stack<char>();
       
       Dictionary<char, char> closeToOpen = new Dictionary<char, char>
       {
            { ')' , '('},
            { '}' , '{'},
            { ']' , '['}
       };

       foreach (char c in s)                        // iterate through each character in input string
       {
            if (closeToOpen.ContainsValue(c))       // if the character is an opening bracket, push it onto the stack
            {
                stack.Push(c);
            }
            else if (closeToOpen.ContainsKey(c))    // if the character is a closing bracket
            {
                if (stack.Count > 0 && stack.Peek() == closeToOpen[c])  // Check if the stack is not empty and the top of the stack matches the corresponding opening bracket
                {
                    stack.Pop();                    // pop the top element from the stack
                }
                else
                {
                    return false;                   // // If the stack is empty or the top element doesn't match, the brackets are not balanced
                }
            }         
       }

        return stack.Count == 0;
    }
}