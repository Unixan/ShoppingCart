namespace ShoppingCart;

public class OrderLine
{
    public Product Product { get; }
    public int Quantity { get; private set; }
    public int Total => Quantity * Product.Price;

    public OrderLine(Product product, int quantity = 0)
    {
        Product = product;
        Quantity = quantity;
    }

    public void AddCount(int count)
    {
        Quantity += count;
    }
    
    public string GetOrderInfo()
    {
        
        return $"{Quantity} stk. {Product.Name} a kr {Product.Price} = {Total}";
    }

}

