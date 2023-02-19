public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string speaker, int capacity, string title, string description, string date, string time, string streetAdress, string city)
        : base(title, description, date, time, streetAdress, city)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public string ShortDescription()
    {
        return string.Format("Lecture: {0} on {1}", GetTitle(), GetDate());
    }
    public string GetFullDetails()
    {
        return string.Format("{0}. The speaker is {1}. The capacity of the event is {2} people", GetStandardDetails(), _speaker, _capacity);
    }
}