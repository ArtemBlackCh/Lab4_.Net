using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlantLib;

namespace PlantTests;

[TestClass]
public class TreeTests
{
    [TestMethod]
    public void CalculateLeavesCount_Age10_Returns10000()
    {
        var tree = new Tree("Дуб", "Листяне", "Парк", 10);
        Assert.AreEqual(10000, tree.CalculateLeavesCount());
    }

    [TestMethod]
    public void CalculateLeavesCount_Age0_ReturnsZero()
    {
        var tree = new Tree("Саджанець", "Листяне", "Парк", 0);
        Assert.AreEqual(0, tree.CalculateLeavesCount());
    }

    [TestMethod]
    public void Water_ReturnsMessageWithName()
    {
        var tree = new Tree("Дуб", "Листяне", "Парк", 10);
        Assert.AreEqual("Дуб полито", tree.Water());
    }

    [TestMethod]
    public void PlantIt_ReturnsMessageWithPlace()
    {
        var tree = new Tree("Дуб", "Листяне", "Парк", 10);
        Assert.AreEqual("Дуб посаджено, місце: Парк", tree.PlantIt());
    }

    [TestMethod]
    public void GetInfo_ContainsNameAndAge()
    {
        var tree = new Tree("Дуб", "Листяне", "Парк", 10);
        string info = tree.GetInfo();
        Assert.IsTrue(info.Contains("Дуб"));
        Assert.IsTrue(info.Contains("10"));
    }
}
