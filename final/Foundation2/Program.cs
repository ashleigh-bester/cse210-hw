using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new Customer("Steve");
        customer1.GetCustomerName();
        
        Product product1 = new Product("Hairbrush", 001);
        product1.GetProductNameAndId();

        Order order1 = new Order();
        order1.GetPackingLabel();
        Console.WriteLine(order1);
    }
}