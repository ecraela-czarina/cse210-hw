public abstract class RecitationGrade : Students
{
    private int _recitationGrade;
    

    public ScienceGrade(string firstName, string lastName, int recitationGrade) : base (firstName, lastName)
    {
        _recitationGrade = recitationGrade; 
    }

    public abstract int ComputeGrade()
    {
        return _recitationGrade * .10;
    }
}