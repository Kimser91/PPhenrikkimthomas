namespace PPhenrikkimthomas;

public class Menu
{
    HarryPotterCharacter Harry = new HarryPotterCharacter("Harry PottHead", "Gryffindork");
    Shop shop = new Shop();
    public Menu()
    {
        Main();
    }
    public void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome");
            Console.WriteLine("1. Character Info");
            Console.WriteLine("2. Shop");
            Console.WriteLine("3. Do Magic");
            Console.WriteLine("Q. Quit Program");
            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Harry.printInfo();
                    break;
                case "2":
                   shop.ShopMenu(Harry);
                    break;
                case "3":
                    Harry.DoSpell();
                    break;
                case "Q":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;

            }
        }

    }
}