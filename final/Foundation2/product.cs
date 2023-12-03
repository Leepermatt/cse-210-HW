using System;
public class Product
{
    protected string _name;
    protected string _productId;
    protected int _quantity;
    protected int _price;

    static int GetTotalPrice(int _price, int _quantity)
    {
        int _total = _quantity * _price;
        return _total;
    }
}