public class Address
{
    private string _streetAdress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string streetAdress, string city, string state, string country)
    {
        _streetAdress = streetAdress;
        _city = city;
        _state = state;
        _country = country;
    }
    public string GetStreetAdress()
    {
        return _streetAdress;
    }
    public string GetCity()
    {
        return _city;
    }
    public string GetState()
    {
        return _state;
    }
    public string GetCountry()
    {
        return _country;
    }

    public bool isUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string DisplayAddress()
    {
        return String.Format("{0}, {1}, {2}, {3}", _streetAdress, _city, _state, _country);
    }
}