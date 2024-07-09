//Leetcode 605 - Can Place Flowers
//AUTHOR: Lucas Colegrove (06/07/2024)    
using System;

public class Solution 
{
    public bool CanPlaceFlowers(int[] flowerbed, int n) 
    {
        int[] newFlowerBed = new int[flowerbed.Length + 2];
        newFlowerBed[0] = 0;
        newFlowerBed[newFlowerBed.Length - 1] = 0;
        
        for(int i = 1; i <= flowerbed.Length; i++)
        {
            newFlowerBed[i] = flowerbed[i - 1];
        }

        for (int i = 1; i < newFlowerBed.Length - 1; i++)
        {
            if(newFlowerBed[i - 1] == 0 && newFlowerBed[i] == 0 && newFlowerBed[i + 1] == 0)
            {
                newFlowerBed[i] = 1;
                n -= 1;
            }
        }

        return n == 0;
    }
}