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

        /*
        1: Understand the problem.
        Create a new array of type double with size equal to "length".
        This array will hold all the multiples of the given number as the parameter.

        2: Use a for loop to go from index 0 (or first position for better understanding) 
        up to length - 1 and will run "lenght" of times.
        Example: if we insert 4 as parameter, it will run 4 times.
        Each position in the array will be filled with the correct multiple.

        3: Calculate the multiple for each position.
        The formula is: number * (i + 1).
        Example: if number = 3 and i = 0 → 3 * (0+1) = 3.
        Example: if number = 3 and i = 1 → 3 * (1+1) = 6.

        4: Save the result of the multiplication into the array at position i.
        In simple words, would put it in the right plase.
        Example: when i=2 (that is the 3rd position in the array), multiples will
        sum it's position index plus 1, the multiply by the number selected, the result is 9
        and it will be placed exactly in the i the loop selected, means the third position
        in the array. (I don't know how to explain it better). 

        5: After the loop ends, return the array with all multiples.
        */

        double[] multiples = new double[length];
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }   
        return multiples;
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

        /*
        1: Understand the problem.
        We need to rotate the list to the right by "amount".
        Rotating means shifting elements forward, and wrapping around to the front.

        2: Identify the split point.
        The last "amount" elements will move to the front.
        Example: data = {1,2,3,4,5,6,7,8,9}, amount = 3
        Split into two parts: if data = {1,2,3,4,5,6,7,8,9} and amount = 3 → rotated = {7,8,9}.

        3: Remove those elements from the end of the original list.
        After removal, data = {1,2,3,4,5,6}

        4: Insert the temporary list at the beginning of the original list.
        Final result: data = {7,8,9,1,2,3,4,5,6}.

        */
        List<int> rotated = new List<int>();
        rotated = data.GetRange(data.Count - amount, amount); 
        data.RemoveRange(data.Count - amount, amount);          
        data.InsertRange(0, rotated); 
    }
}
