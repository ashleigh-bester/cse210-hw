using System;
using System.Reflection.Metadata.Ecma335;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    
    public Order(Customer customer)
    {
        _customer = customer;
    }

    public string GetCustomer()
    {
        return _customer.GetCustomerName();
        //_customer.GetCustomerAddress();
    }

    public void GetProduct()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine(product);
        }
    }
    public string GetPackingLabel()
    {
        return "";
    }

    public string GetShippingLabel()
    {
        return "";
    }
    public double OrderTotalPrice()
    {
        return 00;
    }
}