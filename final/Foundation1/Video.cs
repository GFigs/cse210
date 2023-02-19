public class Video
{
    private string _title;
    private string _author;
    private int _lenght;
    public List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _lenght = length;
    }
    public string GetTitle()
    {
        return _title;
    }
    public string GetAuthor()
    {
        return _author;
    }
    public int GetLength()
    {
        return _lenght;
    }
    public int GetNumComments()
    {
        return _comments.Count();
    }

}