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
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // I will create an empty fixed array of size 'length'. I will run a for loop starting at 0 that multiplies 'number' by the current number
        // of iterations 'i' + 1. Set the value at index 'i' of the 'multiples' array to the result.
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
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // I will take all of the values AFTER the 'amount' (data.Count - amount) and copy those to
        // a new, temporary list. I will take all the values BEFORE that and paste them to another
        // temporary list. I will then clear the 'data' list and add first the last few items,
        // then the first few items.
        
        // Essentially, cut the original array into 2 slices. Hold each slice in temporary arrays.
        // Clear the original array, then paste the 2 slices into the original array at opposite sides.  
        List<int> afterCutoff = data.GetRange(data.Count - amount, amount);
        List<int> beforeCutoff = data.GetRange(0, data.Count - amount);
        data.Clear();
        data.AddRange(afterCutoff);
        data.AddRange(beforeCutoff);
    }
}
