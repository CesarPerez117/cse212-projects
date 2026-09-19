using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue three items with different priorities and dequeue them all.
    // Expected Result: Items should come out in order of highest priority first.
    // Ex: 
    // Defect(s) Found: Original code did not remove items from the queue and skipped the last element.
    /*
    Fix: Changed the loop to index < _queue.Count so all items are checked.
    Added _queue.RemoveAt(highPriorityIndex) to actually remove the dequeued item.
    This ensures each call to Dequeue returns and removes the highest priority item.
    */
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("Medium", 5);
        priorityQueue.Enqueue("High", 10);

        Assert.AreEqual("High", priorityQueue.Dequeue());
        Assert.AreEqual("Medium", priorityQueue.Dequeue());
        Assert.AreEqual("Low", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue items with equal priority.
    // Expected Result: Items should be dequeued in the order they were enqueued.
    // Ex:
    // Defect(s) Found: Original code used >= comparison, causing the last equal-priority item to be chosen instead of the first (FIFO broken)
    /*
    Fix: Changed the comparison to strictly greater (>).
    Now, if two items have the same priority, the first one encountered remains selected.
    */
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("First", 5);
        priorityQueue.Enqueue("Second", 5);
        priorityQueue.Enqueue("Third", 5);

        Assert.AreEqual("First", priorityQueue.Dequeue());
        Assert.AreEqual("Second", priorityQueue.Dequeue());
        Assert.AreEqual("Third", priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.
}