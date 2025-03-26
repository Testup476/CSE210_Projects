namespace YouTubeVideos;

public class Video
{
    public string _Title { get; set; }
    public string _author { get; set; }
    public int _Videosize { get; set; }
    List<Comment> _comments { get; set; }
    public Video(string title, string author, int Videosize)
    {
        _Title = title;
        _author = author;
        _Videosize = Videosize;
        _comments = new List<Comment>();
    }

    public void add_comment(string author, string comment_text)
    {
        var newcomment = new Comment(author, comment_text);
        _comments.Add(newcomment);
    }

    public string Get_number()
    {
        return $"Number of comment : {_comments.Count()}";
    }

    public List<Comment> Get_comments()
    {
        foreach (var items in _comments)
        {
            Console.WriteLine($" Author :{items._author}");
            Console.WriteLine($" Comment {items._comment_text}");
        }

        return _comments;
    }

}