public class Translator
{
    /// <summary>
    /// Demonstrate the basic functionality of the Translator class.
    /// </summary>
    public static void Run()
    {
        // Create a Translator object
        var englishToGerman = new Translator();

        // Add a few words to the translator:
        //  - House translates to Haus
        //  - Car translates to Auto
        //  - Plane translates to Flugzeug
        englishToGerman.AddWord("House", "Haus");
        englishToGerman.AddWord("Car", "Auto");
        englishToGerman.AddWord("Plane", "Flugzeug");

        // Show that it works:
        Console.WriteLine(englishToGerman.Translate("Car")); // Should print "Auto"
        Console.WriteLine(englishToGerman.Translate("Plane")); // Should print "Flugzeug"

        // Show that it will return "???" if there's no translation available:
        Console.WriteLine(englishToGerman.Translate("Train")); // Should print "???"
    }

    private Dictionary<string, string> _words = new();

    /// <summary>
    /// Add the translation from 'from_word' to 'to_word'
    /// For example, in a english to german dictionary:
    /// 
    /// my_translator.AddWord("book","buch")
    /// </summary>
    /// <param name="fromWord">The word to translate from</param>
    /// <param name="toWord">The word to translate to</param>
    public void AddWord(string fromWord, string toWord)
    {
        _words[fromWord] = toWord;
    }

    /// <summary>
    /// Translates the from word into the word that this stores as the translation
    /// </summary>
    /// <param name="fromWord">The word to translate</param>
    /// <returns>The translated word or "???" if no translation is available</returns>
    public string Translate(string fromWord)
    {
        if (_words.ContainsKey(fromWord))
        {
            return _words[fromWord];
        }
        else
        {
            return "???";
        }
    }
}