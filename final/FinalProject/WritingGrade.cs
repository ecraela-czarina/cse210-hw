public class WritingGrade : Students
{
    private double _writingGrade;
    

    public WritingGrade(string firstName, string lastName, double writingGrade) : base (firstName, lastName)
    {
        _writingGrade = writingGrade;
    }

    public override double ComputeGrade()
    {
        return _writingGrade * .15;
    }
}