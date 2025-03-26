
namespace YouTubeVideos;

public class Comment
{
    public string _author { get; set; }
    public string _comment_text { get; set; }

    public Comment(string author, string comment_text)
    {
        _author = author;
        _comment_text = comment_text;
    }
}
