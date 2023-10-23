public abstract class Students
{
    private string _firstName;
    private string _lastName;

    public Students(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
    }

    public abstract int ComputeGrade();
}