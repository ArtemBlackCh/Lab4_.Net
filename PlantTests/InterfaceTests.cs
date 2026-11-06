using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlantLib;

namespace PlantTests;

[TestClass]
public class InterfaceTests
{
    [TestMethod]
    public void IBloomable_Collection_ReturnsDurationsPolymorphically()
    {
        var items = new List<IBloomable>
        {
            new Flower("Троянда", "Садова", "Клумба", "червоний"),
            new Shrub("Бузок", "Декоративний", "Сад", 150)
        };
        Assert.AreEqual(14, items[0].DetermineBloomDuration());
        Assert.AreEqual(21, items[1].DetermineBloomDuration());
    }

    [TestMethod]
    public void IWaterable_Collection_WatersAllPlants()
    {
        var items = new List<IWaterable>
        {
            new Tree("Дуб", "Листяне", "Парк", 10),
            new Flower("Троянда", "Садова", "Клумба", "червоний"),
            new Shrub("Бузок", "Декоративний", "Сад", 150)
        };
        Assert.AreEqual("Дуб полито", items[0].Water());
        Assert.AreEqual("Троянда полито", items[1].Water());
        Assert.AreEqual("Бузок полито", items[2].Water());
    }

    [TestMethod]
    public void IPlantable_Collection_PlantsAllPlants()
    {
        var items = new List<IPlantable>
        {
            new Tree("Дуб", "Листяне", "Парк", 10),
            new Shrub("Бузок", "Декоративний", "Сад", 150)
        };
        Assert.AreEqual("Дуб посаджено, місце: Парк", items[0].PlantIt());
        Assert.AreEqual("Бузок посаджено, місце: Сад", items[1].PlantIt());
    }

    [TestMethod]
    public void Tree_IsNotBloomable()
    {
        Plant tree = new Tree("Дуб", "Листяне", "Парк", 10);
        Assert.IsFalse(tree is IBloomable);
    }
}
