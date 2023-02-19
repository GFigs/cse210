public class Customer
{
    private string _name;

    private Address _adress;
    public Customer(string name, string streetAdress, string city, string state, string country)
    {
        _name = name;
        _adress = new Address(streetAdress, city, state, country);
    }
    public Customer(string name, Address address)
    {
        _name = name;
        _adress = address;
    }
    public bool isUSA()
    {
        return _adress.isUSA();
    }
    public void DisplayCustomerInfo()
    {
        Console.WriteLine(_name);
        Console.WriteLine(_adress.GetStreetAdress());
        Console.WriteLine(_adress.GetCity());
        Console.WriteLine(_adress.GetState());
        Console.WriteLine(_adress.GetCountry());
    }
}