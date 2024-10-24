using System;
using System.Collections.Generic;
using System.Linq;

public class ScriptureReference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int? _endVerse;

    public string Book { get; private set; }
    public int Chapter { get; private set; }
    public int StartVerse { get; private set; }
    public int? EndVerse { get; private set; }

    public ScriptureReference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        EndVerse = null; // Single verse
    }

    public ScriptureReference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse; // Range of verses
    }

    public override string ToString() {
    if (EndVerse.HasValue)
    {
        return _book + " " + _chapter + ":" + _startVerse + "-" + EndVerse;
    }
    else
    {
        return _book + " " + _chapter + ":" + _startVerse;
    }
    }
}