using System;
using System.Dynamic;

public class Product
{
    private string _productName;
    private int _productId;
    private double _price = 0;
    private int _quantity = 0;

    public Product(string productName, int productId)
    {
        _productName = productName;
        _productId = productId;
    }

    public string GetProductNameAndId()
    {
        return $"{_productName} | ID ({_productId})";
    }
    public double TotalCostProduct()
    {
        return _price * _quantity;
    }
}