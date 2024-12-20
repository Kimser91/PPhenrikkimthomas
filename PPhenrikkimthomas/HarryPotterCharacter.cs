namespace PPhenrikkimthomas;

public class HarryPotterCharacter
{
    private string _name, _house;



    private List<Inventory> inventorie = new List<Inventory>();

    public HarryPotterCharacter()
    {
        
    }
    public HarryPotterCharacter(string name, string house)
    {
        _name = name;
        _house = house;
    }
    public void printInfo()
    {
        Console.WriteLine($"Name: {_name} " +
                          $"House: {_house}");

        foreach (Inventory inv in inventorie)
        {
            Console.WriteLine($"Item name: {inv.ItemName}\n" +
                              $"Price: {inv.Price}" +
                              $"Type: {inv.Type}");
        }
    }
}
