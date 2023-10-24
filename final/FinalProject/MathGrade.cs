public class MathGrade : Students
{
    private double _mathGrade;
    

    public MathGrade(string firstName, string lastName, double mathGrade) : base (firstName, lastName)
    {
        _mathGrade = mathGrade; 
    }

    public override double ComputeGrade()
    {
        return _mathGrade * .20;
    }
}