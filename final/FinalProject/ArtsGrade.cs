public abstract class ArtsGrade : Students
{
    private int _artsGrade;
    

    public ScienceGrade(string firstName, string lastName, int artsGrade) : base (firstName, lastName)
    {
        _artsGrade = artsGrade;
    }

    public abstract int ComputeGrade()
    {
        return _artsGrade * .15;
    }
}