using System.Runtime.InteropServices;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Create a new double array with the same size as length
        // Loop through each index in the arra, starting at 0
        // For each index, multiply number by index + 1 to get the correct multiple
        // Store that mutiple in the array
        // After the loop finishes, return the array

        double[] multiples = new double[length];

        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        return multiples; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Find the index where the last 'amount' numbers begin
        //Copy the last 'amount' numbers into a temporary list
        // Copy the remaining numbers from the beginning into another temporary list
        // Clear the original list
        // Add the last numbers first
        // Add the beginning numbers after that

        int splitIndex = data.Count - amount;

        List<int> lastPart = data.GetRange(splitIndex, amount);

        List<int> firstPart = data.GetRange(0, splitIndex);

        data.Clear();

        data.AddRange(lastPart);

        data.AddRange(firstPart);
    }
}
