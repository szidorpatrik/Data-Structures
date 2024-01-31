using DataStructuresLibrary;

namespace DataStructuresTest;

[TestClass]
public class MyStackUnitTest
{
    [TestMethod]
    public void Ctor()
    {
        MyStack<int> stack = new(10);
        Assert.AreEqual(0, stack.Count);
        Assert.AreEqual(10, stack.Size);

        Assert.ThrowsException<ArgumentException>(() =>
        {
            MyStack<int> _ = new(0);
        });
        Assert.ThrowsException<ArgumentException>(() =>
        {
            MyStack<int> _ = new(-1);
        });
    }

    [TestMethod]
    public void OneLengthPushOneItem()
    {
        MyStack<int> stack = new(1);
        stack.Push(5);
        Assert.AreEqual(1, stack.Count);
    }
    
    [TestMethod]
    public void OneLengthPushTwoItems()
    {
        MyStack<int> stack = new(1);
        stack.Push(5);
        Assert.ThrowsException<ArgumentException>(() => stack.Push(5));
    }

    [TestMethod]
    public void Pop()
    {
        MyStack<int> stack = new(2);

        stack.Push(5);
        Assert.AreEqual(1, stack.Count);

        stack.Push(3);
        Assert.AreEqual(2, stack.Count);
        
        Assert.AreEqual(3, stack.Pop());
        Assert.AreEqual(5, stack.Pop());
    }
    
    [TestMethod]
    public void PopFromEmptyStack()
    {
        MyStack<int> stack = new(1);
        Assert.ThrowsException<ArgumentException>(() => stack.Pop());
    }

    [TestMethod]
    public void ToArray()
    {
        MyStack<int> stack = new(2);
        stack.Push(5);
        stack.Push(3);
        Assert.IsTrue(stack.ToArray().SequenceEqual(new [] { 5, 3 }));
    }
    
    [TestMethod]
    public void ToStringTwoItems()
    {
        MyStack<int> stack = new(2);
        stack.Push(5);
        stack.Push(3);
        Assert.AreEqual("[5, 3]", stack.ToString());
    }
    
    [TestMethod]
    public void ToStringZeroItems()
    {
        MyStack<int> stack = new(2);
        Assert.AreEqual("[]", stack.ToString());
    }
}