public class RecitationGrade : Students
{
    private double _recitationGrade;
    

    public RecitationGrade(string firstName, string lastName, double recitationGrade) : base (firstName, lastName)
    {
        _recitationGrade = recitationGrade; 
    }

    public override double ComputeGrade()
    {
        return _recitationGrade * .10;
    }
}