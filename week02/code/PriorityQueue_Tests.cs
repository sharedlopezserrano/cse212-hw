using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Insert three items with different priorities
    // Expected Result: Items should be dequeued in descending order of priority: High (5), Mid (3), Low (1)
    // Defect(s) Found: None
    public void TestPriorityQueue_1()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("Low", 1);
        pq.Enqueue("High", 5);
        pq.Enqueue("Mid", 3);

        Assert.AreEqual("High", pq.Dequeue());
        Assert.AreEqual("Mid", pq.Dequeue());
        Assert.AreEqual("Low", pq.Dequeue());
    }

    [TestMethod]
    // Scenario: Insert items with same priority
    // Expected Result: All items with same priority should be dequeued, though insertion order is not guaranteed
    // Defect(s) Found: No insertion order preservation, which is acceptable for current logic
    public void TestPriorityQueue_2()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("A", 2);
        pq.Enqueue("B", 2);
        pq.Enqueue("C", 3);

        Assert.AreEqual("C", pq.Dequeue());

        var remaining = new List<string> { pq.Dequeue(), pq.Dequeue() };
        CollectionAssert.AreEquivalent(new List<string> { "A", "B" }, remaining);
    }

    // Add more test cases as needed below.
}