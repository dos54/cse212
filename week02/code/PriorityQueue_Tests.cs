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

    // This test adds five items to the queue with different priorities.
    // The second and third item have the same priority; the second item should display
    // first in order to follow FIFO.
    // The item "fifth" is the forth item inserted, but with a lower priority than the
    // fifth to be inserted. Thus it should appear after the item "forth".
    // Results: After making a few changes, the test passes. 
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
    // Defect(s) Found: None; this feature works as intended.
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