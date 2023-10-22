public class SimpleGoal : Goal
{
    private bool _isComplete;
    private string _checkedGoal;

    public SimpleGoal(string shortName, string description, string points, bool isComplete) : base (shortName, description, points)
    {
        _isComplete = isComplete;
    }
    
    public override void RecordEvent()
    {
        if (_isComplete == true)
        {
            _checkedGoal = "X";
        }

    }

    public override bool isComplete()
    {
        return true;
    }

    public override string GetStringRepresentation()
    {
        return " ";
        // return ($" [{_checkedGoal}] {shortName}~~{description}~~{points} ");
    }
    
}