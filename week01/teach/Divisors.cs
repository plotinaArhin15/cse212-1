<<<<<<< HEAD
public static class Divisors
{
    /// <summary>
    /// Entry point for the Divisors class
    /// </summary>
    public static void Run()
    {
=======
public static class Divisors {
    /// <summary>
    /// Entry point for the Divisors class
    /// </summary>
    public static void Run() {
>>>>>>> b16ee35c239bbe20106348c5095d53a359f3b936
        List<int> list = FindDivisors(80);
        Console.WriteLine("<List>{" + string.Join(", ", list) + "}"); // <List>{1, 2, 4, 5, 8, 10, 16, 20, 40}
        List<int> list1 = FindDivisors(79);
        Console.WriteLine("<List>{" + string.Join(", ", list1) + "}"); // <List>{1}
    }

    /// <summary>
    /// Create a list of all divisors for a number including 1
    /// and excluding the number itself. Modulo will be used
    /// to test divisibility.
    /// </summary>
    /// <param name="number">The number to find the divisor</param>
    /// <returns>List of divisors</returns>
<<<<<<< HEAD
    public static List<int> FindDivisors(int number)
    {
        List<int> divisors = new List<int>();
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                divisors.Add(i);
            }
        }
        return divisors;
=======
    private static List<int> FindDivisors(int number) {
        List<int> results = new();
        // TODO problem 1
        return results;
>>>>>>> b16ee35c239bbe20106348c5095d53a359f3b936
    }
}