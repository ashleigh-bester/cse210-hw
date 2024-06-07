using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Hairbrush", 1001);
        Console.WriteLine(product1.GetProductNameAndId());

        Address address1 = new Address("2935 Korhaan str", "Malelane", "Mpumalanga", "SA");

        Customer customer1 = new Customer("Steve", address1);
        customer1.GetCustomerName();

        Console.WriteLine(customer1.GetCustomerName());
        Console.WriteLine(address1.FullAddress());
        
        /*Order order1 = new Order(customer1);
        order1.GetPackingLabel();
        Console.WriteLine(order1);*/
    }
}