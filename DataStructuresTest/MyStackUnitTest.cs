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
            MyStack<int> temp = new(0);
        });
        Assert.ThrowsException<ArgumentException>(() =>
        {
            MyStack<int> temp = new(-1);
        });
    }
    
    [TestMethod]
    public void Push()
    {
        MyStack<int> stack = new(1);
        stack.Push(5);
        Assert.AreEqual(1, stack.Count);

        Assert.ThrowsException<ArgumentException>(() => stack.Push(5));
    }
}