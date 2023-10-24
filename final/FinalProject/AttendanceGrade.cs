public class AttendanceGrade : Students
{
    private double _attendanceGrade;
    

    public AttendanceGrade(string firstName, string lastName, double attendanceGrade) : base (firstName, lastName)
    {
        _attendanceGrade = attendanceGrade; 
    }

    public override double ComputeGrade()
    {
        return _attendanceGrade * .10;
    }
}