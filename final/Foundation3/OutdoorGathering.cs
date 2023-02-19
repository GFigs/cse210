public class OutdoorGathering : Event
{
    private string _weatherCondition;

    public OutdoorGathering(string weather, string title, string description, string date, string time, string streetAdress, string city)
        : base(title, description, date, time, streetAdress, city)
    {
        _weatherCondition = weather;
    }
    public string ShortDescription()
    {
        return string.Format("Outdoor Gathering: {0} on {1}", GetTitle(), GetDate());
    }
    public string GetFullDetails()
    {
        return string.Format("{0}. The speaker is {1}. The day is expected to be {1}", GetStandardDetails(), _weatherCondition);
    }
}