using System.Threading.Channels;

namespace PPhenrikkimthomas;

public class Shop
{
    private List<Inventory> shopItems = new List<Inventory> {
        new Animal("Cat","green","Per","Pet",200000),
        new Animal("Owl","white","Fugl","Pet", 300000),
        new Animal("Rat","Gray","Råtti","Pet", 12),
        new Wand("Harry potter wand","wand",400000,60000,3000),
        new Wand("Pheonix Stav","wand", 30000, 70000, 20000),
        new Wand("Troll Stav","wand",22,44,50),
    };

    public void ShopMenu(HarryPotterCharacter Harry)
    {
        Console.WriteLine("Welcome to the shop");
        Console.WriteLine("1. buy pet");
        Console.WriteLine("2. buy wand");
        string input = Console.ReadLine();

        foreach (var item in shopItems)
        {
            if (item is Animal animal && input == "1")
            {
                animal.PrintInfo();
            }
            else if (item is Wand wand && input == "2")
            {
                wand.PrintInfo();
            }
        }

         string choise = "";
        Console.WriteLine("Choose by Name");
        choise = Console.ReadLine();

        Harry.inventorie.Add(shopItems.Find(s => s.ItemName == choise)); 
    }


}
