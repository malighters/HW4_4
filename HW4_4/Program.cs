// See https://aka.ms/new-console-template for more information

abstract class GeoObject
{
    protected readonly int X;
    protected readonly int Y;
    protected readonly string Name;
    protected readonly string Description;


    public virtual string GetInfo()
    {
        return X + ", " + Y + " " + Name + " " + Description;
    }

    protected GeoObject(int x, int y, string name, string description)
    {
        X = x; 
        Y = y;
        Name = name;
        Description = description;
    }

}

class River: GeoObject
{
    private readonly int _speed;
    private readonly int _lenght;

    public River(int x, int y, string name, string description, int speed, int lenght) 
        : base(x, y, name, description)
    {
        _speed = speed;
        _lenght = lenght;
    }

    public override string GetInfo()
    {
        return X + ", " + Y + " " + Name + " " + Description + " " + _speed + "cm/s " + _lenght + "km";
    }
}

class Mountain: GeoObject
{
    private readonly string _highestPoint;

    public Mountain(int x, int y, string name, string description, string highestPoint)
        : base(x, y, name, description)
    {
        _highestPoint = highestPoint;
    } 
    public override string GetInfo()
    {
        return X + ", " + Y + " " + Name + " " + Description + " " + _highestPoint;
    }
}



class Program
{
    public static void Main(string[] args)
    {
        GeoObject a = new Mountain(105, 256, "AA", "none", "asd");
        GeoObject b = new River(1366, 245, "da", "none", 64, 186);
        Console.WriteLine(a.GetInfo());
        Console.WriteLine(b.GetInfo());
    }
}