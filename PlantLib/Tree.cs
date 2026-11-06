namespace PlantLib;

public class Tree : Plant
{
    public int Age { get; }

    public Tree(string name, string type, string growingPlace, int age)
        : base(name, type, growingPlace)
    {
        Age = age;
    }

    public virtual int CalculateLeavesCount()
    {
        return Age * 1000;
    }

    public override string GetInfo()
    {
        return $"Дерево: {Name}, тип: {Type}, місце: {GrowingPlace}, вік: {Age}, листя: {CalculateLeavesCount()}";
    }
}
