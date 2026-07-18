using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Sample data for the first test
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4 };
        HashSet<int> set2 = new HashSet<int> { 3, 4, 5, 6 };

        // Call each function
        HashSet<int> intersection = FindIntersection(set1, set2);
        HashSet<int> union = FindUnion(set1, set2);

        // Display the original sets
        Console.WriteLine("Set 1: " + string.Join(", ", set1));
        Console.WriteLine("Set 2: " + string.Join(", ", set2));

        // Display the results
        Console.WriteLine(
            "Intersection: " + string.Join(", ", intersection));

        Console.WriteLine(
            "Union: " + string.Join(", ", union));
    }

    // Finds the values that appear in both sets.
    public static HashSet<int> FindIntersection(
        HashSet<int> set1,
        HashSet<int> set2)
    {
        // Create an empty set to hold the shared values.
        HashSet<int> result = new HashSet<int>();

        // Look at every number in the first set.
        foreach (int number in set1)
        {
            // Check whether the second set also contains the number.
            if (set2.Contains(number))
            {
                // Add the number because it appears in both sets.
                result.Add(number);
            }
        }

        // Return the completed intersection.
        return result;
    }

    // Finds every value that appears in either set.
    public static HashSet<int> FindUnion(
        HashSet<int> set1,
        HashSet<int> set2)
    {
        // Create an empty set to hold all unique values.
        HashSet<int> result = new HashSet<int>();

        // Add every value from the first set.
        foreach (int number in set1)
        {
            result.Add(number);
        }

        // Add every value from the second set.
        foreach (int number in set2)
        {
            // HashSet automatically ignores duplicate values.
            result.Add(number);
        }

        // Return the completed union.
        return result;
    }
}