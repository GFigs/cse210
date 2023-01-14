using System;

public class Entry
{
    public string _prompt;
    public string _response;
    public string _date;

    public void AddToEntries(List<Entry> entries)
    {
        entries.Add(this);
    }

    public void GetDate()
    {
        DateTime currentTime = DateTime.Now;
        this._date = currentTime.ToShortDateString();
    }
}