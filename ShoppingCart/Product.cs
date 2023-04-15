namespace ShoppingCart;

public class Product
{
    private string _name;
    private int _price;
    
    public Product(string name, int price)
    {
        _name = name;
        _price = price;
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