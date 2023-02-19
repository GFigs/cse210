public class Address
{
    private string _streetAdress;
    private string _city;


    public Address(string streetAdress, string city)
    {
        _streetAdress = streetAdress;
        _city = city;
    }
    public string DisplayAddress()
    {
        return String.Format("{0} - {1}", _streetAdress, _city);
    }
    public string GetStreetAdress()
    {
        return _streetAdress;
    }
    public string GetCity()
    {
        return _city;
    }

}