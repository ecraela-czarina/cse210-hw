public class ArtsGrade : Students
{
    private double _artsGrade;
    

    public ArtsGrade(string firstName, string lastName, double artsGrade) : base (firstName, lastName)
    {
        _artsGrade = artsGrade;
    }

    public override double ComputeGrade()
    {
        return _artsGrade * 0.15;
    }
}