using MyArrayListLibrary;

namespace MyArrayListUnitTest;

[TestClass]
public class UnitTest1
{
    MyArrayList<string> _arrayListStr = new();
    MyArrayList<int> _arrayListInt = new();
    MyArrayList<bool> _arrayListBool = new();
    [TestMethod]
    public void ArrayListSize0()
    {
        _arrayListStr = new();
        Assert.AreEqual(0, _arrayListStr.Count);
    }

    [TestMethod]
    public void ArrayListAddItem()
    {
        _arrayListStr = new();
        Assert.IsTrue(_arrayListStr.Add("a"));
    }
    
    [TestMethod]
    public void ArrayListAddItems()
    {
        _arrayListStr = new();
        Assert.IsTrue(_arrayListStr.Add("a"));
        Assert.IsTrue(_arrayListStr.Add("b"));
        Assert.IsTrue(_arrayListStr.Add("c"));
        Assert.IsTrue(_arrayListStr.Add("d"));
    }
    
    [TestMethod]
    public void ArrayListCorrectSize()
    {
        _arrayListStr = new();
        _arrayListStr.Add("a");
        _arrayListStr.Add("b");
        _arrayListStr.Add("c");
        _arrayListStr.Add("d");
        _arrayListStr.Add("e");
        Assert.AreEqual(5, _arrayListStr.Count);
    }
    
    [TestMethod]
    public void ArrayListRemoveItem()
    {
        _arrayListStr = new();
        _arrayListStr.Add("a");
        Assert.IsTrue(_arrayListStr.Remove("a"));
    }
    
    [TestMethod]
    public void ArrayListRemoveNonExistentItem()
    {
        _arrayListStr = new();
        _arrayListStr.Add("a");
        Assert.IsFalse(_arrayListStr.Remove("b"));
    }
    
    [TestMethod]
    public void ArrayListClear()
    {
        _arrayListStr = new();
        _arrayListStr.Add("a");
        _arrayListStr.Add("a");
        _arrayListStr.Add("a");
        _arrayListStr.Add("a");
        _arrayListStr.Add("a");
        _arrayListStr.Clear();
        Assert.IsTrue(_arrayListStr.IsEmpty);
        Assert.AreEqual(0, _arrayListStr.Count);
    }
    
    [TestMethod]
    public void ArrayListIndexOfItem()
    {
        _arrayListStr = new();
        _arrayListStr.Add("a");
        Assert.AreEqual(0, _arrayListStr.IndexOf("a"));
    }
    
    [TestMethod]
    public void ArrayListIndexOfNonExistentItem()
    {
        _arrayListStr = new();
        _arrayListStr.Add("a");
        Assert.AreEqual(-1, _arrayListStr.IndexOf("b"));
    }
    
    [TestMethod]
    public void ArrayListToArray()
    {
        _arrayListStr = new();
        _arrayListStr.Add("a");
        _arrayListStr.Add("a");
        _arrayListStr.Add("a");

        for (int i = 0; i < _arrayListStr.Count; i++) Assert.AreEqual("a", _arrayListStr[i]);
    }
    
    [TestMethod]
    public void ArrayListInsertToIndex()
    {
        _arrayListStr = new();
        _arrayListStr.Add("a");
        _arrayListStr.Add("a");
        _arrayListStr.Add("a");
        _arrayListStr[2] = "b";
        Assert.AreEqual("b", _arrayListStr[2]);
    }
    
    [TestMethod]
    public void ArrayListGetItemFromIndex()
    {
        _arrayListStr = new();
        _arrayListStr.Add("a");
        _arrayListStr.Add("b");
        _arrayListStr.Add("c");
        Assert.AreEqual("c", _arrayListStr[2]);
    }
    
    [TestMethod]
    public void ArrayListGetNonExistentItemFromIndex()
    {
        _arrayListStr = new();
        _arrayListStr.Add("a");
        _arrayListStr.Add("b");
        _arrayListStr.Add("c");
        Assert.ThrowsException<IndexOutOfRangeException>(() => _arrayListStr[5]);
    }
}