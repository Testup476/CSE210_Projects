using System.Security.Cryptography.X509Certificates;

namespace ScriptureMemorizer;


public class Word
{
    public string _text { get; set; }
    private bool _isHiden;

    public Word(string text)
    {
        _text = text;
        _isHiden = false;
    }
    public void Hide() { _isHiden = true; }
    public void Show() { _isHiden = false; }

    public bool IsHiden() => _isHiden;

    public string GetDisplayText()
    {
        return _isHiden ? "___" : _text;
    }
    public override string ToString()
    {
        return _text;
    }

}