public abstract class Goal
{
    private string _shortName;
    private string _description;
    private string _points;
    // private string _checkedGoal;

    public Goal(string shortName, string description, string points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool isComplete();


    public virtual string GetDetailsString()
    {
        return ($" [ ] {_shortName} ({_description}) ");
    }

    

    public abstract string GetStringRepresentation();
}