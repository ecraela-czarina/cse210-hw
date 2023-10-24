using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Here is the Rubric for the Course: ");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("|     CATEGORY     |      WEIGHT       |");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("|       Math       |        20%        |");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("|     Science      |        20%        |");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("|    Attendance    |        10%        |");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("|    Recitation    |        10%        |");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("|     Writing      |        15%        |");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("|      Arts        |        10%        |");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("|     History      |        15%        |");
        Console.WriteLine("----------------------------------------");

        List<Students> students = new List<Students>();

                  
        
        Console.WriteLine("What is the FIRST name of the Student? ");
        string firstName = Console.ReadLine();
        Console.WriteLine("What is the LAST name of the Student? ");
        string lastName = Console.ReadLine();

                
        Console.WriteLine("Enter Math Grade: ");
        int math = int.Parse(Console.ReadLine());
        MathGrade mathGrade1 = new MathGrade(firstName, lastName, math);
        students.Add(mathGrade1);

        Console.WriteLine("Enter Science Grade: ");
        int science = int.Parse(Console.ReadLine());
        ScienceGrade scienceGrade1 = new ScienceGrade(firstName, lastName, science);
        students.Add(scienceGrade1);

        Console.WriteLine("Enter Attendance Grade: ");
        int attendance = int.Parse(Console.ReadLine());
        AttendanceGrade attendanceGrade1 = new AttendanceGrade(firstName, lastName, attendance);
        students.Add(attendanceGrade1);


        Console.WriteLine("Enter Recitation Grade: ");
        int recitation = int.Parse(Console.ReadLine());
        RecitationGrade recitationGrade1 = new RecitationGrade(firstName, lastName, recitation);
        students.Add(recitationGrade1);

        Console.WriteLine("Enter Writing Grade: ");
        int writing = int.Parse(Console.ReadLine());
        WritingGrade writingGrade1 = new WritingGrade(firstName, lastName, writing);
        students.Add(writingGrade1);

        Console.WriteLine("Enter Arts Grade: ");
        int arts = int.Parse(Console.ReadLine());
        ArtsGrade artsGrade1 = new ArtsGrade(firstName, lastName, arts);
        students.Add(artsGrade1);

        Console.WriteLine("Enter History Grade: ");
        int history = int.Parse(Console.ReadLine());
        HistoryGrade historyGrade1 = new HistoryGrade(firstName, lastName, history);
        students.Add(historyGrade1);

        double totalGrade = 0;
        foreach (Students student in students)
        {
            string studentName = student.GetFirstName();

            double rubricGrade = student.ComputeGrade();

            totalGrade += rubricGrade;
                    
        }
        Console.WriteLine("Computing the grade...");
        Thread.Sleep(1000);
        Console.WriteLine("Please wait...");
        Thread.Sleep(1000);
        Console.WriteLine ($"Name: {lastName}, {firstName} \n Total Grade:{totalGrade}");
                
     }
}
        
        
        


