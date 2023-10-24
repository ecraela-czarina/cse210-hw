public class HistoryGrade : Students
{
    private double _historyGrade;
    

    public HistoryGrade(string firstName, string lastName, double historyGrade) : base (firstName, lastName)
    {
        _historyGrade = historyGrade;
    }

    public override double ComputeGrade()
    {
        return _historyGrade * .15;
    }
}