public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();
    
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // using loops to iterate list of jobs
        foreach (Job job in _jobs)
        {
            //Display method on each job
            job.Display();
        }
    }

}