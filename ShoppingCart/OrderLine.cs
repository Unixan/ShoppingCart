namespace ShoppingCart;

public class OrderLine
{
    private Product _product;
    private int _quantity;
    private int _total => _quantity * _product.GetPrice();

    public OrderLine(Product product, int quantity = 0)
    {
        _product = product;
        _quantity = quantity;
    }

    public void AddCount(int count)
    {
        _quantity += count;
    }

    public int GetCount()
    {
        return _quantity;
    }

    public string GetName()
    {
        return _product.GetName();
    }

    public int GetPrice()
    {
        return _product.GetPrice();
    }

    public int GetTotal()
    {
        return _total;
    }
    
}

