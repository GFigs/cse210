public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _adress;

    public Event(string title, string description, string date, string time, string streetAdress, string city)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _adress = new Address(streetAdress, city);

    }
    public string GetStandardDetails()
    {
        return String.Format("{0}: {1}. On {2} at {3}, {4}", _title, _description, _date, _time, _adress.DisplayAddress());
    }
    public string GetTitle()
    {
        return _title;
    }
    public string GetDate()
    {
        return _date;
    }
}