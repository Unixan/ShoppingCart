namespace ShoppingCart
{
    internal class Program
    {
        static void Main()
        {
            var Cart1 = new Cart();
            var Cart2 = new Cart();
            var A = new Product("A", 40);
            var B = new Product("B", 70);
            var C = new Product("C", 30);
            Console.WriteLine("Kurv 1:");
            Cart1.ShowCart();
            Cart1.AddToCart(A, 1);
            Cart1.ShowCart();
            Cart1.AddToCart(B, 3);
            Cart1.ShowCart();
            Cart1.AddToCart(A, 4);
            Cart1.ShowCart();
            Cart1.AddToCart(A, -5);
            Cart1.ShowCart();
            Console.WriteLine();
            Console.WriteLine("Kurv 2:");
            Cart2.ShowCart();
            Cart2.AddToCart(A, 3);
            Cart2.ShowCart();
            Cart2.AddToCart(B, 5);
            Cart2.ShowCart();
            Cart2.AddToCart(C, 2);
            Cart2.ShowCart();
            Cart2.AddToCart(B, 2);
            Cart2.ShowCart();


        }
    }
}