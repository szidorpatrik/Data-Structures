using DataStructuresLibrary;

namespace DataStructuresTest;

[TestClass]
public class MySetUnitTest
{
    private MySet<int> _set;

    [TestInitialize]
    public void InitializeTest()
    {
        _set = new MySet<int>();
    }

    [TestMethod]
    public void Ctor()
    {
        Assert.AreEqual(0, _set.Count);
    }

    [TestMethod]
    public void Length()
    {
        _set.Add(0);
        Assert.AreEqual(1, _set.Count);

        _set.Add(1);
        Assert.AreEqual(2, _set.Count);

        _set.Add(-1);
        Assert.AreEqual(3, _set.Count);
    }

    [TestMethod]
    [DataRow(new[] { 1, 3 })]
    [DataRow(new[] { -1, 2, -3, 6 })]
    [DataRow(new[] { -99, -2, 4889 })]
    [DataRow(new[] { 0, 2, -3, 9, 8, 98, 897, -545, 18, -78 })]
    public void AfterAddingUniqueValuesLengthIsCorrect(int[] items)
    {
        foreach (var item in items)
            _set.Add(item);

        Assert.AreEqual(items.Length, _set.Count);
    }

    [TestMethod]
    [DataRow(1, 10)]
    [DataRow(2, 20)]
    [DataRow(0, -1)]
    public void SameValueCanNotBeAdded(int val1, int val2)
    {
        _set.Add(val1);
        Assert.AreEqual(1, _set.Count);

        _set.Add(val1);
        Assert.AreEqual(1, _set.Count);

        _set.Add(val2);
        Assert.AreEqual(2, _set.Count);

        _set.Add(val2);
        Assert.AreEqual(2, _set.Count);
    }

    [TestMethod]
    [DataRow(23)]
    [DataRow(454)]
    [DataRow(-187)]
    public void FindExistingValue(int value)
    {
        _set.Add(0);
        _set.Add(1);
        _set.Add(-1);
        _set.Add(value);

        Assert.AreEqual(true, _set.Exists(value));
    }

    [TestMethod]
    [DataRow(23)]
    [DataRow(454)]
    [DataRow(-187)]
    public void FindNotExistingValue(int value)
    {
        _set.Add(0);
        _set.Add(1);
        _set.Add(-1);

        Assert.AreEqual(false, _set.Exists(value));
    }
}