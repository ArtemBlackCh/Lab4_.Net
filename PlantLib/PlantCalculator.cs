namespace PlantLib;

public static class PlantCalculator
{
    public static double GetAverageTreeAge(IEnumerable<Plant> plants)
    {
        var trees = plants.OfType<Tree>().ToList();
        if (trees.Count == 0)
        {
            return 0;
        }
        return trees.Average(t => t.Age);
    }

    public static int GetMaxBloomDuration(IEnumerable<Plant> plants)
    {
        var bloomables = plants.OfType<IBloomable>().ToList();
        if (bloomables.Count == 0)
        {
            return 0;
        }
        return bloomables.Max(b => b.DetermineBloomDuration());
    }
}
