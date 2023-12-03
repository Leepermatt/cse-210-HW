public class Order
{
    protected int _shippingFee;
    protected Address _address;
    protected Address _country;
    protected Customer _name;
    protected int _shippingFee;

        public void CheckAdress()
    {
        string _country = "USA";
        Boolean parsedValue;

        if (Boolean.TryParse(_country, out parsedValue))
        {
            if (parsedValue)
            {
                int _shippingFee = 5;
            }
            else
            {
                int _shippingFee = 35;
            }
        }
        else
        {
            Console.WriteLine("Invalid country");
        }

    }
}