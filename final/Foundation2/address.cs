using System;
public class Address
{
    protected string _street;
    protected string _city;
    protected string _state;
    protected string _country;


    public string GetAddress()
    {
        return ($"{_street}, {_city}, {_state} {_country}");
    }

    public string GetCountry()
    {
        return _country;
    }
}