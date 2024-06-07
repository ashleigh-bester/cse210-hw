using System;

public class Customer
{
    private string _customerName;
    private Address _customerAddress;

    public Customer(string customerName, Address customerAddress)
    {
        _customerName = customerName;
        _customerAddress = customerAddress;
    }

    public string GetCustomerName()
    {
        return $"Recipient: {_customerName}";
    }

    /*public string GetCustomerAddress()
    {
        
        return _customerAddress.FullAddress();
    }*/

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