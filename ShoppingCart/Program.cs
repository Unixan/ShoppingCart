namespace ShoppingCart
{
    internal class Program
    {
        static void Main()
        {
            var Cart = new Cart();
            var A = new Product("A", 40);
            var B = new Product("B", 70);
            var C = new Product("C", 30);
            Cart.ShowCart();
            Cart.AddToCart(A, 1);
            Cart.ShowCart();
            Cart.AddToCart(B, 3);
            Cart.ShowCart();
            Cart.AddToCart(A, 4);
            Cart.ShowCart();


        }
    }
}