using System;

public class Customer
{
    private string _customerName;
    private Address _customerAddress;

    public Customer(string customerName)
    {
        _customerName = customerName;
    }

    public string GetCustomerName()
    {
        return _customerName;
    }

    public void GetCustomerAddress()
    {
        _customerAddress.FullAddress();
    }

    public bool VarifyCountry()
    {
        if (_customerAddress.GetCountry() != "USA")
        {
            return false;
        }
        else
        {
        return true;
        }
    }
}