using DataStructuresLibrary;

namespace DataStructuresTest;

[TestClass]
public class MyLinkedListUnitTest
{
    [TestMethod]
    public void LinkedListCtor()
    {
        MyLinkedList<int> list = new();
        Assert.AreEqual(null, list.Head);
        Assert.AreEqual(0, list.Count);
    }

    [TestMethod]
    public void LinkedListAddItem()
    {
        MyLinkedList<int> list = new();
        list.Add(5);

        Assert.AreEqual(5, list.Head?.Value);
        Assert.AreEqual(1, list.Count);
        Assert.AreEqual(null, list.Head?.Next);

        list.Add(10);
        Assert.AreEqual(10, list.Head?.Value);
        Assert.AreEqual(2, list.Count);
        Assert.AreEqual(null, list.Head?.Next?.Next);
    }

    [TestMethod]
    public void LinkedListRemoveItem()
    {
        MyLinkedList<int> list = new();
        Assert.ThrowsException<ArgumentException>(() => list.Remove(0));
        
        list.Add(5);
        Assert.AreEqual(1, list.Count);
        
        list.Remove(5);
        Assert.AreEqual(0, list.Count);
        
        Assert.ThrowsException<ArgumentException>(() => list.Remove(5));
        
        list.Add(10);
        list.Add(20);
        Assert.AreEqual(2, list.Count);
        
        list.Remove(20);
        Assert.AreEqual(1, list.Count);
        
        list.Remove(10);
        Assert.AreEqual(0, list.Count);
    }

    [TestMethod]
    public void LinkedListRemoveItemAtIndex()
    {
        MyLinkedList<int> list = new();
        
        Assert.ThrowsException<ArgumentException>(() => list.RemoveAt(0));
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => list.RemoveAt(-1));
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => list.RemoveAt(99));
        
        list.Add(5);
        list.RemoveAt(0);
        Assert.AreEqual(0, list.Count);
        
        list.Add(10);
        list.Add(20);
        list.RemoveAt(0);
        list.RemoveAt(0);
        Assert.AreEqual(0, list.Count);
        
        list.Add(10);
        list.Add(20);
        list.RemoveAt(1);
        list.RemoveAt(0);
        Assert.AreEqual(0, list.Count);
    }

    [TestMethod]
    public void LinkedListInsertItemAtIndex()
    {
        MyLinkedList<int> list = new();

        Assert.ThrowsException<ArgumentOutOfRangeException>(() => list.InsertAt(-1, -100));
        
        list.InsertAt(0, 10);
        Assert.AreEqual(1, list.Count);
        Assert.AreEqual(10,list.Head.Value);
        
        list.InsertAt(0, 20);
        Assert.AreEqual(20,list.Head.Value);
        Assert.AreEqual(10,list.Head.Next.Value);
        Assert.AreEqual(2, list.Count);
        
        list.InsertAt(3, 30);
        Assert.AreEqual(3, list.Count);
        Assert.AreEqual(30,list.Head.Next.Next.Value);
        
        list.InsertAt(500, 500);
        Assert.AreEqual(4, list.Count);
        Assert.AreEqual(500,list.Head.Next.Next.Next.Value);
    }
}