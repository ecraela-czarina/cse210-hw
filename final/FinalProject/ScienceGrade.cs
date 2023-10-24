public class ScienceGrade : Students
{
    private double _scienceGrade;
    

    public ScienceGrade(string firstName, string lastName, double scienceGrade) : base (firstName, lastName)
    {
        _scienceGrade = scienceGrade; 
    }

    public override double ComputeGrade()
    {
        return _scienceGrade * .15;
    }
}