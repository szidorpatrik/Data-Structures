using MyArrayListLibrary;

namespace MyArrayListUnitTest;

[TestClass]
public class SearchUnitTest
{
    private int[] _arraySorted = new[] { 1, 1, 2, 3, 7, 7, 7, 16, 20, 23, 44, 200, 2000 };
    [TestMethod]
    public void BinarySearhInArrayGivesMinusOneWhenItemNotFoundInArray()
    {
        Assert.AreEqual(-1, Search.BinarySearch(_arraySorted, 999));
    }
    [TestMethod]
    public void BinarySearhInArrayWhenItemFoundInArray()
    {
        Assert.AreEqual(0, Search.BinarySearch(_arraySorted, 1));
    }
}