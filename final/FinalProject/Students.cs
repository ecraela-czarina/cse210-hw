public abstract class Students
{
    private string _firstName;
    private string _lastName;
    
    

    public Students(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
        
    }

    public string GetFirstName()
    {
        return _firstName;
        
    }

    public void SetFirstName(string firstName)
    {
        _firstName = firstName;
    }


    public abstract double ComputeGrade();

    
}