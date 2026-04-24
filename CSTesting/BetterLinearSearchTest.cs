using System;

public class BetterLinearSearch
{
    /// <summary>
    /// Performs a linear search on an array to find a target value.
    /// </summary>
    /// <param name="arr">Array of integers to search</param>
    /// <param name="target">Value to find</param>
    /// <returns>Index of target if found, otherwise -1</returns>
    public static int Search(int[] arr, int target)
    {
        // Loop through each element in the array
        for (int i = 0; i < arr.Length; i++)
        {
            // Check if current element matches the target
            if (arr[i] == target)
            {
                // Return the index where the target is found
                return i;
            }
        }

        // If target is not found, return -1
        return -1;
    }
}