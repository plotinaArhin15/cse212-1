using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("low", 1);
        priorityQueue.Enqueue("medium", 5);
        priorityQueue.Enqueue("high", 10);
        var result = priorityQueue.Dequeue();
        Assert.AreEqual("high", result);
    }

    [TestMethod]
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 10);
        priorityQueue.Enqueue("B", 10);
        priorityQueue.Enqueue("C", 10);
        var result1 = priorityQueue.Dequeue();
        Assert.AreEqual("A", result1);
        var result2 = priorityQueue.Dequeue();
        Assert.AreEqual("B", result2);
        var result3 = priorityQueue.Dequeue();
        Assert.AreEqual("C", result3);
    }

    // Add more test cases as needed below.
}
