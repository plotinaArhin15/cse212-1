public class SimpleQueueSolution
{
    private readonly List<int> _queue = new();

    /// <summary>
    /// Enqueue the value provided into the queue
    /// </summary>
    /// <param name="value">Integer value to add to the queue</param>
    public void Enqueue(int value)
    {
        // Add to the back of the queue
        _queue.Add(value);
    }

    /// <summary>
    /// Dequeue the next value and return it
    /// </summary>
    /// <exception cref="IndexOutOfRangeException">If queue is empty</exception>
    /// <returns>First integer in the queue</returns>
    public int Dequeue()
    {
        // Check if the queue is empty
        if (_queue.Count == 0)
            throw new IndexOutOfRangeException();

        // Remove from the front (index 0)
        int value = _queue[0];
        _queue.RemoveAt(0);
        return value;
    }

    public static void Run()
    {
        // Test Cases

        // Test 1
        // Scenario: Enqueue one value and then Dequeue it.
        // Expected Result: It should display 100
        Console.WriteLine("Test 1");
        SimpleQueueSolution queue = new SimpleQueueSolution();
        queue.Enqueue(100);
        int value = queue.Dequeue();
        Console.WriteLine(value);
        // Defect(s) Found: Trying to remove data from index 1 rather than 0

        Console.WriteLine("------------");

        // Test 2
        // Scenario: Enqueue multiple values and then Dequeue all of them
        // Expected Result: It should display 200, then 300, then 400 in that order
        Console.WriteLine("Test 2");
        queue = new SimpleQueueSolution();
        queue.Enqueue(200);
        queue.Enqueue(300);
        queue.Enqueue(400);
        value = queue.Dequeue();
        Console.WriteLine(value);
        value = queue.Dequeue();
        Console.WriteLine(value);
        value = queue.Dequeue();
        Console.WriteLine(value);
        // Defect(s) Found: The enqueue was inserting at the front of the queue

        Console.WriteLine("------------");

        // Test 3
        // Scenario: Dequeue from an empty Queue
        // Expected Result: An exception should be raised
        Console.WriteLine("Test 3");
        queue = new SimpleQueueSolution();
        try
        {
            queue.Dequeue();
            Console.WriteLine("Oops ... This shouldn't have worked.");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("I got the exception as expected.");
        }
        // Defect(s) Found: None :)
    }
}