using System;
using System.Reflection.Metadata.Ecma335;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    
    public void GetCustomer()
    {
        _customer.GetCustomerName();
        _customer.GetCustomerAddress();
    }
    public void GetPackingLabel()
    {
        foreach (Product product in _products)
        {
            product.GetProductNameAndId();
            _products.Add(product);
        }

        GetCustomer();
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