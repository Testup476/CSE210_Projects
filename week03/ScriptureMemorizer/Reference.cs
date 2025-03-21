using System.Data;
using System.Dynamic;

namespace ScriptureMemorizer;

public class Reference
{
    private string _book { get; set; }
    private int _chapter { get; set; }
    private List<int> _verses { get; set; } // This list will stoke 1 or more verses
    private int _endVerse { get; set; }
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verses = new List<int> { verse };
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verses = Enumerable.Range(startVerse, endVerse - startVerse + 1).ToList();
    }

    public string GetDisplayText()
    {
        string verse = _verses.Count() == 1 ? _verses[0].ToString() : $"{_verses.First()}-{_verses.Last()}";
        return $"{_book} {_chapter}: {verse}";
    }

}