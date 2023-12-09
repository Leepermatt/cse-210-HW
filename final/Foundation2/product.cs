using System;
using System.Runtime.CompilerServices;
public class Product
{
    protected string _productName;
    protected string _productId;
    protected int _quantity;
    protected double _price;
    protected int _total;
    public List<Product> items = new List<Product>();
    public Product(string productName, string productId, double price, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    public string GetProductName()
    {
        return _productName;
    }
    public void SetProductName(string productName)
    {
        _productName = productName;
    }
    public string GetProductId()
    {
        return _productName;
    }
    public void SetProductId(string productId)
    {
        _productId = productId;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }
    public double GetPrice()
    {
        return _price;
    }
    public void SetPrice(int price)
    {
        _price = price;
    }
    public int GetTotal()
    {
        return _total;
    }
    public void SetTotal(int total)
    {
        _total = total;
    }
    public int GetProductPrice(int quantity, int price)
    {
        int total = quantity * price;
        return total;
    }
    public void PackingLabel()
    {
        Console.WriteLine($"Product Name: {_productName} Product ID: {_productId}");
        foreach(Product item in items)
        {
            item.PackingLabel();
        }
    }
    
}