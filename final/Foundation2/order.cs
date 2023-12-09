public class Order
{
    protected double _shippingFee =5;
    protected double _totalPrice;
    // private string item;
    protected Address address;
    protected Address country;
    protected Customer name;
    protected Product productName;
    protected Product productId;
    // public List<Product> items = new List<Product>();
    public Order()
    {
        //ShippingLabel();
        //GetShippingFee();
    }
    public void DisplayOrder(double totalPrice)
    {
        ShippingLabel();
        Console.WriteLine($"The order total is{totalPrice}");

    }

    public double GetShippingFee()
    {
        return _shippingFee;
    }
    public void SetShippingFee(int shippingFee)
    {
        _shippingFee = shippingFee;
    }
    public double GetTotalPrice()
    {
        return _totalPrice;
    }
    public void SetTotalPrice(int totalPrice)
    {
        _totalPrice = totalPrice;
    }
    public void CheckAdress(int shippingFee)
    {
        string country = "USA";
        Boolean parsedValue;

        if (Boolean.TryParse(country, out parsedValue))
        {
            if (parsedValue)
            {
                shippingFee = 5;
            }
            else
            {
                shippingFee = 35;
            }
        }
        else
        {
            Console.WriteLine("Invalid country");
        }
    }
    public int TotalPrice(int total, int shippingFee)
    {
        int totalPrice = total + shippingFee;
        return totalPrice;

    }
    public string ShippingLabel()
    {
        return $"Name: {name}. Address: {address}";
    }
    public void PackingLabel()
    {
        Console.WriteLine($"product: {productName} productID {productId}");
    }
}
