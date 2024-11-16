using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Ensure highest priority is dequeued first
    // Expected Result: first, second, third, forth, fifth
    // Defect(s) Found: Items are not removed from the queue. Items with same priority
    // are not following FIFO.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        string[] expectedResults = ["first", "second", "third", "forth", "fifth"];

        priorityQueue.Enqueue("first", 5);
        priorityQueue.Enqueue("second", 3);
        priorityQueue.Enqueue("third", 3);
        priorityQueue.Enqueue("fifth", 1);
        priorityQueue.Enqueue("forth", 2);

        for (int i = 0; i < expectedResults.Length; i++)
        {
            Assert.AreEqual(expectedResults[i], priorityQueue.Dequeue());
        }
    }

    [TestMethod]
    // Scenario: Queue is empty and should return an error
    // Expected Result: Error: The queue is empty.
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
        catch (AssertFailedException)
        {
            throw;
        }
        catch (Exception e)
        {
            Assert.Fail(
                 string.Format("Unexpected exception of type {0} caught: {1}",
                                e.GetType(), e.Message)
            );
        }
    }

    // Add more test cases as needed below.
}