// See https://aka.ms/new-console-template for more information

public interface IGeoObject
{
    string GetInfo();
}

class River : IGeoObject
{
    
    private readonly int _x;
    private readonly int _y;
    private readonly string _name;
    private readonly string _description;
    private readonly int _speed;
    private readonly int _lenght;
    
    public River(int x, int y, string name, string description, int speed, int lenght)
    {
        _x = x; 
        _y = y;
        _name = name;
        _description = description;
        _speed = speed;
        _lenght = lenght;
    }
    
    
    public string GetInfo()
    {
        return _x + ", " + _y + " " + _name + " " + _description + " " + _speed + "cm/s " + _lenght + "km";
    }
}

class Mountain : IGeoObject
{
    
    private readonly int _x;
    private readonly int _y;
    private readonly string _name;
    private readonly string _description;
    private readonly string _highestPoint;
    
    public string GetInfo()
    {
        return _x + ", " + _y + " " + _name + " " + _description + " " + _highestPoint;
    }
    
    public Mountain(int x, int y, string name, string description, string highestPoint)
    {
        _x = x; 
        _y = y;
        _name = name;
        _description = description;
        _highestPoint = highestPoint;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Mountain a = new Mountain(105, 256, "AA", "none", "asd");
        River b = new River(1366, 245, "da", "none", 64, 186);
        Console.WriteLine(a.GetInfo());
        Console.WriteLine(b.GetInfo());
        Console.ReadKey();
    }
}

