using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        Order order1 = new Order("Abdulla Mohammed", 1001);
        order1.AddProduct(new Product("Notebook", 3.50, 5));
        order1.AddProduct(new Product("Caligraphing Pen", 1.20, 10));
        order1.AddProduct(new Product("Stapler", 6.75, 1));
        orders.Add(order1);

        Order order2 = new Order("Mobutu Smith", 1002);
        order2.AddProduct(new Product("USB Drive", 12.99, 2));
        order2.AddProduct(new Product("Keyboard", 29.99, 1));
        order2.AddProduct(new Product("Codeless Mouse", 14.99, 1));
        orders.Add(order2);

        Order order3 = new Order("Czarinna Lukmon", 1003);
        order3.AddProduct(new Product("Monitor", 199.99, 1));
        order3.AddProduct(new Product("HDMI Cable", 9.99, 2));
        order3.AddProduct(new Product("Desk Lamp", 24.50, 1));
        orders.Add(order3);

        foreach (var order in orders)
        {
            Console.WriteLine($"Order ID: {order.OrderId} | Customer: {order.CustomerName}");
            Console.WriteLine("Products:");
            foreach (var product in order.Products)
            {
                Console.WriteLine($" - {product.Name} x{product.Quantity} @ ${product.Price:F2} each (Total: ${product.GetTotalPrice():F2})");
            }
            Console.WriteLine($"Total Order Cost: ${order.GetOrderTotal():F2}");
            Console.WriteLine(new string('-', 40));
        }
    }
}