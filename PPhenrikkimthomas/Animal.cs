namespace PPhenrikkimthomas;

public class Animal : Inventory
{
    private string _race, _colour;

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

    public Animal(string race, string colour, string itemName, string type, double price) : base(itemName, type, price)
    {
        Race = race;
        Colour = colour;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {_itemName} " +
                          $"Race: {_race} " +
                          $"Colour: {_colour} " + 
                          $"Type: {_type} " + 
                          $"Price: {_price}");
    }
}
