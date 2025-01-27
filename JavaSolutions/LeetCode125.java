//Leetcode 125 - Valid Palindrome
//AUTHOR: Lucas Colegrove (06/28/2024) 
public class LeetCode125 
{
    public boolean isPalindrome(String s) 
    {
        s = removeNonAlphanumeric(s).toLowerCase();
        StringBuilder build = new StringBuilder();

        for (int i = s.length() - 1; i > -1; i--)
        {
            char c = s.charAt(i);
            build.append(c);
        }

        String reverse = build.toString();

        return s.equals(reverse);
    }

    public static String removeNonAlphanumeric(String str) 
    {
        String result = str.replaceAll("[^a-zA-Z0-9]", "");
        return result; 
    }
}
