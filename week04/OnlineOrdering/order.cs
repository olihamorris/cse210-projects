using System.Collections.Generic;

public class Order
{
    public string CustomerName { get; set; }
    public int OrderId { get; set; }
    public List<Product> Products { get; private set; }

    public Order(string customerName, int orderId)
    {
        CustomerName = customerName;
        OrderId = orderId;
        Products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public double GetOrderTotal()
    {
        double total = 0;
        foreach (var product in Products)
        {
            total += product.GetTotalPrice();
        }
        return total;
    }
}