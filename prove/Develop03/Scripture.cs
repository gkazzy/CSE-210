using System;
using System.Collections.Generic;
using System.Linq;
public class Scripture
{
    private ScriptureReference _reference;
    private List<Word> _words;
    public int HiddenWordCount {
    get
    {
        return _words.Count(word => word.IsHidden);
    }
                                }
    public int TotalWords => _words.Count;

    public Scripture(ScriptureReference reference, string scriptureText)
    {
    _reference = reference;
    _words = new List<Word>();

    string[] wordsArray = scriptureText.Split(' ');
    foreach (string word in wordsArray)
    {
        _words.Add(new Word(word));
    }
    }


    public void DisplayScripture()
    {
    Console.WriteLine(_reference);
    foreach (Word word in _words)
    {
        Console.Write(word.Display() + " ");
    }
    Console.WriteLine(); 
    }

    public void HideRandomWords(int count)
    {
        Random rand = new Random();
        int wordsToHide = Math.Min(count, _words.Count - HiddenWordCount); 
        for (int i = 0; i < wordsToHide; i++)
        {
            int index;
            do
            {
                index = rand.Next(_words.Count);
            } while (_words[index].IsHidden); 
            _words[index].Hide(); 
        }
    }
}