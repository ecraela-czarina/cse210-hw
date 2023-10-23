public abstract class ScienceGrade : Students
{
    private int _scienceGrade;
    

    public ScienceGrade(string firstName, string lastName, int scienceGrade) : base (firstName, lastName)
    {
        _scienceGrade = scienceGrade; 
    }

    public abstract int ComputeGrade()
    {
        return _scienceGrade * .15;
    }
}