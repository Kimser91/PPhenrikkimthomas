namespace PPhenrikkimthomas;

public class Wand : Inventory
{
    private double _magicPowe, _mana;

    public Wand(string itemName, string type, double price, double magicPower, double mana) : base(itemName, type, price)
    {
        this._magicPowe = magicPower;
        this._mana = mana;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Magic Power: {_magicPowe}\nMana: {_mana}");
    }
}
