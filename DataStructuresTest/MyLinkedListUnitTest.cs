using DataStructuresLibrary;

namespace MyLinkedListUnitTest;

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
    
    
}