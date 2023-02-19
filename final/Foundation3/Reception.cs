public class Reception : Event
{
    private string _email;

    public Reception(string email, string title, string description, string date, string time, string streetAdress, string city)
        : base(title, description, date, time, streetAdress, city)
    {
        _email = email;
    }
    public string ShortDescription()
    {
        return string.Format("Reception: {0} on {1}", GetTitle(), GetDate());
    }
    public string GetFullDetails()
    {
        return string.Format("{0}. Please confirm assistance to {1}", GetStandardDetails(), _email);
    }
}
