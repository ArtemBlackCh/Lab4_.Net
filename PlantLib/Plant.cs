namespace PlantLib;

public abstract class Plant : IWaterable, IPlantable
{
    public string Name { get; }
    public string Type { get; }
    public string GrowingPlace { get; }

    protected Plant(string name, string type, string growingPlace)
    {
        Name = name;
        Type = type;
        GrowingPlace = growingPlace;
    }

    public virtual string Water()
    {
        return $"{Name} полито";
    }

    public virtual string PlantIt()
    {
        return $"{Name} посаджено, місце: {GrowingPlace}";
    }

    public abstract string GetInfo();

    public override string ToString()
    {
        return GetInfo();
    }
}
