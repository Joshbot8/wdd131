using System;

public class BetterLinearSearch
{
    /// <summary>
    /// Performs a linear search on an integer array.
    /// This algorithm checks each element one by one until it finds the target value.
    /// </summary>
    /// <param name="arr">The array of integers to search through</param>
    /// <param name="target">The value we are trying to find</param>
    /// <returns>
    /// The index of the target if it is found.
    /// Returns -1 if the target does not exist in the array.
    /// </returns>
    public static int Search(int[] arr, int target)
    {
        // Step 1: Start at the first index of the array
        for (int i = 0; i < arr.Length; i++)
        {
            // Step 2: Compare current element with target value
            if (arr[i] == target)
            {
                // Step 3: If a match is found, return its index immediately
                return i;
            }
        }

        // Step 4: If loop finishes with no match, return -1
        return -1;
    }

    /// <summary>
    /// Main method used ONLY for debugging and testing manually.
    /// This is not required for unit tests, but helps verify correctness.
    /// </summary>
    public static void Main(string[] args)
    {
        // Sample array for testing
        int[] numbers = { 3, 7, 12, 19, 25 };

        Console.WriteLine("=== Better Linear Search Debug Tests ===\n");

        // Test 1: Value exists in array
        Console.WriteLine("Searching for 12 (expected index 2):");
        Console.WriteLine("Result: " + Search(numbers, 12));

        // Test 2: Last element
        Console.WriteLine("\nSearching for 25 (expected index 4):");
        Console.WriteLine("Result: " + Search(numbers, 25));

        // Test 3: Value not in array
        Console.WriteLine("\nSearching for 99 (expected -1):");
        Console.WriteLine("Result: " + Search(numbers, 99));

        Console.WriteLine("\n=== End of Tests ===");
    }
}