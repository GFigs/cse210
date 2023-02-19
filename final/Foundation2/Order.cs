public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }
    public double GetTotalAmount()
    {
        Double totalAmount = 0;
        foreach (Product product in _products)
        {
            totalAmount = totalAmount + product.GetTotalPrice();
        }
        if (_customer.isUSA())
        {
            totalAmount = totalAmount + 5;
        }
        else
        {
            totalAmount = totalAmount + 35;
        }
        return totalAmount;
    }

    public void PackingLabel()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine("");
            product.DisplayProductInfo();
        }
    }
    public void ShippingLabel()
    {
        Console.WriteLine("");
        _customer.DisplayCustomerInfo();

    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
}
