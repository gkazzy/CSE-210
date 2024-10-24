class Program
{
    static void Main()
    {
        ScriptureReference reference = new ScriptureReference("Moroni", 10, 4, 5);
        string scriptureText = "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things.";

        Scripture scripture = new Scripture(reference, scriptureText);
        Console.Clear();
        scripture.DisplayScripture();

        while (true)
        {
            Console.WriteLine("\n Press Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.Trim().ToLower() == "quit")
                break;

            Console.Clear();
            if (scripture.HiddenWordCount < scripture.TotalWords)
            {
                scripture.HideRandomWords(3); 
                scripture.DisplayScripture();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("All words are hidden!");
                break;
            }
        }
    }
}
