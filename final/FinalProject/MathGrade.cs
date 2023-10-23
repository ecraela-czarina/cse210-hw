public abstract class MathGrade : Students
{
    private int _mathGrade;
    

    public MathGrade(string firstName, string lastName, int mathGrade) : base (firstName, lastName)
    {
        _mathGrade = mathGrade; 
    }

    public abstract int ComputeGrade()
    {
        return _mathGrade * .20;
    }
}