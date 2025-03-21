
using System.Collections;
using System.Runtime.CompilerServices;

namespace ScriptureMemorizer;

public class Scripture
{
    private Reference _reference { get; }
    private static List<Word> _word = new List<Word>();
    private static Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] Array = text.Split(new char[] { ' ' }, StringSplitOptions.TrimEntries);
        foreach (string items in Array)
        {
            _word.Add(new Word(items));
        }
    }
    public void HideRandomwords(int number)
    {
        var wordIndices = new HashSet<int>();
        while (wordIndices.Count < number)
        {
            wordIndices.Add(_random.Next(_word.Count));
        }
        foreach (var index in wordIndices)
        {
            _word[index].Hide();
        }
    }

    public string GetDisplayText()
    {
        return string.Join("", _word.Select(word => word.GetDisplayText()));
    }
    public bool IsCompletelyHidden()
    {
        return _word.All(words => words.IsHiden());
    }
}