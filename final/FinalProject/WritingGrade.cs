public abstract class WritingGrade : Students
{
    private int _writingGrade;
    

    public ScienceGrade(string firstName, string lastName, int writingGrade) : base (firstName, lastName)
    {
        _writingGrade = writingGrade;
    }

    public abstract int ComputeGrade()
    {
        return _writingGrade * .15;
    }
}