using MyArrayListLibrary;

namespace MyArrayListUnitTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void ArrayListSize0()
    {
        MyArrayList arrayList = new MyArrayList();
        Assert.AreEqual(0, arrayList.Count);
    }

    [TestMethod]
    public void ArrayListAddItem()
    {
        MyArrayList arrayList = new MyArrayList();
        Assert.IsTrue(arrayList.Add("a"));
    }
    
    [TestMethod]
    public void ArrayListAddItems()
    {
        MyArrayList arrayList = new MyArrayList();
        Assert.IsTrue(arrayList.Add("a"));
        Assert.IsTrue(arrayList.Add("b"));
        Assert.IsTrue(arrayList.Add("c"));
        Assert.IsTrue(arrayList.Add("d"));
    }
    
    [TestMethod]
    public void ArrayListCorrectSize()
    {
        MyArrayList arrayList = new MyArrayList();
        arrayList.Add("a");
        arrayList.Add("b");
        arrayList.Add("c");
        arrayList.Add("d");
        arrayList.Add("e");
        Assert.AreEqual(5, arrayList.Count);
    }
    
    [TestMethod]
    public void ArrayListRemoveItem()
    {
        MyArrayList arrayList = new MyArrayList();
        arrayList.Add("a");
        Assert.IsTrue(arrayList.Remove("a"));
    }
    
    [TestMethod]
    public void ArrayListRemoveNonExistentItem()
    {
        MyArrayList arrayList = new MyArrayList();
        arrayList.Add("a");
        Assert.IsFalse(arrayList.Remove("b"));
    }
    
    [TestMethod]
    public void ArrayListClear()
    {
        MyArrayList arrayList = new MyArrayList();
        arrayList.Add("a");
        arrayList.Add("a");
        arrayList.Add("a");
        arrayList.Add("a");
        arrayList.Add("a");
        arrayList.Clear();
        Assert.IsTrue(arrayList.IsEmpty);
        Assert.AreEqual(0, arrayList.Count);
    }
    
    [TestMethod]
    public void ArrayListIndexOfItem()
    {
        MyArrayList arrayList = new MyArrayList();
        arrayList.Add("a");
        Assert.AreEqual(0, arrayList.IndexOf("a"));
    }
    
    [TestMethod]
    public void ArrayListIndexOfNonExistentItem()
    {
        MyArrayList arrayList = new MyArrayList();
        arrayList.Add("a");
        Assert.AreEqual(-1, arrayList.IndexOf("b"));
    }
    
    [TestMethod]
    public void ArrayListToArray()
    {
        MyArrayList arrayList = new MyArrayList();
        arrayList.Add("a");
        arrayList.Add("a");
        arrayList.Add("a");

        for (int i = 0; i < arrayList.Count; i++) Assert.AreEqual("a", arrayList[i]);
    }
    
    [TestMethod]
    public void ArrayListInsertToIndex()
    {
        MyArrayList arrayList = new MyArrayList();
        arrayList.Add("a");
        arrayList.Add("a");
        arrayList.Add("a");
        arrayList[2] = "b";
        Assert.AreEqual("b", arrayList[2]);
    }
    
    [TestMethod]
    public void ArrayListGetItemFromIndex()
    {
        MyArrayList arrayList = new MyArrayList();
        arrayList.Add("a");
        arrayList.Add("b");
        arrayList.Add("c");
        Assert.AreEqual("c", arrayList[2]);
    }
    
    [TestMethod]
    public void ArrayListGetNonExistentItemFromIndex()
    {
        MyArrayList arrayList = new MyArrayList();
        arrayList.Add("a");
        arrayList.Add("b");
        arrayList.Add("c");
        Assert.ThrowsException<IndexOutOfRangeException>(() => arrayList[5]);
    }
}