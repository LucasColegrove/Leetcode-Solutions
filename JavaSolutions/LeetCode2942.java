//Leetcode 2942 - Find Words Containing Character
//AUTHOR: Lucas Colegrove (06/24/2024)   
import java.util.*;

class LeetCode2942 
{
    public List<Integer> findWordsContaining(String[] words, char x) 
    {
        List<Integer> list = new ArrayList<Integer>();
        String character = Character.toString(x);

        for (int i = 0; i < words.length; i++)
        {
            if (words[i].contains(character))
            {
                list.add(i);
            }
        }     
        return list;           
    }

    public static void main(String[] args) 
    {
        LeetCode2942 solution = new LeetCode2942();
        String[] words = {"apple", "banana", "cherry", "date"};
        char character = 'a';
        List<Integer> result = solution.findWordsContaining(words, character);
        System.out.println("Indices of words containing '" + character + "': " + result);
    }
}
