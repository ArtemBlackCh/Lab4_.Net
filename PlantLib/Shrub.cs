namespace PlantLib;

public class Shrub : Plant, IBloomable
{
    public int Height { get; }

    public Shrub(string name, string type, string growingPlace, int height)
        : base(name, type, growingPlace)
    {
        Height = height;
    }

    public int DetermineBloomDuration()
    {
        return Height > 100 ? 21 : 12;
    }

    public override string GetInfo()
    {
        return $"Кущ: {Name}, тип: {Type}, місце: {GrowingPlace}, висота: {Height}, цвітіння: {DetermineBloomDuration()} дн.";
    }
}
