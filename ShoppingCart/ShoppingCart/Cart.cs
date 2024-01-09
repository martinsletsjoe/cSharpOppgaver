namespace ShoppingCart;

public class Cart
{
    public List<Product> Products;
    public int Counts;

    public Cart(List<Product> products)
    {
        Counts = 0;
        Products = new List<Product>(products);
    }

    public void CountProducts()
    {
        foreach (var product in Products)
        {
            Counts++;
        }
    }
}