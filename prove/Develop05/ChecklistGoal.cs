public abstract class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string shortName, string description, string points, int amountCompleted, int target) : base (shortName, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
    }
    
    public override void RecordEvent()
    {
        
    }

    public override bool isComplete()
    {
        return true;
    }

    public override string GetStringRepresentation()
    {
        return " ";
    }

    public override string GetDetailsString()
    {
        return " ";
    }
    
}