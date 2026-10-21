class Scripture
{
    List <Word> _words;
    //add scriputre reference

    public Scripture(string bookName, int chapter, int verse, string text)
    {
        //add scripture reference here, use bookName, chapter, and verse to create
        _words = ConvertToWords(text);
    }
     public Scripture(string bookName, int chapter, int startVerse, int endVerse, string text)
    {
        //todo
    }
    public void ShowScripture()
    {
        foreach(Word word in _words)
        {
            word.Display();
        }
    }
    //converttowords
    private List<Word> ConvertToWords(string text)
    {
        List<Word> tempWords = new List<Word>();


        string[] words = text.Split("");
        foreach(string word in words)
        {
            Word tempWord = new Word(word);
            tempWords.Add(tempWord);
        }
        return tempWords;
    }
}