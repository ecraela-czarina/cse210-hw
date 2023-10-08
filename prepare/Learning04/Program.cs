using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment newMathAssign = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19" );
        Console.WriteLine(newMathAssign.GetSummary());
        Console.WriteLine(newMathAssign.GetHomeworkList());

        WritingAssignment newWritingAssign = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters" );
        Console.WriteLine(newWritingAssign.GetSummary());
        Console.WriteLine(newWritingAssign.GetWritingInfo());
    }
}