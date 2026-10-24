class Scripture
{
    List <Word> _words;
    private Reference _reference;

    public Scripture(string bookName, int chapter, int verse, string text)
    {
        _reference = new Reference(bookName, chapter, verse);
        _words = ConvertToWords(text);
    }
     public Scripture(string bookName, int chapter, int startVerse, int endVerse, string text)
    {
        _reference = new Reference(bookName, chapter, startVerse, endVerse);
        _words = ConvertToWords(text);
    }
    public void ShowScripture()
{
    _reference.Display();

    foreach(Word word in _words)
    {
        word.Display();
    }

    Console.WriteLine();
}
public void HideRandomWords()
{
    Random random = new Random();
    int wordsToHide = 3;

    List<Word> visibleWords = new List<Word>();

    foreach (Word word in _words)
    {
        if (!word.IsHidden())
        {
            visibleWords.Add(word);
        }
    }

    for (int i = 0; i < wordsToHide && visibleWords.Count > 0; i++)
    {
        int index = random.Next(visibleWords.Count);
        visibleWords[index].Hide();
        visibleWords.RemoveAt(index);
    }
}
public bool IsCompletelyHidden()
{
    foreach (Word word in _words)
    {
        if (!word.IsHidden())
        {
            return false;
        }
    }

    return true;
}
    //converttowords
    private List<Word> ConvertToWords(string text)
    {
        List<Word> tempWords = new List<Word>();


        string[] words = text.Split(" ");
        foreach(string word in words)
        {
            Word tempWord = new Word(word);
            tempWords.Add(tempWord);
        }
        return tempWords;
    }
}