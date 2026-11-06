using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlantLib;

namespace PlantTests;

[TestClass]
public class FlowerTests
{
    [TestMethod]
    public void DetermineBloomDuration_Red_Returns14()
    {
        var flower = new Flower("Троянда", "Садова", "Клумба", "червоний");
        Assert.AreEqual(14, flower.DetermineBloomDuration());
    }

    [TestMethod]
    public void DetermineBloomDuration_Yellow_Returns10()
    {
        var flower = new Flower("Тюльпан", "Садова", "Клумба", "жовтий");
        Assert.AreEqual(10, flower.DetermineBloomDuration());
    }

    [TestMethod]
    public void DetermineBloomDuration_OtherColor_Returns7()
    {
        var flower = new Flower("Фіалка", "Кімнатна", "Вікно", "синій");
        Assert.AreEqual(7, flower.DetermineBloomDuration());
    }

    [TestMethod]
    public void DetermineBloomDuration_UpperCase_Returns14()
    {
        var flower = new Flower("Троянда", "Садова", "Клумба", "Червоний");
        Assert.AreEqual(14, flower.DetermineBloomDuration());
    }

    [TestMethod]
    public void Water_ReturnsMessageWithName()
    {
        var flower = new Flower("Троянда", "Садова", "Клумба", "червоний");
        Assert.AreEqual("Троянда полито", flower.Water());
    }

    [TestMethod]
    public void GetInfo_ContainsNameAndColor()
    {
        var flower = new Flower("Троянда", "Садова", "Клумба", "червоний");
        string info = flower.GetInfo();
        Assert.IsTrue(info.Contains("Троянда"));
        Assert.IsTrue(info.Contains("червоний"));
    }
}
