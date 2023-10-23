public abstract class HistoryGrade : Students
{
    private int _historyGrade;
    

    public ScienceGrade(string firstName, string lastName, int historyGrade) : base (firstName, lastName)
    {
        _historyGrade = historyGrade;
    }

    public abstract int ComputeGrade()
    {
        return _historyGrade * .15;
    }
}