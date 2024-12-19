namespace PPhenrikkimthomas;

public class HarryPotterCharacter
{
    private string _name, _house;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string House
    {
        get { return _house; }
        set { _house = value; }
    }

    private List<Inventory> inventorie = new List<Inventory>();

    public void printInfo()
    {
        Console.WriteLine($"Name: {_name}\n" +
                          $"House: {_house}\n");

        foreach (Inventory inv in inventorie)
        {
            Console.WriteLine($"Item name: {inv.ItemName}\n" +
                              $"Price: {inv.Price}" +
                              $"Type: {inv.Type}");
        }
    }
}
