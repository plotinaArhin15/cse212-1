public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10 };
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1 };
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        List<int> result = new List<int>();
        int idx1 = 0, idx2 = 0;
        foreach (var s in select)
        {
            if (s == 1)
            {
                result.Add(list1[idx1]);
                idx1++;
            }
            else if (s == 2)
            {
                result.Add(list2[idx2]);
                idx2++;
            }
        }
        return result.ToArray();
    }
}