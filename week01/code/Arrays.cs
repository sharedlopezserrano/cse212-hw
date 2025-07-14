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
    // Step 1 Create a new array to hold the multiples
    double[] result = new double[length];

    // Step 2 Loop to fill in the array
    for (int i = 0; i < length; i++)
    {
    // Step 3 Calculate each multiple of the given number
        result[i] = number * (i + 1);
    }

    // Step 4 Return the completed array
    return result;
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
    // Step 1 Determine the number of items in the list
    int count = data.Count;

    // Step 2 Calculate the index to split the list
    int splitIndex = count - amount;

    // Step 3 Get the elements to move to the front
    List<int> rightPart = data.GetRange(splitIndex, amount);

    // Step 4 Get the remaining elements
    List<int> leftPart = data.GetRange(0, splitIndex);

    // Step 5 Clear the original list
    data.Clear();

    // Step 6 Add the rotated parts back in correct order
    data.AddRange(rightPart);
    data.AddRange(leftPart);
}

}


