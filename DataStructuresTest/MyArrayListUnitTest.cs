using DataStructuresLibrary;

namespace MyArrayListUnitTest;

[TestClass]
public class MyArrayListUnitTest
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
        _arrayListBool = new();
        _arrayListInt = new();
        
        Assert.IsTrue(_arrayListStr.Add("a"));
        Assert.IsTrue(_arrayListBool.Add(true));
        Assert.IsTrue(_arrayListInt.Add(0));
    }
    
    [TestMethod]
    public void ArrayListAddItems()
    {
        _arrayListStr = new();
        _arrayListBool = new();
        _arrayListInt = new();
        
        Assert.IsTrue(_arrayListStr.Add("a"));
        Assert.IsTrue(_arrayListStr.Add("b"));
        Assert.IsTrue(_arrayListStr.Add("c"));
        Assert.IsTrue(_arrayListStr.Add("d"));
        
        Assert.IsTrue(_arrayListBool.Add(true));
        Assert.IsTrue(_arrayListBool.Add(true));
        Assert.IsTrue(_arrayListBool.Add(true));
        Assert.IsTrue(_arrayListBool.Add(false));

        Assert.IsTrue(_arrayListInt.Add(0));
        Assert.IsTrue(_arrayListInt.Add(2));
        Assert.IsTrue(_arrayListInt.Add(3));
        Assert.IsTrue(_arrayListInt.Add(4));
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
        _arrayListStr.Add("e");
        Assert.AreEqual(6, _arrayListStr.Count);
        
        _arrayListInt = new();
        for (int i = 0; i < 12; i++) _arrayListInt.Add(i);
        Assert.AreEqual(12, _arrayListInt.Count);

        _arrayListBool = new();
        for (int i = 0; i < 12; i++) _arrayListBool.Add(i % 2 == 0);
        Assert.AreEqual(12, _arrayListBool.Count);
    }
    
    [TestMethod]
    public void ArrayListRemoveItem()
    {
        _arrayListStr = new();
        _arrayListStr.Add("a");
        _arrayListStr.Add("b");
        _arrayListStr.Add("c");
        Assert.IsTrue(_arrayListStr.Remove("a"));
        Assert.IsTrue(_arrayListStr.Remove("c"));
        Assert.AreEqual(1, _arrayListStr.Count);
        
        _arrayListInt = new();
        for (int i = 0; i < 12; i++) _arrayListInt.Add(i);
        Assert.IsTrue(_arrayListInt.Remove(0));
        Assert.IsTrue(_arrayListInt.Remove(2));
        Assert.IsTrue(_arrayListInt.Remove(9));
        Assert.AreEqual(9, _arrayListInt.Count);

        _arrayListBool = new();
        for (int i = 0; i < 12; i++) _arrayListBool.Add(i % 2 == 0);
        Assert.IsTrue(_arrayListBool.Remove(true));
        Assert.IsTrue(_arrayListBool.Remove(false));
        Assert.AreEqual(10, _arrayListBool.Count);
    }
    
    [TestMethod]
    public void ArrayListRemoveNonExistentItem()
    {
        _arrayListStr = new();
        _arrayListStr.Add("a");
        Assert.IsFalse(_arrayListStr.Remove("b"));
        
        _arrayListInt = new();
        _arrayListInt.Add(1);
        Assert.IsFalse(_arrayListInt.Remove(0));
        
        _arrayListBool = new();
        _arrayListBool.Add(false);
        Assert.IsFalse(_arrayListBool.Remove(true));
    }
    
    [TestMethod]
    public void ArrayListClear()
    {
        _arrayListStr = new();
        for (int i = 64; i < 77; i++) _arrayListStr.Add(((char)i).ToString());
        _arrayListStr.Clear();
        Assert.IsTrue(_arrayListStr.IsEmpty);
        Assert.AreEqual(0, _arrayListStr.Count);
        
        _arrayListInt = new();
        for (int i = 0; i < 12; i++) _arrayListInt.Add(i);
        _arrayListInt.Clear();
        Assert.IsTrue(_arrayListInt.IsEmpty);
        Assert.AreEqual(0, _arrayListInt.Count);
        
        _arrayListBool = new();
        for (int i = 0; i < 12; i++) _arrayListBool.Add(i % 2 == 0);
        _arrayListBool.Clear();
        Assert.IsTrue(_arrayListBool.IsEmpty);
        Assert.AreEqual(0, _arrayListBool.Count);
    }
    
    [TestMethod]
    public void ArrayListIndexOfItem()
    {
        _arrayListStr = new();
        _arrayListStr.Add("a");
        Assert.AreEqual(0, _arrayListStr.IndexOf("a"));
        
        _arrayListInt = new();
        _arrayListInt.Add(0);
        Assert.AreEqual(0, _arrayListInt.IndexOf(0));
        
        _arrayListBool = new();
        _arrayListBool.Add(true);
        Assert.AreEqual(0, _arrayListBool.IndexOf(true));
    }
    
    [TestMethod]
    public void ArrayListIndexOfNonExistentItem()
    {
        _arrayListStr = new();
        _arrayListStr.Add("a");
        Assert.AreEqual(-1, _arrayListStr.IndexOf("b"));
        
        _arrayListInt = new();
        _arrayListInt.Add(0);
        Assert.AreEqual(-1, _arrayListInt.IndexOf(1));
        
        _arrayListBool = new();
        _arrayListBool.Add(true);
        Assert.AreEqual(-1, _arrayListBool.IndexOf(false));
    }
    
    [TestMethod]
    public void ArrayListToArray()
    {
        _arrayListStr = new();
        _arrayListStr.Add("a");
        _arrayListStr.Add("a");
        _arrayListStr.Add("a");
        for (int i = 0; i < _arrayListStr.Count; i++) Assert.AreEqual("a", _arrayListStr[i]);

        _arrayListInt = new();
        _arrayListInt.Add(1);
        _arrayListInt.Add(2);
        _arrayListInt.Add(3);
        for (int i = 0; i < _arrayListInt.Count; i++) Assert.AreEqual(i + 1, _arrayListInt[i]);
    
        _arrayListBool = new();
        _arrayListBool.Add(true);
        _arrayListBool.Add(true);
        _arrayListBool.Add(true);
        for (int i = 0; i < _arrayListBool.Count; i++) Assert.AreEqual(true, _arrayListBool[i]);
    }
    
    [TestMethod]
    public void ArrayListInsertToIndex()
    {
        _arrayListStr = new();
        _arrayListStr.Add("a");
        _arrayListStr.Add("a");
        _arrayListStr[1] = "b";
        Assert.AreEqual("b", _arrayListStr[1]);
        
        _arrayListInt = new();
        _arrayListInt.Add(0);
        _arrayListInt.Add(1);
        _arrayListInt[1] = 2;
        Assert.AreEqual(2, _arrayListInt[1]);
        
        _arrayListBool = new();
        _arrayListBool.Add(true);
        _arrayListBool.Add(true);
        _arrayListBool[1] = false;
        Assert.AreEqual(false, _arrayListBool[1]);
    }
    
    [TestMethod]
    public void ArrayListGetItemFromIndex()
    {
        _arrayListStr = new();
        _arrayListStr.Add("a");
        _arrayListStr.Add("b");
        _arrayListStr.Add("c");
        Assert.AreEqual("c", _arrayListStr[2]);
        
        _arrayListInt = new();
        _arrayListInt.Add(0);
        _arrayListInt.Add(1);
        _arrayListInt.Add(2);
        Assert.AreEqual(2, _arrayListInt[2]);
        
        _arrayListBool = new();
        _arrayListBool.Add(true);
        _arrayListBool.Add(true);
        _arrayListBool.Add(false);
        Assert.AreEqual(false, _arrayListBool[2]);
    }
    
    [TestMethod]
    public void ArrayListGetNonExistentItemFromIndex()
    {
        _arrayListStr = new();
        _arrayListStr.Add("a");
        _arrayListStr.Add("b");
        _arrayListStr.Add("c");
        Assert.ThrowsException<IndexOutOfRangeException>(() => _arrayListStr[5]);
        
        _arrayListInt = new();
        _arrayListInt.Add(0);
        _arrayListInt.Add(1);
        _arrayListInt.Add(2);
        Assert.ThrowsException<IndexOutOfRangeException>(() => _arrayListInt[5]);
        
        _arrayListBool = new();
        _arrayListBool.Add(true);
        _arrayListBool.Add(true);
        _arrayListBool.Add(false);
        Assert.ThrowsException<IndexOutOfRangeException>(() => _arrayListStr[5]);
    }
}