namespace ShoppingCart;

public class Cart
{
    private List<OrderLine> _orders;
    private int _total => _orders.Sum(orderLine => orderLine.GetTotal());
    public Cart()
    {
        _orders = new List<OrderLine>();
    }

    public void AddToCart(Product order, int count = 0)
    {
        foreach (var orderLine in _orders.Where(orderLine => orderLine.GetName() == order.GetName()))
        {
            orderLine.AddCount(count);
            if (orderLine.GetCount() > 0) return;
            _orders.Remove(orderLine);
            return;
        }

        _orders.Add(new OrderLine(order, count));
        
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
            var count = order.GetCount();
            var productName = order.GetName();
            var price = order.GetPrice();
            var orderLinePrice = order.GetTotal();
            Console.WriteLine($"  {count} stk. {productName} a kr {price} = {orderLinePrice}");
        }

        Console.WriteLine($"Totalpris: {_total}");
    }

}
