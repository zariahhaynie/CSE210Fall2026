using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Gerard Gutter", "Multiplication");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment math = new MathAssignment("Lion Brot", "Division", "7.3", "8-19");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

WritingAssignment writing = new WritingAssignment("Mikssy Hubert", "History", "First history writing assignment");
Console.WriteLine(writing.GetSummary());
Console.WriteLine(writing.GetWritingInformation());
    }
}