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
    // falta metodo para sacar la fecha actual. 
}