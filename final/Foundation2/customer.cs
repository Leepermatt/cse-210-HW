public class Customer
{
    protected string _name;
    public Customer(string name)
    {
        _name = name;
    }
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetCustomer(string name)
    {
        return $"name: {name} ";
    }
}