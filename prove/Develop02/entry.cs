using System; 
using System.Collections.Generic; 
using System.IO;

public class Entry
{
    public string _prompt;
    public string _response;
    public DateTime _date { get; set; }

    public Entry(string prompt, string response)
    {
        _prompt = prompt;
        _response = response;
    }
}