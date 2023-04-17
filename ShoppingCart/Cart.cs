namespace ShoppingCart;

public class Cart
{
    private List<OrderLine> _orders;
    private int _total => _orders.Sum(orderLine => orderLine.Total);
    public Cart()
    {
        _orders = new List<OrderLine>();
    }

    public void AddToCart(Product product, int count = 0)
    {
        var orderline = _orders.FirstOrDefault(o => o.Product == product);
        if (!_orders.Contains(orderline)) _orders.Add(new OrderLine(product, count));
        else
        {
            orderline.AddCount(count);
            if (orderline.Quantity <= 0) _orders.Remove(orderline);
        }
    }


    public void ShowCart()
    {
        if (_orders.Count == 0)
        {
            Console.WriteLine("Handlekurven er tom.");
            return;
        }
        Console.WriteLine("Handlekurv:");
        foreach (var order in _orders)
        {
            Console.WriteLine(order.GetOrderInfo());
        }

        Console.WriteLine($"Totalpris: {_total}");
    }

}
