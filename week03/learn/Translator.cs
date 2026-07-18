public class Translator
{
    public static void Run()
    {
        var englishToGerman = new Translator();
        englishToGerman.AddWord("House", "Haus");
        englishToGerman.AddWord("Car", "Auto");
        englishToGerman.AddWord("Plane", "Flugzeug");
        Console.WriteLine(englishToGerman.Translate("Car")); // Auto
        Console.WriteLine(englishToGerman.Translate("Plane")); // Flugzeug
        Console.WriteLine(englishToGerman.Translate("Train")); // ???
    }

    private Dictionary<string, string> _words = new(); //create the dictionary (empty)

    public void AddWord(string fromWord, string toWord) //adding words
    {
        _words[fromWord] = toWord; //replaces variables with actual values STORES A VALUE "SET THE KEY"
    }
    public string Translate(string fromWord)
    {
        string newWord = "???"; //assuming we don't know the answer

        if (_words.ContainsKey(fromWord)) //replace the variable if there is a match
        {
            newWord = _words[fromWord];// RETRIEVES A VALUE "GO FIND A VALUE UNDER THIS KEY"
        }

        return newWord;
    }
}