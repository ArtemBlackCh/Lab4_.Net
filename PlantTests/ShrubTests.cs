using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlantLib;

namespace PlantTests;

[TestClass]
public class ShrubTests
{
    [TestMethod]
    public void DetermineBloomDuration_HeightAbove100_Returns21()
    {
        var shrub = new Shrub("Бузок", "Декоративний", "Сад", 150);
        Assert.AreEqual(21, shrub.DetermineBloomDuration());
    }

    [TestMethod]
    public void DetermineBloomDuration_Height100_Returns12()
    {
        var shrub = new Shrub("Жасмин", "Декоративний", "Сад", 100);
        Assert.AreEqual(12, shrub.DetermineBloomDuration());
    }

    [TestMethod]
    public void DetermineBloomDuration_LowHeight_Returns12()
    {
        var shrub = new Shrub("Лаванда", "Декоративний", "Клумба", 50);
        Assert.AreEqual(12, shrub.DetermineBloomDuration());
    }

    [TestMethod]
    public void Water_ReturnsMessageWithName()
    {
        var shrub = new Shrub("Бузок", "Декоративний", "Сад", 150);
        Assert.AreEqual("Бузок полито", shrub.Water());
    }

    [TestMethod]
    public void PlantIt_ReturnsMessageWithPlace()
    {
        var shrub = new Shrub("Бузок", "Декоративний", "Сад", 150);
        Assert.AreEqual("Бузок посаджено, місце: Сад", shrub.PlantIt());
    }

    [TestMethod]
    public void GetInfo_ContainsNameAndHeight()
    {
        var shrub = new Shrub("Бузок", "Декоративний", "Сад", 150);
        string info = shrub.GetInfo();
        Assert.IsTrue(info.Contains("Бузок"));
        Assert.IsTrue(info.Contains("150"));
    }
}
