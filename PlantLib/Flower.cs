namespace PlantLib;

public class Flower : Plant, IBloomable
{
    public string Color { get; }

    public Flower(string name, string type, string growingPlace, string color)
        : base(name, type, growingPlace)
    {
        Color = color;
    }

    public virtual int DetermineBloomDuration()
    {
        return Color.ToLowerInvariant() switch
        {
            "червоний" => 14,
            "жовтий" => 10,
            _ => 7
        };
    }

    public override string GetInfo()
    {
        return $"Квітка: {Name}, тип: {Type}, місце: {GrowingPlace}, колір: {Color}, цвітіння: {DetermineBloomDuration()} дн.";
    }
}
