using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlantLib;

namespace PlantTests;

[TestClass]
public class PlantCalculatorTests
{
    [TestMethod]
    public void GetAverageTreeAge_TwoTrees_ReturnsAverage()
    {
        var plants = new List<Plant>
        {
            new Tree("Дуб", "Листяне", "Парк", 10),
            new Tree("Сосна", "Хвойне", "Ліс", 20)
        };
        Assert.AreEqual(15.0, PlantCalculator.GetAverageTreeAge(plants), 0.001);
    }

    [TestMethod]
    public void GetAverageTreeAge_TreesAndFlowers_IgnoresFlowers()
    {
        var plants = new List<Plant>
        {
            new Tree("Дуб", "Листяне", "Парк", 10),
            new Flower("Троянда", "Садова", "Клумба", "червоний"),
            new Tree("Сосна", "Хвойне", "Ліс", 30)
        };
        Assert.AreEqual(20.0, PlantCalculator.GetAverageTreeAge(plants), 0.001);
    }

    [TestMethod]
    public void GetAverageTreeAge_OnlyFlowers_ReturnsZero()
    {
        var plants = new List<Plant>
        {
            new Flower("Троянда", "Садова", "Клумба", "червоний")
        };
        Assert.AreEqual(0.0, PlantCalculator.GetAverageTreeAge(plants), 0.001);
    }

    [TestMethod]
    public void GetAverageTreeAge_EmptyList_ReturnsZero()
    {
        var plants = new List<Plant>();
        Assert.AreEqual(0.0, PlantCalculator.GetAverageTreeAge(plants), 0.001);
    }

    [TestMethod]
    public void GetMaxBloomDuration_FlowerAndShrub_ReturnsMax()
    {
        var plants = new List<Plant>
        {
            new Tree("Дуб", "Листяне", "Парк", 10),
            new Flower("Троянда", "Садова", "Клумба", "червоний"),
            new Shrub("Бузок", "Декоративний", "Сад", 150)
        };
        Assert.AreEqual(21, PlantCalculator.GetMaxBloomDuration(plants));
    }

    [TestMethod]
    public void GetMaxBloomDuration_OnlyTrees_ReturnsZero()
    {
        var plants = new List<Plant>
        {
            new Tree("Дуб", "Листяне", "Парк", 10)
        };
        Assert.AreEqual(0, PlantCalculator.GetMaxBloomDuration(plants));
    }

    [TestMethod]
    public void GetMaxBloomDuration_EmptyList_ReturnsZero()
    {
        var plants = new List<Plant>();
        Assert.AreEqual(0, PlantCalculator.GetMaxBloomDuration(plants));
    }
}
