using System.Collections.Generic;

public static class UniqueLetters
{
    public static void Run()
    {
        var test1 = "abcdefghjiklmnopqrstuvwxyz"; // Expect True because all letters unique
        Console.WriteLine(AreUniqueLetters(test1));

        var test2 = "abcdefghjiklanopqrstuvwxyz"; // Expect False because 'a' is repeated
        Console.WriteLine(AreUniqueLetters(test2));

        var test3 = "";
        Console.WriteLine(AreUniqueLetters(test3)); // Expect True because its an empty string
    }

    /// <summary>Determine if there are any duplicate letters in the text provided</summary>
    /// <param name="text">Text to check for duplicate letters</param>
    /// <returns>true if all letters are unique, otherwise false</returns>
    private static bool AreUniqueLetters(string text)
    {
        // A HashSet will only allow unique values to be entered.
        var uniqueLetters = new HashSet<char>();
        foreach (var letter in text)
        {
            // If we try to add a letter that is already in the set, the Add
            // function will return false. This is how we know there is a duplicate.
            if (!uniqueLetters.Add(letter))
            {
                return false;
            }
        }

        // If we get here, then there are no duplicates.
        return true;
    }
}