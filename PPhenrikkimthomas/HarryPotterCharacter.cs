namespace PPhenrikkimthomas;

public class HarryPotterCharacter
{
    private string _name, _house;



    public List<Inventory> inventorie = new List<Inventory>();

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
        Console.WriteLine();
        PrintInventory();
    }
    public void DoSpell()
    {
        Console.WriteLine("Write the correct incantation!");
        Console.WriteLine("Spells: Vingardium Leviosa and Hookus Pookus");
        Console.WriteLine("Or write Back to go BACK ");
        var input = Console.ReadLine();
        switch (input)
        {
            case "Hookus Pookus":
                Console.WriteLine("Fireworks shot up into the air! Yay!");
                break;
            case "Vingardium Leviosa":
                Console.WriteLine("You made a feather float...congrats.");
                break;
            case "Back":
                return;
            default:
                Console.WriteLine("That's not a spell, stupid.");
                break;

        }
    }
    public void PrintInventory()
    {
        foreach (Inventory inv in inventorie) { Console.WriteLine(inv.ItemName); }
    }
}
