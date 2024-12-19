namespace PPhenrikkimthomas;

public class Animal : Inventory
{
    private string _name, _race, _colour;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Race
    {
        get { return _race; }
        set { _race = value; }
    }

    public string Colour
    {
        get { return _colour; }
        set { _colour = value; }
    }

    public Animal(string name, string race, string colour, string itemName, string type, double price) : base(itemName, type, price)
    {
        Name = name;
        Race = race;
        Colour = colour;
        Name = name;
        Race = race;
        Colour = colour;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {_name}" +
                          $"Race: {_race}" +
                          $"Colour: {_colour}");
    }
}
