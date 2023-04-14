namespace ShoppingCart;

public class Product
{
    private string _name;
    private int _price;
    private int _count;

    public Product(string name, int price, int count = 0)
    {
        _name = name;
        _price = price;
        _count = count;
    }

    public void AddCount(int count)
    {
        _count += count;
    }

    public int GetCount()
    {
        return _count;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetPrice()
    {
        return _price;
    }
}