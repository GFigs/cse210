public class Comment
{
    private string _user;
    private string _text;
    public Comment(string user, string text)
    {
        _text = text;
        _user = user;
    }
    public string GetUser()
    {
        return _user;
    }
    public string GetText()
    {
        return _text;
    }
}