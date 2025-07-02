public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double start, int count)
    {
        // Plan for MultiplesOf function:
        // 1. Create a new array of size 'count'.
        // 2. Loop from 0 to count - 1.
        // 3. For each index i, set the value to start * (i + 1).
        // 4. Return the array.

        double[] result = new double[count];
        for (int i = 0; i < count; i++)
        {
            result[i] = start * (i + 1);
        }

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
        // Plan for RotateListRight function:
        // 1. Find the index where the rotation should start: this is data.Count - amount.
        // 2. Use GetRange to get the sublist from that index to the end (these will move to the front).
        // 3. Use GetRange to get the sublist from the start up to that index (these will move after).
        // 4. Clear the original list.
        // 5. Add the two sublists back to the original list in the new order.

        int count = data.Count;
        int rotationIndex = count - amount;

        List<int> frontPart = data.GetRange(rotationIndex, amount);
        List<int> backPart = data.GetRange(0, rotationIndex);

        data.Clear();
        data.AddRange(frontPart);
        data.AddRange(backPart);
    }
}
