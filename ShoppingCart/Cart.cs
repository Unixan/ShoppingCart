namespace ShoppingCart;

public class Cart
{
    private List<Product> _products;

    public Cart()
    {
        _products = new List<Product>();
    }

    public void AddToCart(Product product, int count)
    {
        if (_products.Contains(product))
        {
            var orderLineIndex = _products.IndexOf(product);
            _products[orderLineIndex].AddCount(count);
        }
        else
        {
            _products.Add(product);
            var orderLineIndex = _products.IndexOf(product);
            _products[orderLineIndex].AddCount(count);
        }
    }

    public void ShowCart()
    {
        if (_products.Count == 0)
        {
            Console.WriteLine("Handlekurven er tom.");
            return;
        }
        Console.WriteLine("Handlekurv:");
        var totalPrice = 0;
        for (int i = 0; i < _products.Count; i++)
        {
            var count = _products[i].GetCount();
            var productName = _products[i].GetName();
            var price = _products[i].GetPrice();
            var orderLinePrice = price * count;
            Console.WriteLine($"  {count} stk. {productName} a kr {price} = {orderLinePrice}");
            totalPrice += orderLinePrice;
        }

        Console.WriteLine($"Totalpris: {totalPrice}");
    }
}