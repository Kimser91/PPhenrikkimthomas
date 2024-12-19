namespace PPhenrikkimthomas;

public class Inventory
{
    protected string _itemName, _type;
    protected double _price;

    public string ItemName
    {
        get { return _itemName; }
        set { _itemName = value; }
    }

    public string Type
    {
        get { return _type; }
        set { _type = value; }
    }

    public double Price
    {
        get { return _price; }
        set { _price = value; }
    }

    public Inventory(string itemName, string type, double price)
    {
        this._itemName = itemName;
        this._type = type;
        this._price = price;
    }
}
