public abstract class AttendanceGrade : Students
{
    private int _attendanceGrade;
    

    public ScienceGrade(string firstName, string lastName, int attendanceGrade) : base (firstName, lastName)
    {
        _attendanceGrade = attendanceGrade; 
    }

    public abstract int ComputeGrade()
    {
        return _attendanceGrade * .10;
    }
}