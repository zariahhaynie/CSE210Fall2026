class Reference
{
    private string _bookName;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference(string bookName, int chapter, int verse)
{
    _bookName = bookName;
    _chapter = chapter;
    _startVerse = verse;
    _endVerse = verse;
}
public Reference(string bookName, int chapter, int startVerse, int endVerse)
{
    _bookName = bookName;
    _chapter = chapter;
    _startVerse = startVerse;
    _endVerse = endVerse;
}
public void Display()
{
    if (_startVerse == _endVerse)
    {
        Console.Write($"{_bookName} {_chapter}:{_startVerse} ");
    }
    else
    {
        Console.Write($"{_bookName} {_chapter}:{_startVerse}-{_endVerse} ");
    }
}
}